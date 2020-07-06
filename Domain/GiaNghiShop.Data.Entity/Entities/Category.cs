using GiaNghiShop.Infrastructure.Abstracts;
using GiaNghiShop.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiaNghiShop.Data.Entity.Entities
{
    public class Category : BaseEntity
    {
        public string Code { get; set; }
        public string CategoryName { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public Guid? ParentId { get; set; }
        public Status Status { get; set; }
    }
}
