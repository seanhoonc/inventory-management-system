using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs.Category;
using api.Models;

namespace api.Mappers
{
    public static class CategoryMappers
    {
        // Transfer category model to categorydto to hide unnecessary fields
        public static CategoryDto ToCategoryDto(this Category category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Products = category.Products.Select(c => c.ToProductDto()).ToList(),
            };
        }

        // return new category model from category request dto which takes essential fields from client-side
        public static Category ToCategoryFromCreateDto(this CreateAndUpdateCategoryRequestDto categoryDto)
        {
            return new Category
            {
                Name = categoryDto.Name,
                Description = categoryDto.Description,
            };
        }
    }
}