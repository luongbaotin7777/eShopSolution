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
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                    CategoryTranslations = new List<CategoryTranslation>()
                    {
                        new CategoryTranslation()
                        {
                            Name = "Áo Nam",LanguageId="vi-VN",SeoAlias="ao-nam",SeoDescription="Sản phẩm áo thời trang nam",SeoTitle="Sản phẩm áo thời trang nam"
                        },
                         new CategoryTranslation()
                        {
                            Name = "Men Shirt",LanguageId="en-US",SeoAlias="men-shirt",SeoDescription="The Shirt products for men",SeoTitle="The Shirt products for men"
                        }
                    }
                }
                );
            modelBuilder.Entity<Product>().HasData(
              new Product
              {
                  DateCreated = DateTime.Now,
                  OriginalPrice = 100000,
                  Price = 200000,
                  Stock =0,
                  ViewCount=0,
                  ProductTranslations = new List<ProductTranslation>()
                  {
                      new ProductTranslation()
                      {
                          Name ="Áo sơ mi nam trắng Việt Tiến",
                          LanguageId="vi-VN",
                          SeoAlias="ao-so-mi-nam-trang-viet-tien",
                          SeoDescription="Áo sơ mi nam trắng Việt Tiến",
                          SeoTitle="Áo sơ mi nam trắng Việt Tiến",
                          Details="Áo sơ mi nam trắng Việt Tiến",
                          Description="Áo sơ mi nam trắng Việt Tiến"
                      },
                       new ProductTranslation()
                      {
                          Name ="Men T-Shirt Viet Tien Color: White",
                          LanguageId="vi-VN",
                          SeoAlias="ao-so-mi-nam-trang-viet-tien",
                          SeoDescription="Áo sơ mi nam trắng Việt Tiến",
                          SeoTitle="Áo sơ mi nam trắng Việt Tiến",
                          Details="Áo sơ mi nam trắng Việt Tiến",
                          Description="Áo sơ mi nam trắng Việt Tiến"
                      },
                  }

              }
              );
        }
    }
}
