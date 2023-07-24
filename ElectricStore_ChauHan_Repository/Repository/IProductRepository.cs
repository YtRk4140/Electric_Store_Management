using ElectricStore_ChauHan_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricStore_ChauHan_Repository.Repository
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        List<Category> GetAllCategories();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        Category GetCategoryById(int id);
    }
}
