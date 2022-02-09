using System.Collections.Generic;
using System.Threading.Tasks;
using OrganizaAE.Feactures.Payment.Dto;

namespace OrganizaAE.Feactures.Payment.Service
{
    public interface IPaymentService
    {
        Task<IEnumerable<PaymentCompleteDto>> Get();
        Task<PaymentCompleteDto> GetById(int idPayment);
        Task Create(PaymentDto paymentDto);
        Task Update(PaymentDto paymentDto);
        Task Delete(int idPayment);
    }
}
