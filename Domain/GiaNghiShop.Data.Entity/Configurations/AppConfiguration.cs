using GiaNghiShop.Data.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiaNghiShop.Data.Entity.Configuration
{
    public class AppConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Key)
                .HasColumnType("vachar")
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Value)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
