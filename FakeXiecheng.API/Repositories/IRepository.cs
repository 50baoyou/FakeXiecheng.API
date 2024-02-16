using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace FakeXiecheng.API.Repositories
{
    /// <summary>
    /// 通用数据仓库接口。
    /// </summary>
    /// <typeparam name="T">实体模型类型，必须是一个类。</typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// 获取给定实体的EntityEntry对象。
        /// </summary>
        /// <param name="entity">要获取EntityEntry的实体。</param>
        /// <returns>与指定实体关联的EntityEntry对象。如果实体为null，则可能返回null。</returns>
        EntityEntry<T>? GetEntry(T entity);

        /// <summary>
        /// 异步保存当前上下文中的所有更改。
        /// </summary>
        /// <returns>返回一个表示异步保存操作的任务。任务结果包含被写入数据库的状态实体数量。</returns>
        Task<int> SaveAsync();

        /// <summary>
        /// 获取所有实体。
        /// </summary>
        /// <returns>所有实体的集合。</returns>
        Task<IEnumerable<T>> FindAllAsync();

        /// <summary>
        /// 根据ID查询实体。
        /// </summary>
        /// <param name="id">实体的ID。</param>
        /// <returns>找到的实体，若未找到返回null。</returns>
        Task<T?> FindByIdAsync(object id);

        /// <summary>
        /// 添加新实体。
        /// </summary>
        /// <param name="entity">要添加的实体。</param>
        Task<int> AddAsync(T entity);

        /// <summary>
        /// 添加实体集合。
        /// </summary>
        /// <param name="entities">要添加的实体集合。</param>
        Task<int> AddRangeAsync(IEnumerable<T> entities);

        /// <summary>
        /// 更新已存在的实体。
        /// </summary>
        /// <param name="entity">要更新的实体。</param>
        Task<int> UpdateAsync(T entity);

        /// <summary>
        /// 批量更新实体。
        /// </summary>
        /// <param name="entities">要更新的实体集合。</param>
        Task<int> UpdateRangeAsync(IEnumerable<T> entities);

        /// <summary>
        /// 根据Id删除实体。
        /// </summary>
        /// <param name="id">要删除实体的ID。</param>
        Task<int> SoftDeleteByIdAsync(object id);

        /// <summary>
        /// 删除指定实体。
        /// </summary>
        /// <param name="entity">要删除的实体。</param>
        Task<int> SoftDeleteAsync(T entity);

        /// <summary>
        /// 删除指定实体集合。
        /// </summary>
        /// <param name="entities">要删除的实体集合。</param>
        Task<int> SoftDeleteRangeAsync(IEnumerable<T> entities);

        /// <summary>
        /// 基于指定条件查询实体是否存在。
        /// </summary>
        /// <param name="filter">查询条件表达式。</param>
        /// <returns>满足条件的实体存在返回true, 否则返回false。</returns>
        Task<bool> AnyAsync(Expression<Func<T, bool>> filter);

        /// <summary>
        /// 基于指定条件计算实体数量。
        /// </summary>
        /// <param name="filter">查询条件表达式。</param>
        /// <returns>满足条件的实体数量。</returns>
        Task<int> CountAsync(Expression<Func<T, bool>> filter);

        /// <summary>
        /// 基于指定条件获取单个实体。
        /// </summary>
        /// <param name="filter">查询条件表达式。</param>
        /// <returns>找到的满足条件的第一个实体，未找到返回null。</returns>
        Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter);

        /// <summary>
        /// 基于指定条件获取单个实体。
        /// </summary>
        /// <param name="filter">查询条件表达式。</param>
        /// <returns>找到的单个实体，未找到返回null，找到多个则会抛出异常。</returns>
        Task<T?> GetSingleOrDefaultAsync(Expression<Func<T, bool>> filter);

        /// <summary>
        /// 基于指定条件获取实体集合。
        /// </summary>
        /// <param name="filter">查询条件表达式。</param>
        /// <returns>满足条件的实体集合。</returns>
        Task<IEnumerable<T>> FindListAsync(Expression<Func<T, bool>> filter);
    }
}
