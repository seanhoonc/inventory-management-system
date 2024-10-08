using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs.Product;
using api.Models;

namespace api.Inferfaces
{
    // Interface to define database calls in product repository
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        // The outcome could be null so return value as nullable.
        Task<Product?> GetByIdAsync(int id);
        Task<Product?> GetByCodeAsync(string produtCode);
        Task<Product> CreateAsync(Product productModel);
        Task<Product?> UpdateAsync(int id, UpdateProductRequestDto productDto);
        Task<Product?> DeleteAsync(int id);


    }
}