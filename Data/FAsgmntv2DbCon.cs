using FAsgmntV2.Models;
using Microsoft.EntityFrameworkCore;

namespace FAsgmntV2.Data
{
    public class FAsgmntv2DbCon:DbContext
    {
        public FAsgmntv2DbCon(DbContextOptions<FAsgmntv2DbCon> options) : base(options)
        {

        }

        public DbSet<Subscriber> Subscribers 
        {
            get; set;
        }
        public DbSet<FAsgmntV2.Models.Authors> Authors { get; set; } = default!;
        public DbSet<FAsgmntV2.Models.Book> Book { get; set; } = default!;
        public DbSet<FAsgmntV2.Models.Category> Category { get; set; } = default!;
        public DbSet<FAsgmntV2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<FAsgmntV2.Models.Review> Reviews { get; set; } = default!;
    }
}
