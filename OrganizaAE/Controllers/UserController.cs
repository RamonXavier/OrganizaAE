using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrganizaAE.Feactures.User.Dto;
using OrganizaAE.Feactures.User.Service;

namespace OrganizaAE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("api/User")]
        public async Task<IActionResult> Get()
        {
            var users = await _userService.Get();
            return Ok(users);
        }

        [HttpPost("api/User/Create")]
        public async Task<IActionResult> Create(UserDto userDto)
        {
            var users = await _userService.Create(userDto);
            return Ok(users);
        }

        [HttpPost("api/User/Login")]
        public async Task<IActionResult> Login(UserLoginDto userDto)
        {
            await _userService.Login(userDto);
            return Ok();
        }

        [HttpPut("api/User/Update")]
        public async Task<IActionResult> Login(UserDto userDto)
        {
            var user = await _userService.Update(userDto);
            return Ok(user);
        }

        [HttpDelete("api/User/Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userService.Remove(id);
            return Ok();
        }
    }
}
