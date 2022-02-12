using System;
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

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listPayment = await _paymentService.Get();
                return Ok(listPayment);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("GetById/{idPayment}")]
        public async Task<IActionResult> GetById(int idPayment)
        {
            try
            {
                var payment = await _paymentService.GetById(idPayment);
                return Ok(payment);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateAsync(PaymentDto payment)
        {
            try
            {
                await _paymentService.Create(payment);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAsync(PaymentDto payment)
        {
            try
            {
                await _paymentService.Update(payment);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpDelete("Delete/{idPayment}")]
        public async Task<IActionResult> UpdateAsync(int idPayment)
        {
            try
            {
                await _paymentService.Delete(idPayment);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
