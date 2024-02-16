
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace FakeXiecheng.API.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        // 数据库上下文
        protected readonly DbContext _context;
        // 数据集
        protected readonly DbSet<T> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>(); // 将数据库表关联
        }

        /// <summary>
        /// 获取给定实体的EntityEntry对象。
        /// </summary>
        /// <param name="entity">要获取EntityEntry的实体。</param>
        /// <returns>与指定实体关联的EntityEntry对象。如果实体为null，则可能返回null。</returns>
        public EntityEntry<T>? GetEntry(T entity)
        {
            return _context.Entry(entity);
        }

        /// <summary>
        /// 异步保存当前上下文中的所有更改。
        /// </summary>
        /// <returns>返回一个表示异步保存操作的任务。任务结果包含被写入数据库的状态实体数量。</returns>
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// 获取所有实体的集合，不跟踪更改（适合只读操作）。
        /// </summary>
        /// <returns>任务对象，表示异步操作，其结果是实体的集合。</returns>
        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        /// <summary>
        /// 根据ID异步查找实体。
        /// </summary>
        /// <param name="id">实体ID。</param>
        /// <returns>任务对象，表示异步操作。如果找到实体则返回该实体，否则返回null。</returns>
        public async Task<T?> FindByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        /// <summary>
        /// 异步添加一个新实体。
        /// </summary>
        /// <param name="entity">要添加的实体。</param>
        /// <returns>任务对象，表示异步操作。</returns>
        public async Task<int> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);

            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// 异步添加实体集合。
        /// </summary>
        /// <param name="entities">要添加的实体集合。</param>
        /// <returns>任务对象，表示异步操作。</returns>
        public async Task<int> AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);

            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// 异步更新一个已存在的实体。
        /// </summary>
        /// <param name="entity">要更新的实体。</param>
        /// <returns>任务对象，表示异步操作。</returns>
        public async Task<int> UpdateAsync(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// 异步批量更新实体。
        /// </summary>
        /// <param name="entities">要更新的实体集合。</param>
        /// <returns>任务对象，表示异步操作。</returns>
        public async Task<int> UpdateRangeAsync(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Set<T>().Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
            }

            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// 根据ID异步软删除一个实体，更新其IsDeleted属性。
        /// </summary>
        /// <param name="id">要删除的实体Id。</param>
        /// <returns>任务对象，表示异步操作。</returns>
        public async Task<int> SoftDeleteByIdAsync(object id)
        {
            var entity = await _dbSet.FindAsync(id);

            if (entity != null)
            {
                return await SoftDeleteAsync(entity);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 异步软删除一个实体，更新其IsDeleted属性。
        /// </summary>
        /// <param name="entity">要删除的实体。</param>
        /// <returns>任务对象，表示异步操作。</returns>
        public async Task<int> SoftDeleteAsync(T entity)
        {
            // 获取给定实体的Entry对象
            var entry = _context.Entry(entity);

            // 标记为已删除
            entry.Property("IsDeleted").CurrentValue = true;
            // 设置最后修改时间为当前时间
            entry.Property("LastUpdatedTime").CurrentValue = DateTimeOffset.Now;
            // 更新实体状态为已修改
            entry.State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// 异步软删除一个实体集合，更新每个实体的IsDeleted属性。
        /// </summary>
        /// <param name="entities">要删除的实体集合。</param>
        /// <returns>任务对象，表示异步操作。</returns>
        public async Task<int> SoftDeleteRangeAsync(IEnumerable<T> entities)
        {
            // 获取当前时间，保持一致性
            var currentTime = DateTimeOffset.Now;

            foreach (var entity in entities)
            {
                // 获取给定实体的Entry对象
                var entry = _context.Entry(entity);

                // 标记为已删除
                entry.Property("IsDeleted").CurrentValue = true;
                // 设置最后修改时间为当前时间
                entry.Property("LastUpdatedTime").CurrentValue = currentTime;
                // 更新实体状态为已修改
                entry.State = EntityState.Modified;
            }

            return await _context.SaveChangesAsync(); // 保存修改
        }

        /// <summary>
        /// 根据指定条件查询实体是否存在。
        /// </summary>
        /// <param name="filter">筛选实体的条件表达式。</param>
        /// <returns>任务对象，表示异步操作，其结果是实体是否存在。</returns>
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.AnyAsync(filter);
        }

        /// <summary>
        /// 根据指定条件异步计算实体数量。
        /// </summary>
        /// <param name="filter">筛选实体的条件表达式。</param>
        /// <returns>任务对象，表示异步操作，其结果是满足条件的实体数量。</returns>
        public async Task<int> CountAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.CountAsync(filter);
        }

        /// <summary>
        /// 根据指定条件异步查找实体。
        /// </summary>
        /// <param name="filter">筛选实体的条件表达式。</param>
        /// <returns>任务对象，表示异步操作，其结果是满足条件的实体。</returns>
        public async Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.FirstOrDefaultAsync(filter);
        }

        /// <summary>
        /// 根据指定条件异步查找实体。
        /// </summary>
        /// <param name="filter">筛选实体的条件表达式。</param>
        /// <returns>任务对象，表示异步操作，其结果是满足条件的实体。</returns>
        public async Task<T?> GetSingleOrDefaultAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.SingleOrDefaultAsync(filter);
        }

        /// <summary>
        /// 根据指定条件异步查找实体集合。
        /// </summary>
        /// <param name="filter">筛选实体的条件表达式。</param>
        /// <returns>任务对象，表示异步操作，其结果是满足条件的实体集合。</returns>
        public async Task<IEnumerable<T>> FindListAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.Where(filter).AsNoTracking().ToListAsync();
        }
    }
}
