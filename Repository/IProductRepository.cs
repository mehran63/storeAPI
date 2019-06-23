using StoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApi.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProducts(ProductFilter filter);

        Task<Product> GetProductById(string id);

        Task<Product> DeleteProductById(string id);

        Task<Product> AddProduct(Product product);

        Task<Product> UpdateProduct(Product newProduct);
    }
}
