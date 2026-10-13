using System;
using System.ComponentModel.DataAnnotations;

namespace ProductApiWithDb.Dtos.Response
{
    public class ProductDtosResponse
    {
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 20 characters")]
        public String? Name {get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "Price must be a positive number")]
        public decimal Price {get; set; }
        [StringLength(5, ErrorMessage = "Description must be at most 5 characters")]
        public String? Description {get; set; }
    }
}