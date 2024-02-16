using FakeXiecheng.API.Models;

namespace FakeXiecheng.API.Repositories
{
    public interface ITouristRoutePictureRepository : IRepository<TouristRoutePicture>
    {
        void PartialUpdatePicture(TouristRoutePicture picture, string url, DateTimeOffset? updateTime = null);
        void MarkPictureAsDeleted(TouristRoutePicture picture, DateTimeOffset? deletedTime = null);
        void MarkPictureListAsDeleted(IEnumerable<TouristRoutePicture> pictureList, DateTimeOffset? deletedTime = null);
    }
}
