namespace FakeXiecheng.API.Dtos
{
    /// <summary>
    /// 用于更新旅游路线的数据传输对象
    /// </summary>
    public class TouristRouteUpdateDto : TouristRouteManipulationDto
    {
        public ICollection<TouristRoutePictureUpdateDto> TouristRoutePictures { get; set; }
        = new List<TouristRoutePictureUpdateDto>();
    }
}
