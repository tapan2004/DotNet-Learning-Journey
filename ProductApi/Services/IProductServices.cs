using ProductApi.Dtos;
using ProductApi.Models;

namespace ProductApi.Services;
public interface IProductServices
{
    List<Product> GetAll();
    Product ? GetById(int Id);
    Product Create(ProductDto productDto);
    bool Update(int Id, ProductDto productDto);
    bool delete(int Id);
}