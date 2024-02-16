using AutoMapper;
using FakeXiecheng.API.Controllers.ResourceParameters;
using FakeXiecheng.API.Dtos;
using FakeXiecheng.API.Dtos.Validators;
using FakeXiecheng.API.DTOs;
using FakeXiecheng.API.Models;
using FakeXiecheng.API.Repositories;
using FakeXiecheng.API.Services.QueryParameters;
using FakeXiecheng.API.Services.QueryParameters.Enums;
using FluentValidation;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Operations;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace FakeXiecheng.API.Services
{
    public class TouristRouteService : ITouristRouteService
    {
        private readonly ITouristRouteRepository _touristRouteRepository;
        private readonly ITouristRoutePictureRepository _touristRoutePictureRepository;
        private readonly IMapper _mapper;

        public TouristRouteService(ITouristRouteRepository touristRouteRepository, ITouristRoutePictureRepository touristRoutePictureRepository, IMapper mapper)
        {
            _touristRouteRepository = touristRouteRepository;
            _touristRoutePictureRepository = touristRoutePictureRepository;
            _mapper = mapper;
        }

        public async Task<TouristRouteResponseDto?> ProcessGetTouristRouteByIdAsync(Guid touristRouteId)
        {
            var touristRouteEntity = await _touristRouteRepository.FindTouristRouteByIdAsync(touristRouteId);
            var touristRouteResponseDto = _mapper.Map<TouristRouteResponseDto>(touristRouteEntity);

            return touristRouteResponseDto;
        }

        public async Task<IEnumerable<TouristRouteResponseDto>> ProcessGetTouristRouteListAsync(TouristRoutesResourceParameters resourceParameters)
        {
            TouristRoutesQueryParameters queryParameters = new()
            {
                Keyword = resourceParameters.Keyword?.Trim()
            };

            if (!string.IsNullOrEmpty(resourceParameters.Rating))
            {
                // 提取过滤条件
                string pattern = @"(lessThan|greaterThan|equalTo)(\d+)";
                var match = Regex.Match(resourceParameters.Rating, pattern);

                if (!match.Success)
                {
                    throw new ArgumentException("参数解析失败，评分参数格式错误或无效。");
                }

                if (Enum.TryParse(match.Groups[1].Value, true, out RatingOperatorType ratingOperator))
                {
                    queryParameters.RatingOperator = ratingOperator;
                }
                else
                {
                    throw new ArgumentException("参数解析失败，无法解析评分操作符。");
                }

                if (int.TryParse(match.Groups[2].Value, out var ratingValue))
                {
                    queryParameters.RatingValue = ratingValue;
                }
                else
                {
                    throw new ArgumentException("参数解析失败，无法解析评分值。");
                }
            }


            var touristRouteList = await _touristRouteRepository.FindTouristRouteListAsync(queryParameters);
            var touristRouteResponseDtoList = _mapper.Map<IEnumerable<TouristRouteResponseDto>>(touristRouteList);

            return touristRouteResponseDtoList;
        }

        public async Task<TouristRouteResponseDto?> ProcessAddTouristRouteAsync(TouristRouteCreateDto touristRouteCreateDto)
        {
            var touristRouteEntity = _mapper.Map<TouristRoute>(touristRouteCreateDto);
            var result = await _touristRouteRepository.AddAsync(touristRouteEntity);

            if (result is not 0)
            {
                var touristRouteResponseDto = _mapper.Map<TouristRouteResponseDto>(touristRouteEntity);

                return touristRouteResponseDto;
            }
            else
            {
                return null;
            }
        }

        public async Task<int?> ProcessUpdateTouristRouteAsync(Guid touristRouteId, TouristRouteUpdateDto touristRouteUpdateDto)
        {
            var touristRouteEntity = await _touristRouteRepository.FindTouristRouteByIdAsync(touristRouteId);

            if (touristRouteEntity is null)
            {
                return null;
            }

            // 更新实例
            _mapper.Map(touristRouteUpdateDto, touristRouteEntity);

            // 已有图片的ID集合
            var currentPictureIdList = touristRouteEntity.TouristRoutePictures.Select(p => p.Id).ToList();
            // 当前图片的ID集合
            var updatedPictureIdList = touristRouteUpdateDto.TouristRoutePictures
                .Where(p => p.Id.HasValue)
                .Select(p => p.Id!.Value)
                .ToList();
            // 需要移除的图片集合
            var pictureIdListToRemove = currentPictureIdList.Except(updatedPictureIdList);

            if (!pictureIdListToRemove.IsNullOrEmpty())
            {
                // 软删除需要移除的图片
                List<TouristRoutePicture> pictureListToRemove = new();

                foreach (var pictureIdToRemove in pictureIdListToRemove)
                {
                    // 验证图片是否存在
                    var pictureToRemove = touristRouteEntity.TouristRoutePictures.FirstOrDefault(p => p.Id == pictureIdToRemove);

                    if (pictureToRemove is not null)
                    {
                        pictureListToRemove.Add(pictureToRemove);
                    }
                }

                _touristRoutePictureRepository.MarkPictureListAsDeleted(pictureListToRemove);
            }

            // 添加新图片
            foreach (var pictureDto in touristRouteUpdateDto.TouristRoutePictures)
            {
                if (pictureDto.Id is null)
                {
                    // 创建并添加新的图片对象到实体，touristRouteId 由 EF Core 自动填充
                    var newPictureEntity = _mapper.Map<TouristRoutePicture>(pictureDto);
                    touristRouteEntity.TouristRoutePictures.Add(newPictureEntity);
                }
                else
                {
                    var existPicture = touristRouteEntity.TouristRoutePictures.FirstOrDefault(p => p.Id == pictureDto.Id);
                    if (existPicture != null)
                    {
                        // 更新存在的图片数据
                        _mapper.Map(pictureDto, existPicture);
                        existPicture.LastUpdatedTime = DateTimeOffset.Now;
                    }
                }
            }

            touristRouteEntity.LastUpdatedTime = DateTimeOffset.Now;

            return await _touristRouteRepository.SaveAsync();
        }

        public async Task<int?> ProcessPartialUpdateTouristRouteAsync(Guid touristRouteId, JsonPatchDocument<TouristRoutePartialUpdateDto> patchDocument)
        {
            var touristRouteEntity = await _touristRouteRepository.FindTouristRouteByIdAsync(touristRouteId);

            if (touristRouteEntity is null)
            {
                return null;
            }

            // 记录修改时间
            var currentTime = DateTimeOffset.Now;

            // 处理对图片 remove 操作
            var removeOperations = patchDocument.Operations
                .Where(op => op.OperationType == OperationType.Remove
                        && op.path.StartsWith("/touristRoutePictures", StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (removeOperations.Any())
            {
                // 软删除需要移除的图片
                List<TouristRoutePicture> pictureListToRemove = new();

                foreach (var op in removeOperations)
                {
                    // 解析待删除项的索引
                    var pictureIndexString = op.path.Split('/').Last();

                    if (!int.TryParse(pictureIndexString, out int pictureIndex))
                    {
                        return -1;
                    }

                    // 验证图片是否存在
                    var pictureToRemove = touristRouteEntity.TouristRoutePictures.ElementAtOrDefault(pictureIndex);

                    if (pictureToRemove is null)
                    {
                        return -1;
                    }

                    pictureListToRemove.Add(pictureToRemove);
                }

                _touristRoutePictureRepository.MarkPictureListAsDeleted(pictureListToRemove, currentTime);
            }

            // 处理对图片 replace 操作
            var replaceOperations = patchDocument.Operations
                .Where(op => op.OperationType == OperationType.Replace
                        && op.path.StartsWith("/touristRoutePictures", StringComparison.OrdinalIgnoreCase))
                .ToList();

            foreach (var op in replaceOperations)
            {
                // 解析待替换项的索引
                var pictureIndexString = op.path.Split('/').Last();

                if (!int.TryParse(pictureIndexString, out int pictureIndex))
                {
                    return -1;
                }

                // 验证图片是否存在
                var pictureToReplace = touristRouteEntity.TouristRoutePictures.ElementAtOrDefault(pictureIndex);

                if (pictureToReplace is null)
                {
                    return -1;
                }

                // 解析 url 地址
                var valueObject = op.value as JObject;
                string? url = valueObject?.SelectToken("url")?.ToString();

                if (string.IsNullOrEmpty(url) || !Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    return -1;
                }

                _touristRoutePictureRepository.PartialUpdatePicture(pictureToReplace, url, currentTime);
            }

            // 创建一个新的 JsonPatchDocument 实例，去除对图片的 remove replace 操作
            var filteredPatchDocument = new JsonPatchDocument<TouristRoutePartialUpdateDto>();

            foreach (var op in patchDocument.Operations)
            {
                // 如果路径以“/TouristRoutePictures”开头且操作为“remove”或“replace”，则跳过此操作不添加
                if (op.path.StartsWith("/TouristRoutePictures", StringComparison.OrdinalIgnoreCase))
                {
                    if (op.OperationType == OperationType.Remove || op.OperationType == OperationType.Replace)
                    {
                        continue;
                    }
                }

                // 将非目标操作添加到新的 JsonPatchDocument 实例中
                filteredPatchDocument.Operations.Add(op);
            }

            var touristRoutePartialUpdateDto = _mapper.Map<TouristRoutePartialUpdateDto>(touristRouteEntity);
            filteredPatchDocument.ApplyTo(touristRoutePartialUpdateDto);

            // 验证模型
            var validator = new TouristRoutePartialUpdateDtoValidator();
            var validationResult = validator.Validate(touristRoutePartialUpdateDto);

            if (!validationResult.IsValid)
            {
                return -1;
            }

            _mapper.Map(touristRoutePartialUpdateDto, touristRouteEntity);

            touristRouteEntity.LastUpdatedTime = currentTime;

            return await _touristRouteRepository.SaveAsync();
        }

        public async Task<int?> ProcessDeleteTouristRouteAsync(Guid touristRouteId)
        {
            var touristRouteEntity = await _touristRouteRepository.FindTouristRouteByIdAsync(touristRouteId);

            if (touristRouteEntity is null)
            {
                return null;
            }

            // 标记为软删除
            _touristRouteRepository.MarkTouristRouteAsDeleted(touristRouteEntity);

            return await _touristRouteRepository.SaveAsync();
        }

        public async Task<int?> ProcessDeleteTouristRouteByIDsAsync(IEnumerable<Guid> touristIDList)
        {
            var touristRouteList = await _touristRouteRepository.FindTouristRouteListByIDsAsync(touristIDList);

            if (touristRouteList is null)
            {
                return null;
            }

            // 标记为软删除
            _touristRouteRepository.MarkTouristRouteListAsDeleted(touristRouteList);

            return await _touristRouteRepository.SaveAsync();
        }
    }
}
