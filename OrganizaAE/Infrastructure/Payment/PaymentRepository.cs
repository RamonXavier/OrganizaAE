using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizaAE.Infrastructure.Payment
{
    public class PaymentRepository : Repository<Models.Payment.Payment>, IPaymentRepository
    {
        public PaymentRepository(OrganizaAeDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Models.Payment.Payment>> GetAllAsyncWithSocialAndUserAndMounth()
        {
            return await _dbContext.Payments.AsNoTracking()
                .Include(x => x.User)
                .Include(x => x.Mounth)
                .Include(x => x.Social)
                .ToListAsync();
        }
    }
}
