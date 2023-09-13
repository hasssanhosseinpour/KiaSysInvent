using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Supplier : BaseEntity
    {
        
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string ContactName { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        public string Address { get; set; }
    }
}
