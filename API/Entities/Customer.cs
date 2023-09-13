using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Customer : BaseEntity
    {
        
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        public string Address { get; set; }
    }
}
