using Microsoft.AspNetCore.Mvc;
using TestApi3K.Requests;

namespace TestApi3K.Interfaces
{
    public interface IUsersLoginsService
    {
        Task<IActionResult> GetUserByLoginAndPasswordAsync(string login, string password);
        Task<IActionResult> CreateNewUserAsync(CreateNewUser newUser);

        Task<IActionResult> GetUserCoinsAsync(int userId);
        Task<IActionResult> AddCoinsAsync(int userId, int amount);
        Task<IActionResult> SpendCoinsAsync(int userId, int amount);
    }
}
