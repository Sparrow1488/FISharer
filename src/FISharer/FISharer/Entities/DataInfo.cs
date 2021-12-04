using System.ComponentModel.DataAnnotations;

namespace FISharer.Entities
{
    public class DataInfo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
        [Range(1, long.MaxValue)]
        public long Size { get; set; }
        public int? ArchiveDataId { get; set; }
        public ClientData ArchiveData { get; set; }
    }
}
