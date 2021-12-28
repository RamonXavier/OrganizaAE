
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OrganizaAE.Infrastructure
{
    public class OrganizaAeDbContext : IdentityDbContext<IdentityUser>
    {
        public OrganizaAeDbContext(DbContextOptions options) : base(options)
        {

        }


    }
}
