using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FakeXiecheng.API.Models
{
    /// <summary>
    /// 旅游路线图片的实体模型
    /// </summary>
    public class TouristRoutePicture : BaseModel
    {
        /// <summary>
        /// 旅游路线图片的标识符，主键
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// 旅游路线图片URL路径，必填项，最大字符长度 100
        /// </summary>
        [Required]
        [Url]
        [MaxLength(100)]
        public string Url { get; set; }
        = null!;

        /// <summary>
        /// 旅游路线的图片关联的旅游路线实体唯一标识符
        /// </summary>
        [Required]
        public Guid TouristRouteId { get; set; }

        /// <summary>
        /// 旅游路线的图片关联的旅游路线实体
        /// </summary>
        public TouristRoute? TouristRoute { get; set; }
    }
}
