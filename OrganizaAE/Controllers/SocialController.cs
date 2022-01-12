using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Buscar()
        {
            var sociais = await _socialService.Buscar();
            return Ok(sociais);
        }
    }
}
