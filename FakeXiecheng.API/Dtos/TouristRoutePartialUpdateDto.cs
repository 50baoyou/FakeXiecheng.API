namespace FakeXiecheng.API.Dtos
{
    public class TouristRoutePartialUpdateDto : TouristRouteManipulationDto
    {
        public ICollection<TouristRoutePicturePartialUpdateDto> TouristRoutePictures { get; set; }
        = new List<TouristRoutePicturePartialUpdateDto>();
    }
}
