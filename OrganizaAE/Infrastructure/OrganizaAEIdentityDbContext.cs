using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OrganizaAE.Infrastructure
{
    public class OrganizaAeIdentityDbContext : IdentityDbContext<IdentityUser>
    {
        public OrganizaAeIdentityDbContext(DbContextOptions<OrganizaAeIdentityDbContext> options)
            : base(options)
        {
        }
    }
}
