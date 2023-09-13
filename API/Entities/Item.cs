using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Item : BaseEntity
    {
       
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public int ItemCategoryId { get; set; }
        [ForeignKey("ItemCategoryId")]
        public ItemCategory ItemCategories { get; set; }

        
        public int UnitOfMeasureId { get; set; }
        [ForeignKey("UnitOfMeasureId")]
        public UnitOfMeasure UnitOfMeasures { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal UnitPrice { get; set; }

        public int QuantityInStock { get; set; }

        public int? ReorderLevel { get; set; }
        
        [Required]
        public bool IsComponent { get; set; } // Indicates if it's an ingredient or not. Not means it is final product


        public int? SupplierId { get; set; }

        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }
        
        public List<Photo> Photos { get; set; } = new();
    }
}
