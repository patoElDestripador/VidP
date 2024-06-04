using Microsoft.AspNetCore.Mvc;
using VidP.Model;
using VidP.Services.Categories;

namespace VidP.Controllers.Categories
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;

        public CategoriesController(ICategoriesService CategoriesService)
        {
            _categoriesService = CategoriesService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategorieById(int id)
        {
            Category result = await _categoriesService.GetCategoryByIdAsync(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        {
            IEnumerable<Category> result = await _categoriesService.GetAllCategoriesAsync();

            return Ok(result);
        }
        [HttpGet("Status/{status}")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategoriesByStatusAsync(string status)
        {
            IEnumerable<Category> result = await _categoriesService.GetCategoriesByStatusAsync(status);

            return Ok(result);
        }
    }
}