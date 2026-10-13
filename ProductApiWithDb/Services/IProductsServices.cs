using System;
using ProductApiWithDb.Models;

namespace ProductApiWithDb.Services
{
    public interface IProductsServices
    {
        Task<IEnumerable<Product>> getAllProducts();
        Task<Product> getProductById(int id);

        Task<Product> addProduct(Product product);

        Task<Product> updateProduct(Product product);
        Task<Product> deleteProduct(int id);
        Task patchProduct(int id, Product product);
    }
}