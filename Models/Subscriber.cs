using System.ComponentModel.DataAnnotations;


namespace FAsgmntV2.Models
{
    public class Subscriber
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string subLevel { get; set; }

        [Required] 
        public int age { get; set;}
    }
}
