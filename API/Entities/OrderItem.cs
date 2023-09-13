using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class OrderItem : BaseEntity
    {
        
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }
    }
}
