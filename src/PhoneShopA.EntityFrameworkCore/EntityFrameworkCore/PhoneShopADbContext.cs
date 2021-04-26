using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PhoneShopA.Authorization.Roles;
using PhoneShopA.Authorization.Users;
using PhoneShopA.MultiTenancy;
using Abp.Localization;
using PhoneShopA.Domain;
using PhoneShopA.Configuration;
using PhoneShopA.ModelBuilderExtension;

namespace PhoneShopA.EntityFrameworkCore
{
    public class PhoneShopADbContext : AbpZeroDbContext<Tenant, Role, User, PhoneShopADbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public PhoneShopADbContext(DbContextOptions<PhoneShopADbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); //độ dài tối đa ký tự trong MSSQL và PostgreSQL khác nhau, nên set max Value property của
                                    //ApplicationLanguageText bé hơn 10485760
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
            modelBuilder.Entity<Category>()
                .HasMany<Product>(g => g.Products)
                .WithOne(s => s.Category)
                .HasForeignKey(s => s.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.SeedData();
            base.OnModelCreating(modelBuilder);

        }
    }
}
