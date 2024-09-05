using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs.Category;
using api.Models;

namespace api.Inferfaces
{
    // Interface to define database calls in category repository
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllAsync();
        Task<Category?> GetByIdAsync(int id);
        Task<Category> CreateAsync(Category categoryModel);
        Task<Category?> UpdateAsync(int id, CreateAndUpdateCategoryRequestDto categoryDto);
        Task<Category?> DeleteAsync(int id);
        Task<bool> CategoryExist(int categoryId);
    }
}