using System.ComponentModel.DataAnnotations;

namespace FakeXiecheng.API.Dtos
{
    /// <summary>
    /// 用于旅游路线图片的数据传输对象基类
    /// </summary>
    public class TouristRoutePictureManipulationDto
    {
        // 如果DTO之间共享的不仅仅是属性，还包括一些共同的行为（方法），那么创建一个基类可能是更好的选择。
        [Required(ErrorMessage = "Url 字段不可为空。")]
        [Url(ErrorMessage = "请输入有效的 URL 地址。")]
        public string Url { get; set; }
        = null!;
    }
}
