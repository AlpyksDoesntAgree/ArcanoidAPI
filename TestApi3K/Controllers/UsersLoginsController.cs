﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("{id}/coins")]
        public async Task<IActionResult> GetUserCoins(int id)
        {
            return await _userLoginService.GetUserCoinsAsync(id);
        }

        [HttpPost("{id}/add-coins")]
        public async Task<IActionResult> AddCoins(int id, [FromBody] int amount)
        {
            return await _userLoginService.AddCoinsAsync(id, amount);
        }

        [HttpPost("{id}/spend-coins")]
        public async Task<IActionResult> SpendCoins(int id, [FromBody] int amount)
        {
            return await _userLoginService.SpendCoinsAsync(id, amount);
        }
    }
}
