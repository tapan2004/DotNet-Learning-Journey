using System;
using ProductApiWithDb.Dtos.Response;
using ProductApiWithDb.Models;
namespace ProductApiWithDb.Dtos
{
    public class ProductMapping
    {
        public static ProductDtosResponse MapToProductDtosResponse(Product product)
        {
            return new ProductDtosResponse
            {
                Name = product.Name,
                Price = product.Price,
                Description = product.Description
            };
        }

        public static Product MapToProduct(ProductDtoRequest productDtoRequest)
        {
            return new Product
            {
                Name = productDtoRequest.Name,
                Price = productDtoRequest.Price,
                Description = productDtoRequest.Description
            };
        }
    }
}