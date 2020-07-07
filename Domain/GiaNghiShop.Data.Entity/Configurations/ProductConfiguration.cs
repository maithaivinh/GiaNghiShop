using GiaNghiShop.Data.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiaNghiShop.Data.Entity.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Code)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();
            builder.Property(p => p.ProductName)
                .HasMaxLength(255)
                .HasColumnType("nvarchar")
                .IsRequired();
            builder.Property(p => p.Price)
                .IsRequired();
            builder.Property(p => p.OriginalPrice)
                 .IsRequired();
            builder.Property(p => p.Stock)
                .IsRequired()
                .HasDefaultValue(0);
            builder.Property(p => p.ViewCount)
                .IsRequired()
                .HasDefaultValue(0);
            builder.Property(p => p.DateCreate);
            builder.Property(p => p.DateUpdate);
        }
    }
}
