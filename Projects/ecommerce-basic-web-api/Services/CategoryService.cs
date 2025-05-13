using ecommerce_basic_web_api.Models;

namespace ecommerce_basic_web_api.Services{

    public class CategoryService : ICategoryService{
        private readonly List<Category> _categories = new();

        //  Get All Categories
        public IEnumerable<Category> GetAllCategories(){
            return _categories;
        }
         // Fetch a Category by id
        public Category? GetCategoryById(Guid id){
            var category =  _categories.FirstOrDefault(c => c.CategoryId==id);
            return category;

        }
        // Fetch categories by name
        public IEnumerable<Category> GetCategoryByName(string name){
            var category = _categories
                .Where(c => !string.IsNullOrEmpty(c.Name) && c.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();
            return category;
        }
        // Create a new Category
        public Category CreateCategory(Category category){
            category.CategoryId = Guid.NewGuid();
            category.CreatedAt = DateTime.UtcNow;
            _categories.Add(category);
            return category;

        } 
        // Updated a existing category
        public bool UpdateCategory(Guid id, Category updatedCategory){
            var category = _categories.FirstOrDefault(c => c.CategoryId == id);
            if (category is null) return false;

            category.Name = updatedCategory.Name;
            category.Description = updatedCategory.Description;
            return true;
        }
        public bool DeleteCategory(Guid id){
            var category = _categories.FirstOrDefault(c => c.CategoryId == id);
            if (category is null) return false;

            _categories.Remove(category);
            return true;
        }
    }
}