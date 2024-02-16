using FakeXiecheng.API.Models;
using FakeXiecheng.API.Repositories.Results;
using FakeXiecheng.API.Services.QueryParameters;
using System.Linq.Expressions;

namespace FakeXiecheng.API.Repositories
{
    public interface ITouristRouteRepository : IRepository<TouristRoute>
    {
        Task<TouristRoute?> FindTouristRouteByIdAsync(Guid touristRouteId);
        Task<IEnumerable<TouristRoute>> FindTouristRouteListByIDsAsync(IEnumerable<Guid> touristIDList);
        Task<IEnumerable<TouristRoute>> FindTouristRouteListAsync(TouristRoutesQueryParameters queryParameters);
        void MarkTouristRouteAsDeleted(TouristRoute touristRoute, DateTimeOffset? deletedTime = null);
        void MarkTouristRouteListAsDeleted(IEnumerable<TouristRoute> touristRouteList);
        Task<PagedResult<TouristRoute>> FindPagedAsync(int pageIndex, int pageSize, Expression<Func<TouristRoute, bool>>? filter, Func<IQueryable<TouristRoute>, IOrderedQueryable<TouristRoute>>? orderBy);
    }
}
