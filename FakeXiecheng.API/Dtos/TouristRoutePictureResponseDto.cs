namespace FakeXiecheng.API.Dtos
{

    /// <summary>
    /// 用于API响应的旅游路线图片的数据传输对象
    /// </summary>
    public class TouristRoutePictureResponseDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        = null!;
        public Guid TouristRouteId { get; set; }
    }
}
