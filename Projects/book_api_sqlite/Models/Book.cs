using Microsoft.EntityFrameworkCore;

namespace book_api_sqlite.Models{
    public class Book{
        public Guid BookId {get; set;}
        public string? Title {get; set;}
        public string? Description { get; set; } = string.Empty;
        public double Price {get; set;}
        public DateTime CreatedAt {get; set;}
    }
}