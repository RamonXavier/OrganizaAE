using System.Collections.Generic;
using System.Threading.Tasks;
using OrganizaAE.Feactures.Payment.Dto;

namespace OrganizaAE.Feactures.Payment.Service
{
    public interface IPaymentService
    {
        Task<IEnumerable<PaymentCompleteDto>> Get();
        Task Create(PaymentDto paymentDto);
    }
}
