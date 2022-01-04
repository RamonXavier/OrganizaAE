using Microsoft.EntityFrameworkCore;
using OrganizaAE.Models.Mounth;
using OrganizaAE.Models.Payment;
using OrganizaAE.Models.Social;

namespace OrganizaAE.Infrastructure
{
    public class OrganizaAeDbContext : DbContext
    {
        public OrganizaAeDbContext(DbContextOptions<OrganizaAeDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Mount> Mounths { get; set; }
        public DbSet<Payment> Payments{ get; set; }
        public DbSet<Social> Socials { get; set; }

    }
}
