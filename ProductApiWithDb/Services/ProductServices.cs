using ProductApiWithDb.Models;
using ProductApiWithDb.Repository;
namespace ProductApiWithDb.Services
{
    public class ProductServices : IProductsServices
    {
        private readonly IProductsRepository _productsRepository;
        public ProductServices(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }
        public async Task<Product> addProduct(Product product)
        {
            return await _productsRepository.AddProduct(product);
        }

        public async Task<Product?> deleteProduct(int id)
        {
            return await _productsRepository.deleteProduct(id);
        }

        public async Task<IEnumerable<Product>> getAllProducts()
        {
            return await _productsRepository.getAllProducts();
        }

        public async Task<Product?> getProductById(int id)
        {
            return await _productsRepository.getProductById(id);
        }

        public async Task<Product?> updateProduct(Product product)
        {
            return await _productsRepository.updateProduct(product);
        }

        Task<Product?> IProductsServices.patchProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}