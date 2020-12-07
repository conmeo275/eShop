using eShop.Data.Entities;
using eShop.Data.TypeProp;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
               );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Bánh bông lan", LanguageId = "vi", SeoAlias = "banh-bong-lan", SeoDescription = "Bánh bông lan Description", SeoTitle = "Bánh bông lan Title" },
                  new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Bong lan banh", LanguageId = "en", SeoAlias = "bong-lan-banh", SeoDescription = "Bong lan banh Description", SeoTitle = "Bong lan banh Title" },
                  new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Bánh trung thu", LanguageId = "vi", SeoAlias = "banh-trung thu", SeoDescription = "Bánh trung thu Description", SeoTitle = "Bánh trung thu Title" },
                  new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Trung thu banh", LanguageId = "en", SeoAlias = "trung-thu-banh", SeoDescription = "Trung thu banh Description", SeoTitle = "Trung thu banh Title" }
                    );

            modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               Id = 1,
               DateCreated = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
           });
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Bánh bông lan trứng muối",
                     LanguageId = "vi",
                     SeoAlias = "Bánh bông lan trứng muối",
                     SeoDescription = "Bánh bông lan trứng muối",
                     SeoTitle = "Bánh bông lan trứng muối",
                     Details = "Bánh bông lan trứng muối",
                     Description = "Bánh bông lan trứng muối"
                 },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "Banh bong lan trung muoi",
                        LanguageId = "en    ",
                        SeoAlias = "banh-bong-lan-trung-muoi",
                        SeoDescription = "Banh bong lan trung muoi",
                        SeoTitle = "Banh bong lan trung muoi",
                        Details = "Banh bong lan trung muoi",
                        Description = "Banh bong lan trung muoi"
                    });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );

            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "thanhdat2751999@gmail.com",
                NormalizedEmail = "thanhdat2751999@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Nguyen",
                LastName = "Thanh Dat",
                Dob = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
