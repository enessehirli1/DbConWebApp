using System.ComponentModel.DataAnnotations;

namespace FAsgmntV2.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        public string Website { get; set; }
    }

}
