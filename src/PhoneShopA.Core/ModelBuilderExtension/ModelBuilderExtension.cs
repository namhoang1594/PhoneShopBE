using Microsoft.EntityFrameworkCore;
using PhoneShopA.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShopA.ModelBuilderExtension
{
    public static class ModelBuilderExtension
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Iphone 10 ProMax",
                    Price = 32990000,
                    Details = "Iphone quốc tế hàng chính hãng",
                    Quantity = 100,
                    CategoryId = 1,
                },
                new Product()
                {
                    Id = 2,
                    Name = "Iphone 11 ProMax",
                    Price = 32990000,
                    Details = "Iphone quốc tế hàng chính hãng",
                    Quantity = 100,
                    CategoryId = 2,
                },
                new Product()
                {
                    Id = 3,
                    Name = "Iphone 12 ProMax",
                    Price = 32990000,
                    Details = "Iphone quốc tế hàng chính hãng",
                    Quantity = 100,
                    CategoryId = 3,
                });
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    CategoryName = "Apple",
                    Description = "Apple"
                },
                new Category()
                {
                    Id = 2,
                    CategoryName = "Samsung",
                    Description = "Samsung"
                },
                new Category()
                {
                    Id = 3,
                    CategoryName = "Vivo",
                    Description = "Vivo"
                });
            modelBuilder.Entity<Blog>().HasData(
                new Blog()
                {
                    Id = new Guid("ABB55EC2-AC3B-4A2A-BB47-25BF17A623C9"),
                    Title = "Tin tức 1",
                    TypeofDocument = "tin-tuc",
                    ShortContents = "Nội dung ngắn vài dòng",
                    MainContents = "Nội dung chính nhiều dòng dòng dòng dòng dòng",
                },
                new Blog()
                {
                    Id = new Guid("C5F3B2C1-CD87-464B-9B86-0062086DF729"),
                    Title = "Tin tức 2",
                    TypeofDocument = "tin-tuc",
                    ShortContents = "Nội dung ngắn vài dòng",
                    MainContents = "Nội dung chính nhiều dòng dòng dòng dòng dòng",
                },
                new Blog()
                {
                    Id = new Guid("CEAB8B18-A8A3-408A-9018-3AAA857C0971"),
                    Title = "Tin tức 3",
                    TypeofDocument = "tin-tuc",
                    ShortContents = "Nội dung ngắn vài dòng",
                    MainContents = "Nội dung chính nhiều dòng dòng dòng dòng dòng",
                });
        }
    }
}

