using System;
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

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var sociais = await _socialService.Get();
                return Ok(sociais);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("GertById/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var sociais = await _socialService.GetById(id);
                return Ok(sociais);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(SocialDto social)
        {
            try
            {
                var socialDto = await _socialService.Create(social);
                return Ok(socialDto);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(SocialDto social)
        {
            try
            {
                var socialDto = await _socialService.Update(social);
                return Ok(socialDto);
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
                await _socialService.Remove(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
