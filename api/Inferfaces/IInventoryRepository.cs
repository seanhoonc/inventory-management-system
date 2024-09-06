using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Models;

namespace api.Inferfaces
{
    // Interface to define database calls in Inventory repository
    public interface IInventoryRepository
    {
        Task<List<Product>> GetInventoryProduct(int warehouseId);
        Task<Inventory> CreateAsync(Inventory inventory);

    }
}