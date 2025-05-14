using Microsoft.IdentityModel.Tokens;
using authentication_api.Models;
using System.Security.Cryptography;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;


namespace authentication_api.Services
{
    class UserService : IUserService {
        private readonly AppDbContext _context;
        private readonly IConfiguration _config;

        public UserService(AppDbContext context, IConfiguration config){
            _context = context;
            _config = config;
        }

        public object Register(User user){
            if (_context.Users.Any(u => u.Email == user.Email))
                return new {
                    error = "User Email Already Exists." 
                };

            user.UserId = Guid.NewGuid();
            user.CreatedAt = DateTime.UtcNow;
            // Console.WriteLine($"User password Before Hashing {user.Password}");
            var hashedPassword = MakePasswordHash(user.Password);
            user.Password = hashedPassword;
            // Console.WriteLine($"User password After Hashing {user.Password}");
            _context.Users.Add(user);
            _context.SaveChanges();
            return new{
                id = user.UserId,
                name = user.Name,
                email = user.Email,
            };
        }

        public object Login (string Email, string Password){
            Console.WriteLine($"Credentials in Services {Email} - {Password}");
            var user = _context.Users.FirstOrDefault(u => u.Email == Email);
            if (user == null || !VerifyPassword(Password, user.Password))
                return new {
                    error = "Invalid credentials."
                };

            var refreshToken = GenerateRefreshToken();
            user.RefreshTokenHash = HashRefreshToken(refreshToken);
            user.RefreshTokenHash = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(7); // 7 days expiry
            _context.SaveChanges();

            var accessToken = GenerateJwtToken(user);

            return new {
                access_token = accessToken,
                refresh_token = refreshToken,
                user = new {
                    id = user.UserId,
                    name = user.Name,
                    email = user.Email
                }
            };
        }

    
        public object Logout (string email){
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if(user == null ) return null;

            user.RefreshTokenHash = null;
            user.RefreshTokenExpiryTime = null;
            _context.SaveChanges();

            return new {
                message = "logout successfull"
            };
        }
        public User GetUserByMail(string email){
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if(user==null) return null;
            
            return user;

        }
        public User UpdateProfile(string email, User userData){
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user is null) return null;

            user.Email = userData.Email;
            user.Name = userData.Name;
            _context.SaveChanges();
            return user;  
        }
        


        // ------------------------- Password Hashing -------------------------------//

        private string MakePasswordHash(string password)
        {
            using var sha256 = SHA256.Create();
            var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hashBytes);
        }

        private bool VerifyPassword(string inputPassword, string storedHash)
        {
            using var sha256 = SHA256.Create();
            var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputPassword));
            var inputHash = Convert.ToBase64String(hashBytes);
            return inputHash == storedHash;
        }

        // ------------------------- JWT -------------------------------//
        private string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_config["Jwt:Secret"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private string GenerateRefreshToken() => Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));

        private string HashRefreshToken(string refreshToken)
        {
            using var sha256 = SHA256.Create();
            var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(refreshToken));
            return Convert.ToBase64String(hashBytes);
        }

    }
}