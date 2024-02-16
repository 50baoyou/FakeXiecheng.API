using FakeXiecheng.API.Dtos;

namespace FakeXiecheng.API.DTOs
{
    /// <summary>
    /// 用于API响应的旅游路线的数据传输对象
    /// </summary>
    public class TouristRouteResponseDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        = null!;
        public string Description { get; set; }
        = null!;
        public string Feature { get; set; }
        = null!;
        public string Note { get; set; }
        = null!;
        public string FeeDetail { get; set; }
        = null!;
        public decimal Price { get; set; }
        public decimal? Rating { get; set; }
        public DateTimeOffset? DepartureTime { get; set; }
        public string? TravelDays { get; set; }
        public string? TripType { get; set; }
        public string? DepartureCity { get; set; }
        public ICollection<TouristRoutePictureResponseDto> TouristRoutePictures { get; set; }
        = new List<TouristRoutePictureResponseDto>();
    }
}
