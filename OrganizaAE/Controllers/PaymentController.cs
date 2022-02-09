using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrganizaAE.Feactures.Payment.Dto;
using OrganizaAE.Feactures.Payment.Service;

namespace OrganizaAE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PaymentController : Controller
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet("api/Payment")]
        public async Task<IActionResult> Get()
        {
            var listPayment = await _paymentService.Get();
            return Ok(listPayment);
        }

        [HttpGet("api/Payment/{idPayment}")]
        public async Task<IActionResult> GetById(int idPayment)
        {
            var listPayment = await _paymentService.GetById(idPayment);
            return Ok(listPayment);
        }

        [HttpPost("api/Payment/Create")]
        public async Task<IActionResult> CreateAsync(PaymentDto payment)
        {
            await _paymentService.Create(payment);
            return Ok();
        }

        [HttpPut("api/Payment/Update")]
        public async Task<IActionResult> UpdateAsync(PaymentDto payment)
        {
            await _paymentService.Update(payment);
            return Ok();
        }

        [HttpDelete("api/Payment/Delete/{idPayment}")]
        public async Task<IActionResult> UpdateAsync(int idPayment)
        {
            await _paymentService.Delete(idPayment);
            return Ok();
        }
    }
}
