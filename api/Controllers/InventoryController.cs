using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Inferfaces;
using api.Mappers;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/inventory")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IProductRepository _productRepo;
        private readonly IWarehouseRepository _warehouseRepo;
        private readonly IInventoryRepository _inventoryRepo;


        public InventoryController(IProductRepository productRepo, IWarehouseRepository warehouseRepo, IInventoryRepository inventoryRepo)
        {
            _productRepo = productRepo;
            _warehouseRepo = warehouseRepo;
            _inventoryRepo = inventoryRepo;
        }

        [HttpGet("{warehouseId}")]
        public async Task<IActionResult> GetInventoryProduct([FromRoute] int warehouseId)
        {
            var products = await _inventoryRepo.GetInventoryProduct(warehouseId);

            var productDto = products.Select(s => s.ToProductDto());

            return Ok(productDto);
        }

        [HttpPost]
        public async Task<IActionResult> AddInventoryProduct(int warehouseId, string productCode, int quantity)
        {
            var product = await _productRepo.GetByCodeAsync(productCode);

            if (product == null)
            {
                return NotFound("product does not exist");
            }

            // Check if the item already exist in the inventory
            var inventory = await _inventoryRepo.GetInventoryProduct(warehouseId);

            if (inventory.Any(c => c.Code.ToLower() == productCode.ToLower()))
            {
                return BadRequest("Cannot add same product to inventory.");
            }

            var inventoryModel = new Inventory
            {
                ProductId = product.Id,
                WarehouseId = warehouseId,
                Quantity = quantity,
            };

            if (inventoryModel == null)
            {
                return StatusCode(500, "Could not create.");
            }
            else
            {
                return Ok(inventoryModel);
            }
        }

    }

}


/*
To do: write an code for creating inventory with products.
Refer to youtube #27
*/