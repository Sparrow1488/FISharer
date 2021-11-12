using System.ComponentModel.DataAnnotations;

namespace FISharer.Entities
{
    public class DataInfo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public ClientData ArchiveData { get; set; }
    }
}
