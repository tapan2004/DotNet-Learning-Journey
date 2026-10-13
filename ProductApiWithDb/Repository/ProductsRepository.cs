using Microsoft.EntityFrameworkCore;
using ProductApiWithDb.Data;
using ProductApiWithDb.Models;

namespace ProductApiWithDb.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ProductDbContext _context;

        public ProductsRepository(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> getAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> getProductById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Product> AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product?> updateProduct(Product product)
        {
            var existingProduct = await _context.Products.FindAsync(product.Id);
            if (existingProduct == null)
            {
                return null;
            }

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Description = product.Description;

            await _context.SaveChangesAsync();
            return existingProduct;
        }

        public async Task<Product?> deleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return null;
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
