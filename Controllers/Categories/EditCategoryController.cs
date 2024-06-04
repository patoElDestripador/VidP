using Microsoft.AspNetCore.Mvc;
using VidP.DTOs;
using VidP.Model;
using VidP.Services.Categories;


namespace VidP.Controllers.Categories
{
    [ApiController]
    [Route("api/[controller]")]
    public class EditCategoryController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;

        public EditCategoryController(ICategoriesService CategoriesService)
        {
            _categoriesService = CategoriesService;
        }

        [HttpPut]
        public async Task<ActionResult<Category>> EditCategory([FromBody] CategoryDTO category)
        {
            return Ok(await _categoriesService.EditCategoryAsync( category));
        }
    }
}