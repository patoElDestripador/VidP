using VidP.DTOs;
using VidP.Model;

namespace VidP.Services.Categories
{
    public interface ICategoriesService
    {
        Task<Category> CreateCategoryAsync(CategoryDTO categoriesDTO);
        Task<Category> EditCategoryAsync(CategoryDTO categoriesDTO);
        void DeleteCategoryAsync(int id);
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<IEnumerable<Category>> GetCategoriesByStatusAsync(string status);
        Task<Category> GetCategoryByIdAsync(int id);
    }
}