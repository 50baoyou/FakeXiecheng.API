using FakeXiecheng.API.Database;
using FakeXiecheng.API.Models;

namespace FakeXiecheng.API.Repositories
{
    public class TouristRoutePictureRepository : Repository<TouristRoutePicture>, ITouristRoutePictureRepository
    {
        public TouristRoutePictureRepository(FakeXieChengContext context) : base(context)
        {
        }

        public void PartialUpdatePicture(TouristRoutePicture picture, string url, DateTimeOffset? updateTime = null)
        {
            if (picture != null)
            {
                picture.Url = url;
                picture.LastUpdatedTime = updateTime ?? DateTimeOffset.Now;
            }
            // 注意：这里不执行SaveChanges，以允许业务逻辑层决定何时提交更改
        }

        public void MarkPictureAsDeleted(TouristRoutePicture picture, DateTimeOffset? deletedTime = null)
        {
            if (picture != null)
            {
                picture.IsDeleted = true;
                picture.LastUpdatedTime = deletedTime ?? DateTimeOffset.Now;
            }
            // 注意：这里不执行SaveChanges，以允许业务逻辑层决定何时提交更改
        }

        public void MarkPictureListAsDeleted(IEnumerable<TouristRoutePicture> pictureList, DateTimeOffset? deletedTime = null)
        {
            var currentTime = deletedTime ?? DateTimeOffset.Now;

            foreach (var picture in pictureList)
            {
                MarkPictureAsDeleted(picture, currentTime);
            }
            // 注意：这里不执行SaveChanges，以允许业务逻辑层决定何时提交更改
        }
    }
}
