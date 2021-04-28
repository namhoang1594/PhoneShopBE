using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneShopA.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShopA.Configuration
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.ToTable("Blogs");
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Title).IsRequired().HasMaxLength(200);
            builder.Property(p => p.TypeofDocument).IsRequired().HasMaxLength(100);
            builder.Property(p => p.ShortContents).HasMaxLength(200);
            builder.Property(p => p.MainContents).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200);
        }
    }
}