using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs.Product
{
    // Used for create product on client-side
    public class CreateProductRequestDto
    {
        [Required]
        [MaxLength(6, ErrorMessage = "Code cannot be over 6 characters")]
        public string Code { get; set; } = string.Empty;
        [Required]
        [MinLength(3, ErrorMessage = "Product name should be more than 3 characters, please put meaningful name")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}