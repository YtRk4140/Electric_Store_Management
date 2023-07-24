using ElectricStore_ChauHan_Repository.DAO;
using ElectricStore_ChauHan_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricStore_ChauHan_Repository.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Product product)
        {
            ProductDbContext.Instance.AddProduct(product);
        }
        public void UpdateProduct(Product product)
            => ProductDbContext.Instance.UpdateProduct(product);

        public void DeleteProduct(int id)
        {
            ProductDbContext.Instance.DeleteProduct(id);
        }
        public List<Product> GetAllProducts()
            => ProductDbContext.Instance.GetAllProducts();

        public Product GetProductById(int id)
           => ProductDbContext.Instance.GetProductById(id);

        public List<Category> GetAllCategories()
        {
            return ProductDbContext.Instance.GetCategories();
        }

        public Category GetCategoryById(int id)
        {
            return ProductDbContext.Instance.GetCategoryById(id);
        }        
    }
}
