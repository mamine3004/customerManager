using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using serviceLayer;

namespace webLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUser userService;

        public UserController(IUser userService)
        {
            this.userService = userService;
        }

        //[HttpGet(Name = "")]
        //public IActionResult getAllUser()
        
        //    return Ok();
        //}
    }
}
