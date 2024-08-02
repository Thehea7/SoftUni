using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using ProductShop.Data;
using System.Text.Json;
using ProductShop.Models;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            ProductShopContext context = new ProductShopContext();
            string userData = File.ReadAllText("../../../Datasets/users.json");
            string productData = File.ReadAllText("../../../Datasets/products.json");
            string categoriesData = File.ReadAllText("../../../Datasets/categories.json");
            string categoriesProductsData = File.ReadAllText("../../../Datasets/categories-products.json");

            //Console.WriteLine(ImportUsers(context, userData));   // -1
            //Console.WriteLine(ImportProducts(context, productData));  // -2
            //Console.WriteLine(ImportCategories(context, categoriesData)); // -3
            //Console.WriteLine(ImportCategoryProducts(context, categoriesProductsData));  // -4
            //Console.WriteLine(GetProductsInRange(context));  // - 5
            //Console.WriteLine(GetSoldProducts(context));  // - 6
            //Console.WriteLine(GetCategoriesByProductsCount(context)); // - 7
            //Console.WriteLine(GetUsersWithProducts(context));
        }

        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Any(ps => ps.BuyerId != null))
                .Select(u => new
                {

                    u.FirstName,
                    u.LastName,
                    u.Age,
                    SoldProducts = u.ProductsSold
                        .Where(p => p.BuyerId != null)
                        .Select(p => new
                        {
                            p.Name,
                            p.Price
                        })
                        .ToArray()

                })
                .OrderByDescending(u => u.SoldProducts.Length)
                .ToArray();


            var output = new
            {
                UsersCount = users.Length,
                Users = users
                    .Select(u => new
                    {
                        u.FirstName,
                        u.LastName,
                        u.Age,
                        SoldProducts = new 
                        {
                            Count = u.SoldProducts.Length,
                            Products = u.SoldProducts
                        }
                    })


            };

            var settings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore

            };

            return JsonConvert.SerializeObject(output, settings);
        }  // - 8
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                .Select(c => new
                {
                    Category = c.Name,
                    ProductsCount = c.CategoriesProducts.Count,
                    AveragePrice = c.CategoriesProducts.Average(cp => cp.Product.Price).ToString("f2"),
                    TotalRevenue = c.CategoriesProducts.Sum(cp => cp.Product.Price).ToString("f2")
                })
                .OrderByDescending(c => c.ProductsCount)
                .ToList();

            var settings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver()

            };

            return JsonConvert.SerializeObject(categories, settings);
        } // - 7
        public static string GetSoldProducts(ProductShopContext context)
        {
            var result = context.Users
                .Where(u => u.ProductsSold.Any(ps => ps.BuyerId != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new
                {
                    u.FirstName,
                    u.LastName,
                    SoldProducts = u.ProductsSold
                        .Where(p => p.BuyerId != null)
                        .Select(p => new
                        {
                            p.Name,
                            p.Price,
                            BuyerFirstName = p.Buyer.FirstName,
                            BuyerLastName = p.Buyer.LastName
                        })
                });

            var settings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            return JsonConvert.SerializeObject(result, settings);
        }  // -6
        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .OrderBy(p => p.Price)
                .Select(p => new
                {
                    p.Name,
                    p.Price,
                    Seller = $"{p.Seller.FirstName} {p.Seller.LastName}"
                });

            var settings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            return JsonConvert.SerializeObject(products, settings);
        }  // - 5
        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            var categoriesProducts = JsonConvert.DeserializeObject<List<CategoryProduct>>(inputJson);

            context.CategoriesProducts.AddRange(categoriesProducts);
            context.SaveChanges();

            return $"Successfully imported {categoriesProducts.Count}";
        } // -4
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var categories = JsonConvert.DeserializeObject<List<Category>>(inputJson);
            categories.RemoveAll(c => c.Name is null);

            context.Categories.AddRange(categories);
            context.SaveChanges();


            return $"Successfully imported {categories.Count}";
        } // -3
        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            var products = JsonConvert.DeserializeObject<List<Product>>(inputJson);
            //products.ForEach(Console.WriteLine);
            context.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Count}";
        } // -2
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            //var options = new JsonSerializerOptions()
            //{
            //    WriteIndented = true,
            //    PropertyNameCaseInsensitive = true,
            //    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull

            //};
            //var users = JsonSerializer.Deserialize<List<User>>(inputJson, options);
            var users = JsonConvert.DeserializeObject<List<User>>(inputJson);
            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Count}";
        }  // -1

    }
}