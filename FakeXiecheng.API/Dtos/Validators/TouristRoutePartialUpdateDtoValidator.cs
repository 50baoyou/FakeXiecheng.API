using FakeXiecheng.API.Models.Enums;
using FluentValidation;

namespace FakeXiecheng.API.Dtos.Validators
{
    public class TouristRoutePartialUpdateDtoValidator : AbstractValidator<TouristRoutePartialUpdateDto>
    {
        public TouristRoutePartialUpdateDtoValidator()
        {
            RuleFor(dto => dto.Title)
                .NotEmpty().WithMessage("Title 字段不可为空。")
                .Length(1, 100).WithMessage("Title 字段的最大长度不能超过 100 个字符。")
                .Must(title => title != null && !title.Equals(string.Empty, StringComparison.OrdinalIgnoreCase))
                .WithMessage("Title 字段不能是空字符串。");

            RuleFor(dto => dto.Description)
                .NotEmpty().WithMessage("Description 字段不可为空。")
                .Length(1, 5000).WithMessage("Description 字段的最大长度不能超过 1000 个字符。")
                .Must(description => description != null && !description.Equals(string.Empty, StringComparison.OrdinalIgnoreCase))
                .WithMessage("Description 字段不能是空字符串。");

            RuleFor(dto => dto.Feature)
                .NotEmpty().WithMessage("Feature 字段不可为空。")
                .Length(1, 5000).WithMessage("Feature 字段的最大长度不能超过 5000 个字符。")
                .Must(feature => feature != null && !feature.Equals(string.Empty, StringComparison.OrdinalIgnoreCase))
                .WithMessage("Feature 字段不能是空字符串。");

            RuleFor(dto => dto.Note)
                .NotEmpty().WithMessage("Note 字段不可为空。")
                .Length(1, 5000).WithMessage("Note 字段的最大长度不能超过 5000 个字符。")
                .Must(note => note != null && !note.Equals(string.Empty, StringComparison.OrdinalIgnoreCase))
                .WithMessage("Note 字段不能是空字符串。");

            RuleFor(dto => dto.FeeDetail)
                .NotEmpty().WithMessage("FeeDetail 字段不可为空。")
                .Length(1, 5000).WithMessage("FeeDetail 字段的最大长度不能超过 5000 个字符。")
                .Must(feeDetail => feeDetail != null && !feeDetail.Equals(string.Empty, StringComparison.OrdinalIgnoreCase))
                .WithMessage("FeeDetail 字段不能是空字符串。");

            RuleFor(dto => dto.OriginalPrice)
                .InclusiveBetween(0.00m, 99999999.99m).WithMessage("OriginalPrice 字段必须在 0.00 到 99999999.99 之间。");

            RuleFor(dto => dto.DiscountPresent)
                .InclusiveBetween(0.0m, 1.0m).When(dto => dto.DiscountPresent.HasValue)
                .WithMessage("DiscountPresent 字段必须在 0.0 到 1.0 之间。");

            RuleFor(dto => dto.Rating)
                .InclusiveBetween(0.0m, 5.0m).When(dto => dto.Rating.HasValue)
                .WithMessage("Rating 字段必须在 0.0 到 5.0 之间。");

            RuleFor(dto => dto.DepartureTime)
                .Must(date => date == null || date > DateTimeOffset.Now)
                .WithMessage("DepartureTime 字段输入的值无效，出发日期必须在当前时间之后。");

            // 验证标题和描述不同
            RuleFor(dto => dto)
                .Must(dto => dto.Title != dto.Description)
                .WithMessage("旅游路线的名称必须与路线描述不同。");

            // 添加更多基于业务规则的验证，例如，针对EnumType的验证等
            RuleFor(dto => dto.TravelDays)
                .IsEnumName(typeof(TravelDays), caseSensitive: false)
                .WithMessage("TravelDays 字段的值不是有效的枚举名称。");

            RuleFor(dto => dto.TripType)
                .IsEnumName(typeof(TripType), caseSensitive: false)
                .WithMessage("TripType 字段的值不是有效的枚举名称。");

            RuleFor(dto => dto.DepartureCity)
                .IsEnumName(typeof(DepartureCity), caseSensitive: false)
                .WithMessage("DepartureCity 字段的值不是有效的枚举名称。");
        }
    }
}

