using GiaNghiShop.Infrastructure.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiaNghiShop.Data.Entity.Entities
{
    public class AppConfig : BaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
