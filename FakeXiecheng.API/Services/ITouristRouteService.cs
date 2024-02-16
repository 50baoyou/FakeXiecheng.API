using FakeXiecheng.API.Controllers.ResourceParameters;
using FakeXiecheng.API.Dtos;
using FakeXiecheng.API.DTOs;
using FakeXiecheng.API.Interceptors;
using Microsoft.AspNetCore.JsonPatch;

namespace FakeXiecheng.API.Services
{
    public interface ITouristRouteService
    {
        Task<TouristRouteResponseDto?> ProcessGetTouristRouteByIdAsync(Guid touristRouteId);

        Task<IEnumerable<TouristRouteResponseDto>> ProcessGetTouristRouteListAsync(TouristRoutesResourceParameters resourceParameters);

        [TransactionalInterceptor]
        Task<TouristRouteResponseDto?> ProcessAddTouristRouteAsync(TouristRouteCreateDto touristRouteCreateDto);

        [TransactionalInterceptor]
        Task<int?> ProcessUpdateTouristRouteAsync(Guid touristRouteId, TouristRouteUpdateDto touristRouteUpdateDto);

        [TransactionalInterceptor]
        Task<int?> ProcessPartialUpdateTouristRouteAsync(Guid touristRouteId, JsonPatchDocument<TouristRoutePartialUpdateDto> patchDocument);

        [TransactionalInterceptor]
        Task<int?> ProcessDeleteTouristRouteAsync(Guid touristRouteId);

        [TransactionalInterceptor]
        Task<int?> ProcessDeleteTouristRouteByIDsAsync(IEnumerable<Guid> touristIDList);
    }
}
