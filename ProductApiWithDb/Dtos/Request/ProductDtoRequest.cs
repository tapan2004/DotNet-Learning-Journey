
using System.ComponentModel.DataAnnotations;

namespace ProductApiWithDb.Dtos
{
    public class ProductDtoRequest
    {
        [Required]
        [StringLength(20)]
        public string Name {get; set; }=string.Empty;
        [Range(1,double.MaxValue, ErrorMessage ="Price must be getter than 0")]
        public decimal Price {get; set; }
        [StringLength(50)]
        public string Description {get; set; }=string.Empty;
    }
}