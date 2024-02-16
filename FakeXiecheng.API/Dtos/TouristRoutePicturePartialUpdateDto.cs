namespace FakeXiecheng.API.Dtos
{
    public class TouristRoutePicturePartialUpdateDto : TouristRoutePictureManipulationDto
    {
        public int Id { get; set; }

        public DateTimeOffset CreateTime { get; set; }

        public DateTimeOffset LastUpdatedTime { get; set; }

        public bool IsDeleted { get; set; }
    }
}
