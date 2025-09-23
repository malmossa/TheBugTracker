using TheBugTracker.Models;

namespace TheBugTracker.Helpers
{
    public class ImageHelper
    {
        public static readonly string DefaultProfilePictureUrl = "/images/profile_picture.png";

        public static async Task<ImageUpload> GetImageUploadAsync(IFormFile file)
        {
            using var ms = new MemoryStream();
            await file.CopyToAsync(ms);
            byte[] data = ms.ToArray();

            if (ms.Length > 1 * 2024 * 2024)
            {
                throw new Exception("The image is too large.");
            }

            ImageUpload imageUpload = new()
            {
                Id = Guid.NewGuid(),
                Data = data,
                Type = file.ContentType
            };

            return imageUpload;
        }
    }
}
