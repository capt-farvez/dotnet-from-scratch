namespace ecommerce_basic_web_api.Models{
    public class Category{
        public Guid CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; } = string.Empty;
        public DateTime CreatedAt {get; set;}
    }
}