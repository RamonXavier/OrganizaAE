using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrganizaAE.Infrastructure.Payment
{
    public interface IPaymentRepository : IRepository<Models.Payment.Payment>
    {
        Task<IEnumerable<Models.Payment.Payment>> GetAllAsyncWithSocialAndUserAndMounth();
    }
}
