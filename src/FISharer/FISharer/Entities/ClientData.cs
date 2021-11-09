using System;
using System.ComponentModel.DataAnnotations;

namespace FISharer.Entities
{
    public class ClientData
    {
        [Key]
        public int Id { get; set; }
        public string Token { get; set; }
        public byte[] CompressedData { get; set; }
        public Client Client { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
