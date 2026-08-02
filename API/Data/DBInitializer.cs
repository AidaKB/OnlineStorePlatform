using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DBInitializer
    {
        public void InitDb(WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<StoreContext>() ?? throw new InvalidOperationException("Failed to retrieve store context");

            SeedData(context);
        }

        private void SeedData(StoreContext context)
        {
            context.Database.Migrate();

            if (context.Products.Any()) {return; }

            var products = new List<Product>
        {
            new Product
                {
                    Name = "iPhone 15 Pro",
                    Description = "Apple smartphone with A17 Pro chip and titanium design",
                    price = 1200,
                    PictureUrl = "/images/products/iphone15pro.jpg",
                    Type = "Smartphone",
                    Brand = "Apple",
                    QuantityInStock = 25
                },

                new Product
                {
                    Name = "Samsung Galaxy S24",
                    Description = "Samsung flagship phone with AI features and AMOLED display",
                    price = 1000,
                    PictureUrl = "/images/products/galaxy-s24.jpg",
                    Type = "Smartphone",
                    Brand = "Samsung",
                    QuantityInStock = 30
                },

                new Product
                {
                    Name = "MacBook Pro M3",
                    Description = "Powerful laptop with Apple M3 processor for professionals",
                    price = 2500,
                    PictureUrl = "/images/products/macbook-pro-m3.jpg",
                    Type = "Laptop",
                    Brand = "Apple",
                    QuantityInStock = 15
                },

                new Product
                {
                    Name = "Dell XPS 15",
                    Description = "Premium Windows laptop with high performance hardware",
                    price = 1800,
                    PictureUrl = "/images/products/dell-xps15.jpg",
                    Type = "Laptop",
                    Brand = "Dell",
                    QuantityInStock = 20
                },

                new Product
                {
                    Name = "Sony WH-1000XM5",
                    Description = "Wireless noise cancelling headphones with high quality sound",
                    price = 400,
                    PictureUrl = "/images/products/sony-wh1000xm5.jpg",
                    Type = "Headphone",
                    Brand = "Sony",
                    QuantityInStock = 50
                }
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
