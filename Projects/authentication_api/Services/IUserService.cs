using authentication_api.Models;

namespace authentication_api.Services
{
    public interface IUserService
    {
       object Register (User userData);
       object Login (string email, string password);
       object Logout (string email);
       User? GetUserByMail(string email);
       User? UpdateProfile(string email, User userData);
    }
}