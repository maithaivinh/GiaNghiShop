using System;
using System.Collections.Generic;
using System.Text;

namespace GiaNghiShop.Data.Entity.Entities
{
    public class ProductInCategory
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
