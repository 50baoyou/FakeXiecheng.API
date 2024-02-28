using System.ComponentModel.DataAnnotations;

namespace FakeXiecheng.API.Dtos
{
    /// <summary>
    /// 用于用户登录的数据传输对象
    /// </summary>
    public class LoginDto
    {
        [Required(ErrorMessage = "邮箱不可为空。")]
        [EmailAddress(ErrorMessage = "请输入有效的电子邮件地址。")]
        public string Email { get; set; }
        = null!;

        [Required(ErrorMessage = "密码不可为空。")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "密码长度必须在6到20个字符之间。")]
        public string Password { get; set; }
        = null!;
    }
}
