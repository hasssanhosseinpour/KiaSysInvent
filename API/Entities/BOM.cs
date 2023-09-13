using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{


    public class BOM : BaseEntity
    {
        public int Id { get; set; }

        [Required]
        public int ItemId { get; set; } // Foreign key to the Item table

        [Required]
        public int ChildItemId { get; set; } 

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Quantity { get; set; } // Quantity of the ingredient required

        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        
    }

    /*
    Pizza dough or crust - 300 grams (Below items are the dough ingredients)
        All-purpose flour - 300 grams
        Warm water - 175 milliliters (approximately 175 grams)
        Active dry yeast - 7 grams (1 packet)
        Olive oil - 15 milliliters (approximately 15 grams)
        Sugar - 5 grams
        Salt - 5 grams
    Tomato sauce or pizza sauce - 150 grams
    Mozzarella cheese - 200 grams
    Grilled or cooked chicken breast, sliced or diced - 200 grams
    Bacon strips, cooked and crumbled - 100 grams
    Sliced tomatoes - 150 grams
    Sliced red onions - 50 grams
    Fresh lettuce or mixed greens - 100 grams
    Ranch dressing or mayonnaise-based sauce - 100 grams
    Parmesan cheese (optional) - 50 grams
    Salt and pepper to taste
    */

}