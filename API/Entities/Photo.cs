using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        // We use a technology to upload photo and we use this property later.
        public string PublicId { get; set; }        
        public int ItemId { get; set; }
        public Item Item { get; set; }

    }
}