using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrganizaAE.Infrastructure.User
{
    public class UserRepository : Repository<Models.User.User>, IUserRepository
    {
        public UserRepository(OrganizaAeDbContext dbContext) : base(dbContext)
        {
        }
    }
}
