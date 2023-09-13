using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API.Entities;

namespace API.Entities
{
    public class Order : BaseEntity
    {
        
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        public int? CustomerID { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalAmount { get; set; }

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }
    }
}
