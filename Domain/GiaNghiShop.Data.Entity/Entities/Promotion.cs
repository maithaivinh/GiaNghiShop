using GiaNghiShop.Infrastructure.Abstracts;
using GiaNghiShop.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiaNghiShop.Data.Entity.Entities
{
    public class Promotion : BaseEntity
    {
        public string Code { set; get; }
        public string PromotionName { set; get; }
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
        public bool ApplyForAll { set; get; }
        public int? DiscountPercent { set; get; }
        public decimal? DiscountAmount { set; get; }
        public string ProductIds { set; get; }
        public string ProductCategoryIds { set; get; }
        public Status Status { set; get; }
    }
}
