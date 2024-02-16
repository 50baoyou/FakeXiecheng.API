using AutoMapper;
using FakeXiecheng.API.Dtos;
using FakeXiecheng.API.Models;
using FakeXiecheng.API.Repositories;
using Microsoft.IdentityModel.Tokens;

namespace FakeXiecheng.API.Services
{
    public class TouristRoutePictureService : ITouristRoutePictureService
    {
        private readonly ITouristRouteRepository _touristRouteRepository;
        private readonly ITouristRoutePictureRepository _touristRoutePictureRepository;
        private readonly IMapper _mapper;

        public TouristRoutePictureService(ITouristRouteRepository touristRouteRepository, ITouristRoutePictureRepository touristRoutePictureRepository, IMapper mapper)
        {
            _touristRouteRepository = touristRouteRepository;
            _touristRoutePictureRepository = touristRoutePictureRepository;
            _mapper = mapper;
        }

        public async Task<bool> IsExistTouristRoute(Guid touristRouteId)
        {
            return await _touristRouteRepository.AnyAsync(t => t.Id == touristRouteId);
        }

        public async Task<TouristRoutePictureResponseDto?> ProcessGetTouristRoutePictureAsync(Guid touristRouteId, int pictureId)
        {
            var touristRoutePictureEntity = await _touristRoutePictureRepository.GetSingleOrDefaultAsync(p => p.TouristRouteId == touristRouteId && p.Id == pictureId);
            var touristRoutePictureResponseDto = _mapper.Map<TouristRoutePictureResponseDto>(touristRoutePictureEntity);

            return touristRoutePictureResponseDto;

        }

        public async Task<IEnumerable<TouristRoutePictureResponseDto>> ProcessGetPicturesByTouristRouteIdAsync(Guid touristRouteId)
        {
            var touristRoutePictureList = await _touristRoutePictureRepository.FindListAsync(p => p.TouristRouteId == touristRouteId);
            var touristRoutePictureResponseDtoList = _mapper.Map<IEnumerable<TouristRoutePictureResponseDto>>(touristRoutePictureList);

            return touristRoutePictureResponseDtoList;
        }

        public async Task<TouristRoutePictureResponseDto?> ProcessAddTouristRoutePictureAsync(Guid touristRouteId, TouristRoutePictureCreateDto touristRoutePictureCreateDto)
        {
            var isExistTouristRoute = await IsExistTouristRoute(touristRouteId);

            if (!isExistTouristRoute)
            {
                return null;
            }

            var touristRoutePictureModel = _mapper.Map<TouristRoutePicture>(touristRoutePictureCreateDto);
            touristRoutePictureModel.TouristRouteId = touristRouteId;
            /**
             * 当你通过调用AddAsync方法添加touristRoutePictureModel到数据库，并成功调用SaveChangesAsync后，数据库为Id字段生成了一个值。
             * 随后，EF Core自动将这个新生成的值更新到了touristRoutePictureModel.Id中。
             */
            var result = await _touristRoutePictureRepository.AddAsync(touristRoutePictureModel);

            if (result is not 0)
            {
                var touristRoutePictureResponseDto = _mapper.Map<TouristRoutePictureResponseDto>(touristRoutePictureModel);

                return touristRoutePictureResponseDto;
            }
            else
            {
                return null;
            }
        }

        public async Task<int?> ProcessDeleteTouristRoutePicturesAsync(Guid touristRouteId, int pictureId)
        {
            var touristRouteEntity = await _touristRouteRepository.FindTouristRouteByIdAsync(touristRouteId);

            if (touristRouteEntity is null)
            {
                return null;
            }

            var pictures = touristRouteEntity.TouristRoutePictures;

            if (!pictures.IsNullOrEmpty())
            {
                foreach (var picture in pictures)
                {
                    // 软删除图片
                    if (picture.Id == pictureId)
                    {
                        _touristRoutePictureRepository.MarkPictureAsDeleted(picture);
                    }
                }

                return await _touristRoutePictureRepository.SaveAsync();
            }
            else
            {
                return -1;
            }
        }
    }
}
