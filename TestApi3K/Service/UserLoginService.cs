using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestApi3K.DataBaseContext;
using TestApi3K.Interfaces;
using TestApi3K.Model;
using TestApi3K.Requests;

namespace TestApi3K.Service
{
    public class UserLoginService : IUsersLoginsService
    {
        private readonly ContextDb _context;

        public UserLoginService(ContextDb context)
        {
            _context = context;
        }

        public async Task<IActionResult> GetAllUsersAsync()
        {
            var users = await _context.Users.ToListAsync();

            return new OkObjectResult(new
            {
                data = new { users = users },
                status = true
            });
        }

        public async Task<IActionResult> CreateNewUserAsync(CreateNewUser newUser)
        {
            var user = new Users()
            {
                Name = newUser.Name,
                Login = newUser.Login,
                Password = newUser.Password
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return new OkObjectResult(new
            {
                status = true
            });
        }

        public async Task<IActionResult> GetUserCoinsAsync(int userId)
        {
            var user = await _context.Users.FindAsync(userId);

            return new OkObjectResult(new { coins = user.Coins });
        }

        public async Task<IActionResult> AddCoinsAsync(int userId, int amount)
        {
            var user = await _context.Users.FindAsync(userId);

            user.Coins += amount;
            await _context.SaveChangesAsync();

            return new OkObjectResult(new { coins = user.Coins });
        }

        public async Task<IActionResult> SpendCoinsAsync(int userId, int amount)
        {
            var user = await _context.Users.FindAsync(userId);

            user.Coins -= amount;
            await _context.SaveChangesAsync();

            return new OkObjectResult(new { coins = user.Coins });
        }
    }
}
