using FileDownload.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileDownload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileDownloadController : ControllerBase
    {
        private readonly IFileService _fileService;
        private const string MimeType = "img/jpg";
        private const string FileName = "testimage.jpg";
        public FileDownloadController(IFileService fileService)
        {
            this._fileService = fileService;
        }

        [HttpGet("stream")]
        public IActionResult DownloadStreamImage()
        {
            var image = _fileService.GetFileStream();

            return File(image, MimeType, FileName);
        }

        [HttpGet("byte")]
        public IActionResult DownloadByteImage()
        {
            var image = _fileService.GetBinary();

            return File(image, MimeType, FileName);
        }

    }
}
