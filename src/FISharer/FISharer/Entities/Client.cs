using System.ComponentModel.DataAnnotations;

namespace FISharer.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public ClientStatus Status { get; set; }
        public ClientType Type { get; set; }
    }
}
