using System.ComponentModel.DataAnnotations;

namespace AbobaMAket.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}
