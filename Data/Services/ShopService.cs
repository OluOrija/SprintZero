using SprintZero.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SprintZero.Data.Services
{
    public class ShopService : IShopService
    {
        public void AddProduct(Product product)
        {
            Data.Products.Add(product);
        }

        public void DeleteProduct(int productId)
        {
            var product = Data.Products.FirstOrDefault(n => n.Id == productId);
            if (product != null)
            {
                Data.Products.Remove(product);
            }
        }

        public List<Product> GetAllProducts() => Data.Products.ToList();

        public Product GetProductById(int productId) => Data.Products.FirstOrDefault(n => n.Id == productId);

        public void UpdateProduct(int productId, Product product)
        {
            var oldProduct = Data.Products.FirstOrDefault(n => n.Id == productId);

            if (oldProduct != null)
            {
                oldProduct.Name = product.Name;
                oldProduct.Description = product.Description;
            }
        }
    }
}
