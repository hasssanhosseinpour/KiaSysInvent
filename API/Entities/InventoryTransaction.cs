using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class InventoryTransaction : BaseEntity
    {
        
        public int Id { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required]
        [MaxLength(50)]
        public string TransactionType { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public int QuantityChange { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }
    }
}
