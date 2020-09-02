using SprintZero.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SprintZero.Data.Services
{
    public interface IShopService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int productId);
        void UpdateProduct(int productId, Product product);
        void DeleteProduct(int productId);
        void AddProduct(Product product);
    }
}
