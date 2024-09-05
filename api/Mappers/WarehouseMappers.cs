using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs.Warehouse;
using api.Models;

namespace api.Mappers
{
    public static class WarehouseMappers
    {
        public static WarehouseDto ToWarehouseDto(this Warehouse warehouse)
        {
            return new WarehouseDto
            {
                Id = warehouse.Id,
                Name = warehouse.Name,
                IsRefrigerated = warehouse.IsRefrigerated,
                // To do : change to inventoryDto
                Inventories = warehouse.Inventories.ToList(),
            };
        }
    }
}