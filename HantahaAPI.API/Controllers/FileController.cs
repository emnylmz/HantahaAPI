using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HantahaAPI.API.Controllers
{
    [Authorize(Roles = "Admin")]
    public class FileController : BaseController
    {

        public FileController(
            IHttpContextAccessor httpContextAccessor
            ) : base(httpContextAccessor)
        {
        }

        [HttpGet("{imageName}")]
        [AllowAnonymous]
        public IActionResult GetImage(string imageName)
        {
            var imagePath = Path.Combine("wwwroot", "images", imageName);

            if (!System.IO.File.Exists(imagePath))
            {
                return NotFound(); // Eğer dosya bulunamazsa 404 hatası döndür
            }

            var fileBytes = System.IO.File.ReadAllBytes(imagePath);

            // MIME tipini dosya uzantısına göre belirle
            string contentType;
            var extension = Path.GetExtension(imagePath);

            switch (extension.ToLowerInvariant())
            {
                case ".jpg":
                case ".jpeg":
                    contentType = "image/jpeg";
                    break;
                case ".png":
                    contentType = "image/png";
                    break;
                // Diğer dosya uzantılarına göre ek case'ler ekleyebilirsiniz
                default:
                    contentType = "application/octet-stream"; // Genel bir binary dosya
                    break;
            }

            return File(fileBytes, contentType);
        }

    }


}

