using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Inferfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/warehouse")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseRepository _warehouseRepo;
        public WarehouseController(IWarehouseRepository warehouseRepo)
        {
            _warehouseRepo = warehouseRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var warehouses = await _warehouseRepo.GetAllAsync();

            var warehouseDto = warehouses.Select(s => s.ToWarehouseDto());

            return Ok(warehouseDto);
        }
    }
}