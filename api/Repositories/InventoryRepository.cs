using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Inferfaces;
using api.Mappers;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    // Manage database calls for Inventory controller
    public class InventoryRepository : IInventoryRepository
    {
        private readonly ApplicationDBcontext _context;
        public InventoryRepository(ApplicationDBcontext context)
        {
            _context = context;
        }

        public async Task<Inventory> CreateAsync(Inventory inventory)
        {
            await _context.Inventories.AddAsync(inventory);
            await _context.SaveChangesAsync();

            return inventory;
        }

        public async Task<List<Product>> GetInventoryProduct(int warehouseId)
        {
            return await _context.Inventories.Where(c => c.WarehouseId == warehouseId)
            .Select(product => new Product
            {
                Id = product.ProductId,
                Code = product.Product.Code,
                Name = product.Product.Name,
                Description = product.Product.Description
            })
            .ToListAsync();
        }
    }
}