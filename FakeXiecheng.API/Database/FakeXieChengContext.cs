using FakeXiecheng.API.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Linq.Expressions;

namespace FakeXiecheng.API.Database
{
    public class FakeXieChengContext : DbContext
    {
        private readonly IWebHostEnvironment _hostEnv;
        public DbSet<TouristRoute> TouristRoutes { get; set; }
        public DbSet<TouristRoutePicture> TouristRoutePictures { get; set; }

        public FakeXieChengContext(DbContextOptions<FakeXieChengContext> options, IWebHostEnvironment hostEnvironment) : base(options)
        {
            _hostEnv = hostEnvironment;
        }

        // 在创建最终模型之前，配置实体模型和关系
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 读取模拟数据
            var touristRoutesMockData = File.ReadAllText(_hostEnv.ContentRootPath + @"/Database/touristRoutesMockData.json");
            IList<TouristRoute>? touristRoutes = JsonConvert.DeserializeObject<IList<TouristRoute>>(touristRoutesMockData);
            if (touristRoutes != null)
            {
                modelBuilder.Entity<TouristRoute>().HasData(touristRoutes);
            }

            var touristRoutePicturesMockData = File.ReadAllText(_hostEnv.ContentRootPath + @"/Database/touristRoutePicturesMockData.json");
            IList<TouristRoutePicture>? touristRoutePictures = JsonConvert.DeserializeObject<IList<TouristRoutePicture>>(touristRoutePicturesMockData);
            if (touristRoutePictures != null)
            {
                modelBuilder.Entity<TouristRoutePicture>().HasData(touristRoutePictures);
            }

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                //// 为每个实体添加影子属性
                //entityType.AddProperty("CreateTime", typeof(DateTimeOffset));
                //entityType.AddProperty("LastUpdatedTime", typeof(DateTimeOffset));
                //entityType.AddProperty("IsDeleted", typeof(bool));

                // 设置默认值 设置修改数据数据库自动更新LastUpdatedTime字段
                //modelBuilder.Entity(entityType.ClrType).Property<DateTimeOffset>("CreateTime").HasDefaultValueSql("SYSDATETIMEOFFSET()");
                //modelBuilder.Entity(entityType.ClrType).Property<DateTimeOffset>("LastUpdatedTime").HasDefaultValueSql("SYSDATETIMEOFFSET()");
                //modelBuilder.Entity(entityType.ClrType).Property<bool>("IsDeleted").HasDefaultValue(false);

                // 配置全局查询过滤器来自动排除 IsDeleted = true 的数据
                var parameter = Expression.Parameter(entityType.ClrType, "e");
                var isDeletedProperty = Expression.Call(typeof(EF), nameof(EF.Property), new[] { typeof(bool) }, parameter, Expression.Constant("IsDeleted"));
                var notDeletedExpression = Expression.MakeBinary(ExpressionType.Equal, isDeletedProperty, Expression.Constant(false));
                var lambda = Expression.Lambda(notDeletedExpression, parameter);

                modelBuilder.Entity(entityType.ClrType).HasQueryFilter(lambda);
            }
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // 可在这里进行统一的异常处理
            OnBeforeSaving();
            return base.SaveChangesAsync(cancellationToken);
        }

        // 在保存时自动更新最后修改时间
        private void OnBeforeSaving()
        {
            var modifiedEntities = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified)
                .Select(e => e.Entity);

            // 获取当前时间
            DateTimeOffset currentTime = DateTimeOffset.Now;
            foreach (var entry in modifiedEntities)
            {
                var propertyInfo = entry.GetType().GetProperty("LastUpdatedTime");
                if (propertyInfo != null && propertyInfo.PropertyType == typeof(DateTimeOffset))
                {
                    propertyInfo.SetValue(entry, currentTime);
                }
            }
        }
    }
}
