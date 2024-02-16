using System.ComponentModel.DataAnnotations;

namespace FakeXiecheng.API.Dtos.Validators
{
    public class EnumTypeValidationAttribute : ValidationAttribute
    {
        private Type _enumType;

        public EnumTypeValidationAttribute(Type enumType)
        {
            _enumType = enumType;

            if (!_enumType.IsEnum)
            {
                throw new ArgumentException($"指定的类型不是枚举类型：{nameof(EnumTypeValidationAttribute)}");
            }
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var inputValue = value as string;

            if (inputValue is null)
            {
                return ValidationResult.Success;
            }

            inputValue?.Trim();

            if (Enum.TryParse(_enumType, inputValue, true, out _))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(ErrorMessage ?? "参数值不合法。");
            }
        }
    }
}
