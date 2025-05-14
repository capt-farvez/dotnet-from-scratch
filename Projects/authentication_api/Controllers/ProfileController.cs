using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using authentication_api.Models;
using authentication_api.Services;
using System.Security.Claims;
using authentication_api.RequestBody;

namespace auth_api_sqlite.Controllers
{
    [ApiController]
    [Route("api/profile")]
    [Authorize] // Only logged-in users can access
    public class ProfileController : ControllerBase
    {
        private readonly IUserService _userService;

        public ProfileController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/profile
        [HttpGet]
        public IActionResult GetProfile()
        {
            var userMail = User.FindFirstValue(ClaimTypes.Email);
            if (userMail == null) 
                return Unauthorized("User not logged in.");

            var user = _userService.GetUserByMail(userMail);
            return Ok(user);
        }

        // PUT: api/profile
        [HttpPut]
        public IActionResult UpdateProfile([FromBody] UpdateProfileRequest updatedProfile)
        {
            var userMail = User.FindFirstValue(ClaimTypes.Email);
            Console.WriteLine($"Controller --> Email : {userMail} ");
            if (userMail == null) 
                return Unauthorized("User not logged in.");

            var user = _userService.UpdateProfile(userMail, new User{
                Name = updatedProfile.Name,
                Email = updatedProfile.Email
            });
            return user == null ? NotFound("User not found.") : Ok(user);
        }
    }
}
