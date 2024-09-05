using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs.Category
{
    // Used for create and update category on client-side
    public class CreateAndUpdateCategoryRequestDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "Category name should be more than 3 characters")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}