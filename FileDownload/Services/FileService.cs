using FileDownload.Interface;

namespace FileDownload.Services
{
    public class FileService : IFileService
    {
        public MemoryStream GetFileStream()
           => new MemoryStream(ConvertImageToByteArray());

        public byte[] GetBinary()
           => ConvertImageToByteArray();

        private byte[] ConvertImageToByteArray()
        {
            var directory = Directory.GetCurrentDirectory();
            var path = Path.Combine(directory, "files", "testimage.jpg");

            return File.ReadAllBytes(path);
        }
    }
}
