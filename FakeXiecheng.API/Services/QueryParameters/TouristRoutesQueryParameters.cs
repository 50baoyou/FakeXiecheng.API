using FakeXiecheng.API.Services.QueryParameters.Enums;

namespace FakeXiecheng.API.Services.QueryParameters
{
    public class TouristRoutesQueryParameters
    {
        public string? Keyword { get; set; }
        public RatingOperatorType? RatingOperator { get; set; }
        public int? RatingValue { get; set; }
    }
}
