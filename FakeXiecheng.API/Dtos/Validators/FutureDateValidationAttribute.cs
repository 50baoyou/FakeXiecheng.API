using System.ComponentModel.DataAnnotations;

namespace FakeXiecheng.API.Dtos.Validators
{
    public class FutureDateValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var departureTime = value as DateTimeOffset?;

            if (departureTime is null)
            {
                return ValidationResult.Success;
            }

            // 确认日期是在今天之后
            if (departureTime <= DateTimeOffset.Now)
            {
                return new ValidationResult(ErrorMessage ?? "出发日期必须在当前日期之后。");
            }

            return ValidationResult.Success;
        }
    }
}
