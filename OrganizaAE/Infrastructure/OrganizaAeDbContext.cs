using Microsoft.EntityFrameworkCore;

namespace OrganizaAE.Infrastructure
{
    public class OrganizaAeDbContext : DbContext
    {
        public OrganizaAeDbContext(DbContextOptions<OrganizaAeDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Mounth.Mounth> Mounths { get; set; }
        public DbSet<Models.Payment.Payment> Payments{ get; set; }
        public DbSet<Models.Social.Social> Socials { get; set; }
        public DbSet<Models.User.User> Users { get; set; }

    }
}
