using System.ComponentModel.DataAnnotations;

namespace FISharer.Models
{
    public class TokenResponseViewModel
    {
        [Required]
        public string Token { get; set; }
    }
}
