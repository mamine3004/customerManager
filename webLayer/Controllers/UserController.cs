using corelayer;
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

        [HttpGet]
        public List<User> getAllUser()
        {
            return userService.findAll();
        }

        [HttpPost]
        public int addUser(User user)
        {
            return userService.addUser(user);
        }


    
    }
}
