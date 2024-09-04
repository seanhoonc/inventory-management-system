using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Inventory
    {
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public required Product Product { get; set; }
        public required Warehouse Warehouse { get; set; }
    }
}