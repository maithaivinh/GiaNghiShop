using System;
using System.Collections.Generic;
using System.Text;

namespace GiaNghiShop.Infrastructure.Abstracts
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}
