using ecommerce_basic_web_api.Models;

namespace ecommerce_basic_web_api.Services {
    public interface ICategoryService{
        IEnumerable<Category> GetAllCategories(); // Fetch All Categories
        Category? GetCategoryById(Guid id); // Fetch a Category by id
        IEnumerable<Category> GetCategoryByName(string name); // Fetch categories by name
        Category CreateCategory(Category category); // Create a new Category
        bool UpdateCategory(Guid id, Category updatedCategory); // Updated a existing category
        bool DeleteCategory(Guid id);
    }

}