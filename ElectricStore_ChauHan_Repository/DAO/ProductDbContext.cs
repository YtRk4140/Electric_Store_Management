using ElectricStore_ChauHan_Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricStore_ChauHan_Repository.DAO
{
    public class ProductDbContext : ElectricStoreContext
    {
        private static ProductDbContext instance = null;
        private static readonly object instanceLock = new object();

        private ProductDbContext() 
        {
            InitalizeContext();
        }

        protected virtual void InitalizeContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public static ProductDbContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDbContext();
                    }
                    return instance;
                }
            }
        }

        public Product GetProductById(int id)
        {
            return this.Products.FirstOrDefault(x => x.Id == id);
        }
        public List<Product> GetAllProducts()
        {
            return instance.Products.ToList();
        }
        public void UpdateProduct(Product product)
        {
            instance.Products.Update(product);
            instance.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            var product = this.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                instance.Products.Remove(product);
                instance.SaveChanges();
            }
        }

        public void AddProduct(Product product)
        {
            this.Products.Add(product);
            this.SaveChanges();
        }
        /*Lay ra all petgroup*/
        public List<Category> GetCategories() => this.Categories.ToList();
        public Category GetCategoryById(int id)
        {
            return instance.Categories.FirstOrDefault(x => x.Id == id);
        }
    }
}
