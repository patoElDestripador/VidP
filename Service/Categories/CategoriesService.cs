using VidP.Data;
using VidP.DTOs;
using VidP.Model;
using Microsoft.EntityFrameworkCore;

namespace VidP.Services.Categories
{
    public class CategoriesService : ICategoriesService
    {

        private readonly BaseContext _context;

        public CategoriesService(BaseContext context)
        {
            _context = context;
        }

        public async Task<Category> CreateCategoryAsync(CategoryDTO categoryDTO)
        {
            var category = new Category()
            {
                CategoryName = categoryDTO.CategoryName,
            };

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category> EditCategoryAsync(CategoryDTO categoryDTO)
        {
            var category = new Category()
            {
                CategoryName = categoryDTO.CategoryName,
            };
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return category;
        }

        public void DeleteCategoryAsync(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();

        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<IEnumerable<Category>> GetCategoriesByStatusAsync(string status)
        {
            return await _context.Categories.Where(d => d.Status == status).ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }
    }
}