using FakeXiecheng.API.Controllers.ResourceParameters;
using FakeXiecheng.API.Dtos;
using FakeXiecheng.API.Helpers;
using FakeXiecheng.API.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace FakeXiecheng.API.Controllers
{
    /// <summary>
    /// 旅游路线控制器，提供旅游路线数据的CRUD操作。
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TouristRoutesController : ControllerBase
    {
        private readonly ITouristRouteService _touristRouteService;

        public TouristRoutesController(ITouristRouteService touristRouteService)
        {
            _touristRouteService = touristRouteService;
        }

        /// <summary>
        /// 获取多个旅游路线数据。支持通过查询参数筛选。
        /// </summary>
        /// <param name="parameters">查询参数。非必需。</param>
        /// <returns>匹配条件的旅游路线数据集合。</returns>
        [HttpGet]
        [HttpHead]
        public async Task<IActionResult> GetTouristRoutes([FromQuery] TouristRoutesResourceParameters parameters)
        {
            var touristRouteListFromService = await _touristRouteService.ProcessGetTouristRouteListAsync(parameters);

            if (touristRouteListFromService is null)
            {
                return BadRequest("旅游路线不存在或获取旅游路线数据失败。");
            }
            else
            {
                return Ok(touristRouteListFromService);
            }
        }

        /// <summary>
        /// 根据指定ID获取单个旅游路线数据。
        /// </summary>
        /// <param name="touristRouteId">旅游路线的唯一标识ID。</param>
        /// <returns>指定ID的旅游路线数据。</returns>
        [HttpGet("{touristRouteId}", Name = "GetTouristRouteById")]
        [HttpHead("{touristRouteId}")]
        public async Task<IActionResult> GetTouristRouteById(Guid touristRouteId)
        {
            var touristRouteFromService = await _touristRouteService.ProcessGetTouristRouteByIdAsync(touristRouteId);

            if (touristRouteFromService is null)
            {
                return BadRequest("旅游路线不存在或获取旅游路线数据失败。");
            }
            else
            {
                return Ok(touristRouteFromService);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateTouristRoute([FromBody] TouristRouteCreateDto touristRouteCreateDto)
        {
            var touristRouteFromServie = await _touristRouteService.ProcessAddTouristRouteAsync(touristRouteCreateDto); // 需进行请求参数验证

            if (touristRouteFromServie is null)
            {
                return BadRequest("添加旅游路线失败。");
            }
            else
            {
                // CreatedAtRoute 方法是用来生成一个包含201 Created状态码的HTTP响应
                // 并添加一个Location头部指向新创建资源的URL
                return CreatedAtRoute(
                    "GetTouristRouteById",
                    new { touristRouteId = touristRouteFromServie.Id },
                    touristRouteFromServie
                    );
            }
        }

        [HttpPut("{touristRouteId}")]
        public async Task<IActionResult> UpdateTouristRoute(
            [FromRoute] Guid touristRouteId,
            [FromBody] TouristRouteUpdateDto touristRouteUpdateDto
            )
        {
            var resultFromServie = await _touristRouteService.ProcessUpdateTouristRouteAsync(touristRouteId, touristRouteUpdateDto);

            if (resultFromServie is null)
            {
                return BadRequest("旅游路线不存在或更新旅游路线失败。");
            }
            else
            {
                return NoContent();
            }
        }

        [HttpPatch("{touristRouteId}")]
        public async Task<IActionResult> PartialUpdateTouristRoute(
            [FromRoute] Guid touristRouteId,
            [FromBody] JsonPatchDocument<TouristRoutePartialUpdateDto> patchDocument
            )
        {
            var resultFromServie = await _touristRouteService.ProcessPartialUpdateTouristRouteAsync(touristRouteId, patchDocument);

            if (resultFromServie is null)
            {
                return BadRequest("旅游路线不存在或更新旅游路线失败。");
            }
            else if (resultFromServie is -1)
            {
                return BadRequest("请求参数验证失败，请检查输入合法性。");
            }
            else
            {
                return NoContent();
            }
        }

        [HttpDelete("{touristRouteId}")]
        public async Task<IActionResult> DeleteTouristRoute([FromRoute] Guid touristRouteId)
        {
            var resultFromServie = await _touristRouteService.ProcessDeleteTouristRouteAsync(touristRouteId);

            if (resultFromServie is null)
            {
                return BadRequest("旅游路线不存在或删除旅游路线失败。");
            }
            else
            {
                return NoContent();
            }
        }

        [HttpDelete("({touristIDs})")]
        public async Task<IActionResult> DeleteTouristRouteByIDs([FromRoute][ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<Guid> touristIDs)
        {
            if (touristIDs is null)
            {
                return BadRequest("请求参数不合法，请重新输入。");
            }

            var resultFromServie = await _touristRouteService.ProcessDeleteTouristRouteByIDsAsync(touristIDs);

            if (resultFromServie is null)
            {
                return BadRequest("旅游路线不存在或删除旅游路线失败。");
            }
            else
            {
                return NoContent();
            }
        }
    }
}
