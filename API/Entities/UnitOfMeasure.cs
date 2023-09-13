using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class UnitOfMeasure : BaseEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

    }
}

