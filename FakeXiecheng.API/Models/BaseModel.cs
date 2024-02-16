namespace FakeXiecheng.API.Models
{
    public abstract class BaseModel
    {
        public DateTimeOffset CreateTime { get; set; } // 创建时间
        = DateTimeOffset.Now;

        public DateTimeOffset LastUpdatedTime { get; set; } // 最后更新时间
        = DateTimeOffset.Now;

        public bool IsDeleted { get; set; } // 软删除标志，默认值 false
        = false;
    }
}
