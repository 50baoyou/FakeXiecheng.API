using FakeXiecheng.API.Dtos;
using FakeXiecheng.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace FakeXiecheng.API.Controllers
{
    [Route("api/touristRoutes/{touristRouteId}/pictures")]
    [ApiController]
    public class TouristRoutePicturesController : ControllerBase
    {
        private readonly ITouristRoutePictureService _touristRoutePictureService;

        public TouristRoutePicturesController(ITouristRoutePictureService touristRoutePictureService)
        {
            _touristRoutePictureService = touristRoutePictureService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPicturesByTouristRouteId(Guid touristRouteId)
        {
            var picturListFromServie = await _touristRoutePictureService.ProcessGetPicturesByTouristRouteIdAsync(touristRouteId);

            if (picturListFromServie is null)
            {
                return BadRequest("获取旅游路线的图片数据失败。");
            }
            else
            {
                return Ok(picturListFromServie);
            }
        }

        [HttpGet("{pictureId}", Name = "GetTouristRoutePicture")]
        public async Task<IActionResult> GetTouristRoutePicture(Guid touristRouteId, int pictureId)
        {
            var picturFromServie = await _touristRoutePictureService.ProcessGetTouristRoutePictureAsync(touristRouteId, pictureId);

            if (picturFromServie is null)
            {
                return BadRequest("获取旅游路线的图片数据失败。");
            }
            else
            {
                return Ok(picturFromServie);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateTouristRoutePicture(
            [FromRoute] Guid touristRouteId,
            [FromBody] TouristRoutePictureCreateDto touristRoutePictureCreateDto
            )
        {
            var picturFromServie = await _touristRoutePictureService.ProcessAddTouristRoutePictureAsync(touristRouteId, touristRoutePictureCreateDto);

            if (picturFromServie is null)
            {
                return BadRequest("创建旅游路线的图片失败。");
            }
            else
            {
                return CreatedAtRoute(
                    "GetTouristRoutePicture",
                    new { touristRouteId = picturFromServie.TouristRouteId, pictureId = picturFromServie.Id },
                    picturFromServie
                    );
            }
        }

        [HttpDelete("{pictureId}")]
        public async Task<IActionResult> DeleteTouristRoutePictures(
            [FromRoute] Guid touristRouteId,
            [FromRoute] int pictureId
            )
        {
            var resultFromServie = await _touristRoutePictureService.ProcessDeleteTouristRoutePicturesAsync(touristRouteId, pictureId);

            if (resultFromServie is null)
            {
                return BadRequest("旅游路线不存在或删除旅游路线图片失败。");
            }
            else if (resultFromServie is -1)
            {
                return BadRequest("旅游路线不存在图片。");
            }
            else
            {
                return NoContent();
            }
        }
    }
}
