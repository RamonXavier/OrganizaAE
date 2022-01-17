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

        [HttpGet("api/Mounth")]
        public async Task<IActionResult> Get()
        {
            var mounths = await _mounthService.Get();
            return Ok(mounths);
        }

        [HttpPost("api/Mounth/Create")]
        public async Task<IActionResult> Create(MounthDto mounthDto)
        {
            var mounth = await _mounthService.Create(mounthDto);
            return Ok(mounth);
        }

        [HttpPut("api/Mounth/Update")]
        public async Task<IActionResult> Update(MounthDto mounthDto)
        {
            var mounth = await _mounthService.Update(mounthDto);
            return Ok(mounth);
        }

        [HttpDelete("api/Mounth/Delete")]
        public async Task<IActionResult> Remove(int id)
        {
            await _mounthService.Remove(id);
            return Ok();
        }
    }
}
