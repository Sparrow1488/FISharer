using System.ComponentModel.DataAnnotations;

namespace FISharer.ViewModels
{
    public class UserViewModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
