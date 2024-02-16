using AutoMapper;
using FakeXiecheng.API.Dtos;
using FakeXiecheng.API.DTOs;
using FakeXiecheng.API.Models;
using MassTransit;

namespace FakeXiecheng.API.Profiles
{
    public class TouristRoutrProfile : Profile
    {
        public TouristRoutrProfile()
        {
            CreateMap<TouristRoute, TouristRouteResponseDto>()
                // 投影字段
                .ForMember(
                    dest => dest.Price,
                    opt => opt.MapFrom(src => src.OriginalPrice * (decimal)(src.DiscountPresent ?? 1))
                )
                .ForMember(
                    dest => dest.TravelDays,
                    opt => opt.MapFrom(src => src.TravelDays.ToString())
                )
                .ForMember(
                    dest => dest.TripType,
                    opt => opt.MapFrom(src => src.TripType.ToString())
                )
                .ForMember(
                    dest => dest.DepartureCity,
                    opt => opt.MapFrom(src => src.DepartureCity.ToString())
                );

            CreateMap<TouristRouteCreateDto, TouristRoute>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => NewId.NextGuid())
                );

            CreateMap<TouristRouteUpdateDto, TouristRoute>()
                .ForMember(
                    dest => dest.TouristRoutePictures,
                    opt => opt.Ignore()
                );

            CreateMap<TouristRoute, TouristRoutePartialUpdateDto>();

            CreateMap<TouristRoutePartialUpdateDto, TouristRoute>();
        }
    }
}
