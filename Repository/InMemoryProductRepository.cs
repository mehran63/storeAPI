using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreApi.Models;

namespace StoreApi.Repository
{
    /// <summary>
    /// The only reason these methods made Async is to show the skills of the developer in async programming as this is a showcase project
    /// </summary>
    public class InMemoryProductRepository : IProductRepository
    {
        private static List<Product> _products;

        public InMemoryProductRepository()
        {
            _products = new List<Product>();
            //{
            //    new Product
            //    {
            //        Id= "1-fp-01",
            //        Brand = "JB Hifi",
            //        Model = "Premium",
            //        Description = "Newly launched product to showcase exprience and skills of the developer"
            //    },
            //     new Product
            //    {
            //        Id= "1-fp-02",
            //        Brand = "JB Hifi",
            //        Model = "Standard",
            //        Description = "Second newly launched product to showcase exprience and skills of the developer"
            //    }
            //};
        }

#pragma warning disable 1998

        public async Task<List<Product>> GetAllProducts(ProductFilter filter = null)
        {
            var products = _products.AsEnumerable();

            if (!string.IsNullOrEmpty(filter?.Id))
            {
                products = products.Where(p => (p?.Id ?? "").Contains(filter.Id));
            }

            if (!string.IsNullOrEmpty(filter?.Model))
            {
                products = products.Where(p => (p?.Model ?? "").Contains(filter.Model));
            }

            if (!string.IsNullOrEmpty(filter?.Brand))
            {
                products = products.Where(p => (p?.Brand ?? "").Contains(filter.Brand));
            }

            if (!string.IsNullOrEmpty(filter?.Description))
            {
                products = products.Where(p => (p?.Description ?? "").Contains(filter.Description));
            }

            return products.ToList();
        }

        public async Task<Product> GetProductById(string id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public async Task<Product> DeleteProductById(string id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);

            _products.Remove(product);

            return product;
        }

        public async Task<Product> AddProduct(Product product)
        {
            _products.Add(product);
            return product;
        }

        public async Task<Product> UpdateProduct(Product newProduct)
        {
            var loadedProduct = _products.FirstOrDefault(p => p.Id == newProduct.Id);

            if (loadedProduct != null)
            {
                _products.Remove(loadedProduct);
                _products.Add(newProduct);
            }

            return loadedProduct;
        }

#pragma warning restore 1998
    }
}
