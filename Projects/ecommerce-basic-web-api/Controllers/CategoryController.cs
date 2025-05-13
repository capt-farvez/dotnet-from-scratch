using System.Buffers;
using Microsoft.AspNetCore.Mvc;
using ecommerce_basic_web_api.Models;
using ecommerce_basic_web_api.Services;

namespace ecommerce_basic_web_api.Controllers
{   
    [ApiController]
    [Route("api/category/")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService){
            _categoryService = categoryService;
        }

        // GET: api/category
        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = _categoryService.GetAllCategories();
            return Ok(categories);
        }

        // GET: api/category/{id}
        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            var category = _categoryService.GetCategoryById(id);
            return category is null ? NotFound() : Ok(category);
        }

        // GET: api/category/search?name=electronics
        [HttpGet("search")]
        public IActionResult GetByName([FromQuery] string name)
        {
            var results = _categoryService.GetCategoryByName(name);
            return results.Any() ? Ok(results) : NotFound();
        }

        // POST: api/category
        [HttpPost]
        public IActionResult Create(Category category)
        {
            var createdCategory = _categoryService.CreateCategory(category);
            return CreatedAtAction(nameof(GetById), new { id = createdCategory.CategoryId }, createdCategory);
        }

        // PUT: api/category/{id}
        [HttpPut("{id:guid}")]
        public IActionResult Update(Guid id, Category updatedCategory)
        {
            var category = _categoryService.UpdateCategory(id, updatedCategory);
            return category ? NoContent() : NotFound();
        }

        // DELETE: api/category/{id}
        [HttpDelete("{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            var success = _categoryService.DeleteCategory(id);
            return success ? NoContent() : NotFound();
        }
    }

}