using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using authentication_api.Services;
using authentication_api.Models;
using authentication_api.RequestBody;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace authentication_api.Controllers
{
    [ApiController]
    [Route("api/auth")]

    public class AuthController : ControllerBase{
        private readonly IUserService _userService;
        private readonly IConfiguration _config;

        public AuthController(IUserService userService, IConfiguration config)
        {
            _userService = userService;
            _config = config;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterRequest user){
            Console.WriteLine($"Registering user: {user.Email} - {user.Password} - done");
            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
                return BadRequest("Email and password are required.");

            var response = _userService.Register(new User{
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            });
            return Ok(response);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request){
            Console.WriteLine($"Credentials in Controller {request.Email} - {request.Password}");
            // if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            //     return BadRequest("Username and password are required.");
            var response = _userService.Login(request.Email, request.Password);
            return Ok(response);
        }
        [Authorize]
        [HttpPost("logout")]
        public IActionResult Logout()
        {   
            var email = User.FindFirstValue(ClaimTypes.Email);
            if (string.IsNullOrEmpty(email))
                return Unauthorized("User is not authenticated.");
            var result = _userService.Logout(email);
            if (result is null)
                return NotFound("User not found.");

            // Response.Headers.Add("Set-Cookie", "Authorization=; Path=/; HttpOnly; Expires=DateTime.UtcNow.AddDays(-1)");
            // Clear Access Token in Cookie (if using cookie-based JWT)
            Response.Cookies.Append("Authorization", "", new CookieOptions
            {
                HttpOnly = true,
                // Secure = true, // Set to true in production (HTTPS only)
                SameSite = SameSiteMode.Strict,
                Expires = DateTime.UtcNow.AddDays(-1) // Expire immediately
            });

            return Ok(result);
        }

    }
}