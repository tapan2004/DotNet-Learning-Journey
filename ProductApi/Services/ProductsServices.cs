using ProductApi.Dtos;
using ProductApi.Models;

namespace ProductApi.Services
{
    public class ProductServices : IProductServices
    {

          private static readonly List<Product> products = new()
        {
            new Product {Id=1, Name ="Laptop", Price =50000, Description="This is Branded Laptop"},
            new Product {Id=2, Name="Phone", Price=20000, Description="This is power full gaming Phone"}
        };
        private int _nextId=3;

        public List<Product> GetAll()
        {
            return products.ToList();
        }

        public Product? GetById(int Id)
        {
            return products.FirstOrDefault(p=>p.Id==Id);
        }
        public Product Create(ProductDto productDto)
        {
            var newProduct=new Product
            {
                Id=_nextId++,
                Name=productDto.Name,
                Price=productDto.Price,
                Description=productDto.Description
            };
            products.Add(newProduct);
            return newProduct;
        }

        public bool Update(int Id, ProductDto productDto)
        {
           var existingProduct= GetById(Id);
           if(existingProduct is null)
            {
                return false;
            }

            existingProduct.Name=productDto.Name;
            existingProduct.Price=productDto.Price;
            existingProduct.Description=productDto.Description;
            return true;
        }

        public bool delete(int Id)
        {
            throw new NotImplementedException();
        }
    }
}