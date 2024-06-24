using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FAsgmntV2.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Genre { get; set; }

        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public Authors Author { get; set; }
    }

}
