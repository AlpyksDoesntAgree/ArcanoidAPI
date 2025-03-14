using Microsoft.AspNetCore.Mvc;
using TestApi3K.Interfaces;
using TestApi3K.Requests;

namespace TestApi3K.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersLoginsController
    {
        private readonly IUsersLoginsService _userLoginService;

        public UsersLoginsController(IUsersLoginsService userLoginService)
        {
            _userLoginService = userLoginService;
        }

        [HttpGet]
        [Route("getAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            return await _userLoginService.GetAllUsersAsync();
        }

        [HttpPost]
        [Route("createNewUser")]
        public async Task<IActionResult> CreateNewUser(CreateNewUser newUser)
        {
            return await _userLoginService.CreateNewUserAsync(newUser);
        }
    }
}
