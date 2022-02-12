using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrganizaAE.Feactures.Mounth.Dto;
using OrganizaAE.Feactures.Mounth.Service;

namespace OrganizaAE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MounthController : Controller
    {
        private readonly IMounthService _mounthService;

        public MounthController(IMounthService mounthService)
        {
            _mounthService = mounthService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var mounths = await _mounthService.Get();
                return Ok(mounths);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var mounth = await _mounthService.GetById(id);
                return Ok(mounth);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(MounthDto mounthDto)
        {

            try
            {
                var mounth = await _mounthService.Create(mounthDto);
                return Ok(mounth);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(MounthDto mounthDto)
        {
            try
            {
                var mounth = await _mounthService.Update(mounthDto);
                return Ok(mounth);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _mounthService.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
