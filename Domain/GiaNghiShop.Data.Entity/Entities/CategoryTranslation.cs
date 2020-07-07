using GiaNghiShop.Infrastructure.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiaNghiShop.Data.Entity.Entities
{
    public class CategoryTranslation : BaseEntity
    {
        public Guid CategoryId { set; get; }
        public string Name { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public Guid LanguageId { set; get; }
        public string SeoAlias { set; get; }

        public Category Category { get; set; }

        public Language Language { get; set; }

    }
}
