using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Inferfaces
{
    // Interface to degine database calls in warehouse repository
    public interface IWarehouseRepository
    {
        Task<List<Warehouse>> GetAllAsync();
    }
}