using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.DTOs.Warehouse
{
    public class WarehouseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsRefrigerated { get; set; } = false;
        public List<Inventory>? Inventories { get; set; }
    }
}