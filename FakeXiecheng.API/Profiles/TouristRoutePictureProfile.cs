using AutoMapper;
using FakeXiecheng.API.Dtos;
using FakeXiecheng.API.Models;

namespace FakeXiecheng.API.Profiles
{
    public class TouristRoutePictureProfile : Profile
    {
        public TouristRoutePictureProfile()
        {
            CreateMap<TouristRoutePicture, TouristRoutePictureResponseDto>();

            CreateMap<TouristRoutePictureCreateDto, TouristRoutePicture>();

            CreateMap<TouristRoutePicture, TouristRoutePictureUpdateDto>();

            CreateMap<TouristRoutePictureUpdateDto, TouristRoutePicture>();

            CreateMap<TouristRoutePicture, TouristRoutePicturePartialUpdateDto>();

            CreateMap<TouristRoutePicturePartialUpdateDto, TouristRoutePicture>();
        }
    }
}
