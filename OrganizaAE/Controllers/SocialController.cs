using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrganizaAE.Feactures.Social.Dto;
using OrganizaAE.Feactures.Social.Service;

namespace OrganizaAE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SocialController : Controller
    {
        private readonly ISocialService _socialService;

        public SocialController(ISocialService socialService)
        {
            _socialService = socialService;
        }

        [HttpGet("api/Sociais")]
        public async Task<IActionResult> Get()
        {
            var sociais = await _socialService.Get();
            return Ok(sociais);
        }

        [HttpPost("api/Sociais/Create")]
        public async Task<IActionResult> Create(SocialDto social)
        {
            var socialDto = await _socialService.Create(social);
            return Ok(socialDto);
        }

        [HttpPut("api/Sociais/Update")]
        public async Task<IActionResult> Update(SocialDto social)
        {
            var socialDto = await _socialService.Update(social);
            return Ok(socialDto);
        }

        [HttpDelete("api/Sociais/Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _socialService.Remove(id);
            return Ok();
        }
    }
}
