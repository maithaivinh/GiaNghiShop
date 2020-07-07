using GiaNghiShop.Data.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiaNghiShop.Data.Entity.Configuration
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(p => new { p.ProductId, p.CategoryId });
            builder.HasOne(p => p.Product)
                .WithMany(p => p.ProductInCategories)
                .HasForeignKey(p => p.ProductId);
            builder.HasOne(p => p.Category)
                .WithMany(p => p.ProductInCategories)
                .HasForeignKey(p => p.CategoryId);
        }
    }
}
