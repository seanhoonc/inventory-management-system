using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Inferfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    // Manage database calls for Warehouse controller
    public class WarehouseRepository : IWarehouseRepository
    {
        private readonly ApplicationDBcontext _context;
        public WarehouseRepository(ApplicationDBcontext context)
        {
            _context = context;
        }

        public async Task<List<Warehouse>> GetAllAsync()
        {
            return await _context.Warehouses.ToListAsync();
        }
    }
}