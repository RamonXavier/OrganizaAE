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

        [HttpPost("api/Payment/Create")]
        public async Task<IActionResult> CreateAsync(PaymentDto payment)
        {
            await _paymentService.Create(payment);
            return Ok();
        }
    }
}
