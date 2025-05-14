namespace authentication_api.Models
{
    public class User{
        public Guid UserId {get; set;}
        public string? Name {get; set;} = string.Empty;
        public string? Email {get; set;}
        public string? Password {get; set;}
        public string Role { get; set; } = "User";
        public string? RefreshTokenHash { get; set; } =  string.Empty;
        public DateTime? RefreshTokenExpiryTime { get; set; }

        public DateTime CreatedAt {get; set;}
    }
}