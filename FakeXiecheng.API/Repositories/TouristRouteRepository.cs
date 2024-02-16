using FakeXiecheng.API.Database;
using FakeXiecheng.API.Models;
using FakeXiecheng.API.Repositories.Results;
using FakeXiecheng.API.Services.QueryParameters;
using FakeXiecheng.API.Services.QueryParameters.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Expressions;

namespace FakeXiecheng.API.Repositories
{
    public class TouristRouteRepository : Repository<TouristRoute>, ITouristRouteRepository
    {
        public TouristRouteRepository(FakeXieChengContext context) : base(context)
        {
        }

        public async Task<TouristRoute?> FindTouristRouteByIdAsync(Guid touristRouteId)
        {
            return await _dbSet.Where(t => t.Id == touristRouteId).Include(t => t.TouristRoutePictures).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TouristRoute>> FindTouristRouteListByIDsAsync(IEnumerable<Guid> touristIDList)
        {
            return await _dbSet.Where(t => touristIDList.Contains(t.Id)).Include(t => t.TouristRoutePictures).ToListAsync();
        }

        public async Task<IEnumerable<TouristRoute>> FindTouristRouteListAsync(TouristRoutesQueryParameters queryParameters)
        {
            IQueryable<TouristRoute> result = _dbSet
                .Include(t => t.TouristRoutePictures);

            if (!string.IsNullOrWhiteSpace(queryParameters.Keyword))
            {
                result = result.Where(t => t.Title.Contains(queryParameters.Keyword));
            }

            if (queryParameters.RatingOperator.HasValue)
            {
                switch (queryParameters.RatingOperator)
                {
                    case RatingOperatorType.LargerThan:
                        result = result.Where(t => t.Rating >= queryParameters.RatingValue);
                        break;
                    case RatingOperatorType.LessThan:
                        result = result.Where(t => t.Rating <= queryParameters.RatingValue);
                        break;
                    case RatingOperatorType.EqualTo:
                        result = result.Where(t => t.Rating == queryParameters.RatingValue);
                        break;
                }
            }

            return await result.AsNoTracking().ToListAsync();
        }

        public void MarkTouristRouteAsDeleted(TouristRoute touristRoute, DateTimeOffset? deletedTime = null)
        {
            var currentTime = deletedTime ?? DateTimeOffset.Now;

            // 软删除旅游路线
            touristRoute.IsDeleted = true;
            touristRoute.LastUpdatedTime = currentTime;

            // 软删除图片
            var pictures = touristRoute.TouristRoutePictures;

            if (!pictures.IsNullOrEmpty())
            {
                foreach (var picture in pictures)
                {
                    picture.IsDeleted = true;
                    picture.LastUpdatedTime = currentTime;
                }
            }
        }

        public void MarkTouristRouteListAsDeleted(IEnumerable<TouristRoute> touristRouteList)
        {
            var currentTime = DateTimeOffset.Now;

            foreach (var touristRoute in touristRouteList)
            {
                MarkTouristRouteAsDeleted(touristRoute, currentTime);
            }
        }

        public Task<PagedResult<TouristRoute>> FindPagedAsync(int pageIndex, int pageSize, Expression<Func<TouristRoute, bool>>? filter, Func<IQueryable<TouristRoute>, IOrderedQueryable<TouristRoute>>? orderBy)
        {
            throw new NotImplementedException();
        }
    }
}
