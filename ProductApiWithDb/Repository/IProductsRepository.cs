using ProductApiWithDb.Models;

namespace ProductApiWithDb.Repository
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Product>> getAllProducts();
        Task<Product> getProductById(int id);

        Task<Product> AddProduct(Product product);

        Task<Product> updateProduct(Product product);
        Task<Product> deleteProduct(int id);
    }
}