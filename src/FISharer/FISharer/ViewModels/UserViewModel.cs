using System.ComponentModel.DataAnnotations;

namespace FISharer.ViewModels
{
    public class UserViewModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
