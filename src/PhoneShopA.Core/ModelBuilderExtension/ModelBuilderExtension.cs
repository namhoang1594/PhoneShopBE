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
                    Images = "https://cdn-www.vinid.net/2020/10/5835be9c-xiaomi-redmi-note-9s.jpg",
                    CategoryId = 1,
                },
                new Product()
                {
                    Id = 2,
                    Name = "Iphone 11 ProMax",
                    Price = 32990000,
                    Details = "Iphone quốc tế hàng chính hãng",
                    Quantity = 100,
                    Images = "https://cdn-www.vinid.net/2020/10/5835be9c-xiaomi-redmi-note-9s.jpg",
                    CategoryId = 2,
                },
                new Product()
                {
                    Id = 3,
                    Name = "Iphone 12 ProMax",
                    Price = 32990000,
                    Details = "Iphone quốc tế hàng chính hãng",
                    Quantity = 100,
                    Images = "https://cdn-www.vinid.net/2020/10/5835be9c-xiaomi-redmi-note-9s.jpg",
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
                    Id = 1,
                    Title = "Tin tức 1",
                    TypeofDocument = "tin-tuc",
                    ShortContents = "Nội dung ngắn vài dòng",
                    MainContents = "Nội dung chính nhiều dòng dòng dòng dòng dòng",
                    Images = "https://img.timviec.com.vn/2020/03/blog-la-gi2-696x418.jpg",
                },
                new Blog()
                {
                    Id = 2,
                    Title = "Tin tức 2",
                    TypeofDocument = "tin-tuc",
                    ShortContents = "Nội dung ngắn vài dòng",
                    MainContents = "Nội dung chính nhiều dòng dòng dòng dòng dòng",
                    Images = "https://img.timviec.com.vn/2020/03/blog-la-gi2-696x418.jpg",

                },
                new Blog()
                {
                    Id = 3,
                    Title = "Tin tức 3",
                    TypeofDocument = "tin-tuc",
                    ShortContents = "Nội dung ngắn vài dòng",
                    MainContents = "Nội dung chính nhiều dòng dòng dòng dòng dòng",
                    Images = "https://img.timviec.com.vn/2020/03/blog-la-gi2-696x418.jpg",

                });
        }
    }
}

