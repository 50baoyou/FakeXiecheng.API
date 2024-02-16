using FakeXiecheng.API.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FakeXiecheng.API.Models
{
    /// <summary>
    /// 旅游路线的实体模型
    /// </summary>
    public class TouristRoute : BaseModel
    {
        /// <summary>
        /// 旅游路线的唯一标识符，主键
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// 旅游路线的名称，必填项，最大字符长度 100
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        = null!;

        /// <summary>
        /// 旅游路线的说明，必填项，最大字符长度 1000
        /// </summary>
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }
        = null!;

        /// <summary>
        /// 旅游路线的特点，必填项，最大字符长度 MAX
        /// </summary>
        [Required]
        [MaxLength]
        public string Feature { get; set; }
        = null!;

        /// <summary>
        /// 旅游路线的备注，必填项，最大字符长度 MAX
        /// </summary>
        [Required]
        [MaxLength]
        public string Note { get; set; }
        = null!;

        /// <summary>
        /// 旅游路线的费用详情，必填项，最大字符长度 MAX
        /// </summary>
        [Required]
        [MaxLength]
        public string FeeDetail { get; set; }
        = null!;

        /// <summary>
        /// 旅游路线的原始价格，必填项，高精度十进制数，最多保留两位小数，范围 0.00-99999999.99
        /// </summary>
        [Required]
        [Precision(10, 2)]
        [Range(0.00, 99999999.99)]
        public decimal OriginalPrice { get; set; }

        /// <summary>
        /// 旅游路线的折扣，此属性可空，最多保留一位小数，范围 0.0-1.0
        /// </summary>
        [Precision(2, 1)]
        [Range(0.0, 1.0)]
        public decimal? DiscountPresent { get; set; }

        /// <summary>
        /// 旅游路线的评分，此属性可空，最多保留一位小数，范围 0.0-5.0
        /// </summary>
        [Precision(2, 1)]
        [Range(0.0, 5.0)]
        public decimal? Rating { get; set; }

        /// <summary>
        /// 旅游路线的预定出发时间，此属性可空
        /// </summary>
        public DateTimeOffset? DepartureTime { get; set; }

        /// <summary>
        /// 旅游路线的旅行天数，枚举类型，此属性可空
        /// </summary>
        [Column(TypeName = "tinyint")]
        public TravelDays? TravelDays { get; set; }

        /// <summary>
        /// 旅游路线的旅游类型，枚举类型，此属性为可空
        /// </summary>
        [Column(TypeName = "tinyint")]
        public TripType? TripType { get; set; }

        /// <summary>
        /// 旅游路线的出发城市。枚举类型，此属性为可空
        /// </summary>
        [Column(TypeName = "smallint")]
        public DepartureCity? DepartureCity { get; set; }

        /// <summary>
        /// 与该旅游路线相关联的旅游路线图片的集合
        /// </summary>
        public ICollection<TouristRoutePicture> TouristRoutePictures { get; set; }
        = new List<TouristRoutePicture>();
    }
}
