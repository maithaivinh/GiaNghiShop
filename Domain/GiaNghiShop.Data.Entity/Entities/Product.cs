using GiaNghiShop.Infrastructure.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiaNghiShop.Data.Entity.Entities
{
    public class Product : BaseEntity
    {
        public string Code { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public string SeoAlias { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductTranslation> ProductTranslations { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
