namespace FISharer.Services.Interfaces
{
    public interface IFilesStorageService
    {
        string Add(byte[] data);
        byte[] Get(string token);
    }
}
