using VidP.Model;
using Microsoft.AspNetCore.Mvc;
using VidP.Services.Categories;

namespace VidP.Controllers.Categories
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeleteCategoryController : ControllerBase
{
        private readonly ICategoriesService _categoriesService;

        public DeleteCategoryController(ICategoriesService CategoriesService)
        {
            _categoriesService = CategoriesService;
    }


        [HttpDelete("{id}")]
        public  ActionResult  DeleteCategory(int id)
        {
            _categoriesService.DeleteCategoryAsync(id);
            return Ok();
        }
    }
}