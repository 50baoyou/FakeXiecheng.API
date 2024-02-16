using FakeXiecheng.API.Dtos.Validators;
using FakeXiecheng.API.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FakeXiecheng.API.Dtos
{
    /// <summary>
    /// 用于旅游路线的数据传输对象基类
    /// </summary>
    public class TouristRouteManipulationDto : IValidatableObject
    {
        [Required(ErrorMessage = "Title 字段不可为空。")]
        [MaxLength(100, ErrorMessage = "Title 字段的最大长度不能超过 100 个字符。")]
        public string Title { get; set; }
        = null!;

        [Required(ErrorMessage = "Description 字段不可为空。")]
        [MaxLength(1000, ErrorMessage = "Title 字段的最大长度不能超过 1000 个字符。")]
        public string Description { get; set; }
        = null!;

        [Required(ErrorMessage = "Feature 字段不可为空。")]
        [MaxLength(ErrorMessage = "Feature 字段超过数据库支持的最大长度。")]
        public string Feature { get; set; }
        = null!;

        [Required(ErrorMessage = "Note 字段不可为空。")]
        [MaxLength(ErrorMessage = "Note 字段超过数据库支持的最大长度。")]
        public string Note { get; set; }
        = null!;

        [Required(ErrorMessage = "FeeDetail 字段不可为空。")]
        [MaxLength(ErrorMessage = "FeeDetail 字段超过数据库支持的最大长度。")]
        public string FeeDetail { get; set; }
        = null!;

        [Required(ErrorMessage = "OriginalPrice 字段不可为空。")]
        [Precision(10, 2)]
        [Range(0.00, 99999999.99, ErrorMessage = "OriginalPrice 字段必须在 0.00 到 99999999.99 之间。")]
        public decimal OriginalPrice { get; set; }

        [Precision(2, 1)]
        [Range(0.0, 1.0, ErrorMessage = "DiscountPresent 字段必须在 0.0 到 1.0 之间。")]
        public decimal? DiscountPresent { get; set; }

        [Precision(2, 1)]
        [Range(0.0, 5.0, ErrorMessage = "Rating 字段必须在 0.0 到 5.0 之间。")]
        public decimal? Rating { get; set; }

        [FutureDateValidation(ErrorMessage = "DepartureTime 字段输入的值无效，出发日期必须在当前时间之后。")]
        public DateTimeOffset? DepartureTime { get; set; }

        [EnumTypeValidation(typeof(TravelDays), ErrorMessage = "TravelDays 字段输入的值无效。")]
        public string? TravelDays { get; set; }

        [EnumTypeValidation(typeof(TripType), ErrorMessage = "TripType 字段输入的值无效。")]
        public string? TripType { get; set; }

        [EnumTypeValidation(typeof(DepartureCity), ErrorMessage = "DepartureCity 字段输入的值无效。")]
        public string? DepartureCity { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Title == Description)
            {
                yield return new ValidationResult(
                    "旅游路线的名称必须与路线描述不同。",
                    new[] { "Title", "Description" }
                    );
            }
        }
    }
}
