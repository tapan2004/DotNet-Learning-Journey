using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Dtos;
using ProductApi.Models;
using ProductApi.Services;

namespace ProductApi.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly IProductServices productServices;

        [HttpGet("{Id}")]
        public ActionResult<Product> GetById(int Id)
        {
            var product = productServices.GetById(Id);
            if (product is null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {
            return Ok(productServices.GetAll);
        }

        [HttpPost]
        public ActionResult<Product> Create(ProductDto productDto)
        {
            var product = productServices.Create(productDto);

            return CreatedAtAction(
                nameof(GetById),
                new { id = product.Id },
                product
            );
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, ProductDto productDto)
        {
            var updateProduct = productServices.Update(id, productDto);
            if (!updateProduct)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult delete(int id)
        {
            var productDeleted = productServices.delete(id);
            if (!productDeleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}