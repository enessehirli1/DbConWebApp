using System.ComponentModel.DataAnnotations;

namespace FAsgmntV2.Models
{
    public class Authors
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Biography { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime? DateOfDeath { get; set; }
    }

}
