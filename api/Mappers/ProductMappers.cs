using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs;
using api.DTOs.Product;
using api.Models;

namespace api.Mappers
{
    public static class ProductMappers
    {
        public static ProductDto ToProductDto(this Product productModel)
        {
            return new ProductDto
            {
                Id = productModel.Id,
                Code = productModel.Code,
                Name = productModel.Name,
                Description = productModel.Description,
                CategoryId = productModel.CategoryId,
                Inventories = productModel.Inventories.ToList(),
            };
        }

        public static Product ToProductFromCreateDto(this CreateProductRequestDto productDto, int categoryId)
        {
            return new Product
            {
                Code = productDto.Code,
                Name = productDto.Name,
                Description = productDto.Description,
                CategoryId = categoryId,
                // Inventories = productDto.Inventories.ToList(),
            };
        }
    }
}