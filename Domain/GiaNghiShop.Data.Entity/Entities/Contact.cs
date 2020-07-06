using GiaNghiShop.Infrastructure.Abstracts;
using GiaNghiShop.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiaNghiShop.Data.Entity.Entities
{
    public class Contact : BaseEntity
    {
        public string Code { set; get; }
        public string ContactName { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Message { set; get; }
        public Status Status { set; get; }
    }
}
