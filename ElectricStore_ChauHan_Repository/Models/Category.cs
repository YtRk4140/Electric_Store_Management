using System;
using System.Collections.Generic;

namespace ElectricStore_ChauHan_Repository.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryCode { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
