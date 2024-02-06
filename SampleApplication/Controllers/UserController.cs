using Microsoft.AspNetCore.Mvc;
using user.Models;

namespace users
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register(User user)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok("User Registered Successfully");
        }
    }
}