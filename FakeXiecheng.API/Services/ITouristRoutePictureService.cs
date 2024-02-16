using FakeXiecheng.API.Dtos;
using FakeXiecheng.API.Interceptors;

namespace FakeXiecheng.API.Services
{
    public interface ITouristRoutePictureService
    {
        Task<bool> IsExistTouristRoute(Guid touristRouteId);

        Task<TouristRoutePictureResponseDto?> ProcessGetTouristRoutePictureAsync(Guid touristRouteId, int pictureId);

        Task<IEnumerable<TouristRoutePictureResponseDto>> ProcessGetPicturesByTouristRouteIdAsync(Guid touristRouteId);

        [TransactionalInterceptor]
        Task<TouristRoutePictureResponseDto?> ProcessAddTouristRoutePictureAsync(Guid touristRouteId, TouristRoutePictureCreateDto touristRoutePictureCreateDto);

        [TransactionalInterceptor]
        Task<int?> ProcessDeleteTouristRoutePicturesAsync(Guid touristRouteId, int pictureId);
    }
}
