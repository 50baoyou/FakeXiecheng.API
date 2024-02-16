namespace FakeXiecheng.API.Dtos
{
    /// <summary>
    /// 用于创建旅游路线的数据传输对象
    /// </summary>
    public class TouristRouteCreateDto : TouristRouteManipulationDto
    {
        public ICollection<TouristRoutePictureCreateDto> TouristRoutePictures { get; set; }
        = new List<TouristRoutePictureCreateDto>();
    }
}
