namespace FISharer.ViewModels
{
    public class UploadedFilesViewModel
    {
        public UploadedFilesViewModel(bool isSuccess, string token)
        {
            Success = isSuccess;
            Token = token;
        }
        public UploadedFilesViewModel(bool isSuccess, string token, string message) : this(isSuccess, token)
        {
            Message = message;
        }
        
        public bool Success { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
    }
}
