using System.ComponentModel.DataAnnotations;

namespace FAsgmntV2.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }

}
