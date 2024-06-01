namespace FileDownload.Interface
{
    public interface IFileService
    {
        public MemoryStream GetFileStream();
        public byte[] GetBinary();
           
    }
}
