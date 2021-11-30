using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FISharer.Entities
{
    public class ClientData
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(128)]
        public string Token { get; set; }
        public byte[] CompressedData { get; set; }
        public Client Client { get; set; }
        //public string DataInfoJson { get; set; }
        public DateTime CreateTime { get; set; }
        public IEnumerable<DataInfo> FilesInfo { get; set; }
    }
}
