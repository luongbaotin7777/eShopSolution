using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig { Key = "HomeTitle", Value = "This is Home Page of eShopSolution" },
                new AppConfig { Key = "HomeKeyword", Value = "This is Key Word of eShopSolution" },
                new AppConfig { Key = "HomeDescription", Value = "This is Description of eShopSolution" }
            );
            modelBuilder.Entity<Language>().HasData(
                new Language { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language { Id = "en-US", Name = "English", IsDefault = false }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                new Category
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active,
                }
                );
            modelBuilder.Entity<CategoryTranslation>().HasData(
                 new CategoryTranslation()
                 {
                     Id = 1,
                     CategoryId = 1,
                     Name = "Áo Nam",
                     LanguageId = "vi-VN",
                     SeoAlias = "ao-nam",
                     SeoDescription = "Sản phẩm áo thời trang nam",
                     SeoTitle = "Sản phẩm áo thời trang nam"
                 },
                 new CategoryTranslation()
                 {
                     Id = 2,
                     CategoryId = 1,
                     Name = "Men Shirt",
                     LanguageId = "en-US",
                     SeoAlias = "men-shirt",
                     SeoDescription = "The Shirt products for men",
                     SeoTitle = "The Shirt products for men"
                 },
                 new CategoryTranslation()
                 {
                     Id = 3,
                     CategoryId = 2,
                     Name = "Áo Nữ",
                     LanguageId = "vi-VN",
                     SeoAlias = "ao-nam",
                     SeoDescription = "Sản phẩm áo thời trang nữ",
                     SeoTitle = "Sản phẩm áo thời trang nữ"
                 },
                 new CategoryTranslation()
                 {
                     Id=4,
                     CategoryId = 2,
                     Name = "Women Shirt",
                     LanguageId = "en-US",
                     SeoAlias = "Women-shirt",
                     SeoDescription = "The Shirt products for Women",
                     SeoTitle = "The Shirt products for Women"
                 }
                );
            modelBuilder.Entity<Product>().HasData(
              new Product
              {
                  Id = 1,
                  DateCreated = DateTime.Now,
                  OriginalPrice = 100000,
                  Price = 200000,
                  Stock = 0,
                  ViewCount = 0,
              },
               new Product
               {
                   Id = 2,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 200000,
                   Price = 400000,
                   Stock = 0,
                   ViewCount = 0,
               }
              );
            modelBuilder.Entity<ProductTranslation>().HasData(
                      new ProductTranslation()
                      {
                          Id=1,
                          ProductId = 1,
                          Name = "Áo sơ mi nam trắng Việt Tiến",
                          LanguageId = "vi-VN",
                          SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                          SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                          SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                          Details = "Áo sơ mi nam trắng Việt Tiến",
                          Description = "Áo sơ mi nam trắng Việt Tiến"
                      },
                       new ProductTranslation()
                       {
                           Id=2,
                           ProductId = 1,
                           Name = "Viet Tien Men T-Shirt Color: White",
                           LanguageId = "vi-VN",
                           SeoAlias = "viet-tien-men-t-shirt-color-white",
                           SeoDescription = "Viet Tien Men T-Shirt Color: White",
                           SeoTitle = "Viet Tien Men T-Shirt Color: White",
                           Details = "Viet Tien Men T-Shirt Color: White",
                           Description = "Viet Tien Men T-Shirt Color: White"
                       },
                        new ProductTranslation()
                        {
                            Id = 3,
                            ProductId = 2,
                            Name = "Áo sơ mi nữ hồng Gucci",
                            LanguageId = "vi-VN",
                            SeoAlias = "ao-so-mi-nu-hong-gucci",
                            SeoDescription = "Áo sơ mi nữ hồng Gucci",
                            SeoTitle = "Áo sơ mi nữ hồng Gucci",
                            Details = "Áo sơ mi nữ hồng Gucci",
                            Description = "Áo sơ mi nữ hồng Gucci"
                        },
                       new ProductTranslation()
                       {
                           Id = 4,
                           ProductId = 2,
                           Name = "Gucci Women T-Shirt Color: Pink",
                           LanguageId = "vi-VN",
                           SeoAlias = "gucci-women-t-shirt-color-pink",
                           SeoDescription = "Gucci Women T-Shirt Color: Pink",
                           SeoTitle = "Gucci Women T-Shirt Color: Pink",
                           Details = "Gucci Women T-Shirt Color: Pink",
                           Description = "Gucci Women T-Shirt Color: Pink"
                       }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                 new ProductInCategory()
                 {
                     ProductId = 1,
                     CategoryId = 1
                 },
                  new ProductInCategory()
                  {
                      ProductId = 2,
                      CategoryId = 2
                  }
                 );
        }
    }
}
