
using VidP.DTOs;
using VidP.Model;
using VidP.Services.Categories;
using Microsoft.AspNetCore.Mvc;

namespace VidP.Controllers.Categories
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateCategoryController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;

        public CreateCategoryController(ICategoriesService CategoriesService)
        {
            _categoriesService = CategoriesService;
        }

        [HttpPost]
        public async Task<ActionResult<Category>> CreateCategorie([FromBody] CategoryDTO Categorie)
        {
            Category result = await _categoriesService.CreateCategoryAsync(Categorie);
            return Ok(result);
        }
    }
}