using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBcontext : DbContext
    {
        public ApplicationDBcontext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure builder for Inventory model which is a keyless entity type.
            builder.Entity<Inventory>(x => x.HasKey(i => new { i.ProductId, i.WarehouseId }));

            builder.Entity<Inventory>()
                .HasOne(u => u.Product)
                .WithMany(u => u.Inventories)
                .HasForeignKey(i => i.ProductId);

            builder.Entity<Inventory>()
                .HasOne(u => u.Warehouse)
                .WithMany(u => u.Inventories)
                .HasForeignKey(i => i.WarehouseId);
        }
    }
}