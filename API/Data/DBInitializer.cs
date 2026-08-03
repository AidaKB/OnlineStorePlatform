using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DBInitializer
    {
        public static void InitDb(WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<StoreContext>() ?? throw new InvalidOperationException("Failed to retrieve store context");

            SeedData(context);
        }

        private static void SeedData(StoreContext context)
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
                    Description = "Samsung flagship smartphone with Galaxy AI",
                    price = 1000,
                    PictureUrl = "/images/products/galaxy-s24.jpg",
                    Type = "Smartphone",
                    Brand = "Samsung",
                    QuantityInStock = 30
                },

                new Product
                {
                    Name = "Google Pixel 9",
                    Description = "Android smartphone with advanced AI camera features",
                    price = 900,
                    PictureUrl = "/images/products/pixel9.jpg",
                    Type = "Smartphone",
                    Brand = "Google",
                    QuantityInStock = 18
                },

                new Product
                {
                    Name = "Xiaomi 14 Ultra",
                    Description = "Flagship smartphone with Leica camera system",
                    price = 950,
                    PictureUrl = "/images/products/xiaomi14ultra.jpg",
                    Type = "Smartphone",
                    Brand = "Xiaomi",
                    QuantityInStock = 22
                },

                new Product
                {
                    Name = "MacBook Pro M3",
                    Description = "Professional laptop powered by Apple M3 chip",
                    price = 2500,
                    PictureUrl = "/images/products/macbookpro.jpg",
                    Type = "Laptop",
                    Brand = "Apple",
                    QuantityInStock = 15
                },

                new Product
                {
                    Name = "Dell XPS 15",
                    Description = "Premium Windows laptop with Intel Core Ultra processor",
                    price = 1800,
                    PictureUrl = "/images/products/dellxps15.jpg",
                    Type = "Laptop",
                    Brand = "Dell",
                    QuantityInStock = 20
                },

                new Product
                {
                    Name = "Lenovo ThinkPad X1 Carbon",
                    Description = "Lightweight business laptop with excellent keyboard",
                    price = 1700,
                    PictureUrl = "/images/products/thinkpadx1.jpg",
                    Type = "Laptop",
                    Brand = "Lenovo",
                    QuantityInStock = 16
                },

                new Product
                {
                    Name = "ASUS ROG Zephyrus G16",
                    Description = "Gaming laptop with RTX graphics",
                    price = 2200,
                    PictureUrl = "/images/products/rogg16.jpg",
                    Type = "Laptop",
                    Brand = "ASUS",
                    QuantityInStock = 10
                },

                new Product
                {
                    Name = "Sony WH-1000XM5",
                    Description = "Wireless noise cancelling headphones",
                    price = 400,
                    PictureUrl = "/images/products/sonyxm5.jpg",
                    Type = "Headphone",
                    Brand = "Sony",
                    QuantityInStock = 50
                },

                new Product
                {
                    Name = "AirPods Pro 2",
                    Description = "Apple wireless earbuds with active noise cancellation",
                    price = 250,
                    PictureUrl = "/images/products/airpodspro2.jpg",
                    Type = "Earbuds",
                    Brand = "Apple",
                    QuantityInStock = 60
                },

                new Product
                {
                    Name = "Galaxy Buds3 Pro",
                    Description = "Samsung premium wireless earbuds",
                    price = 220,
                    PictureUrl = "/images/products/galaxybuds3.jpg",
                    Type = "Earbuds",
                    Brand = "Samsung",
                    QuantityInStock = 45
                },

                new Product
                {
                    Name = "Apple Watch Series 10",
                    Description = "Smartwatch with advanced health tracking",
                    price = 500,
                    PictureUrl = "/images/products/applewatch10.jpg",
                    Type = "Smartwatch",
                    Brand = "Apple",
                    QuantityInStock = 28
                },

                new Product
                {
                    Name = "Samsung Galaxy Watch Ultra",
                    Description = "Premium smartwatch for fitness and outdoor activities",
                    price = 550,
                    PictureUrl = "/images/products/galaxywatchultra.jpg",
                    Type = "Smartwatch",
                    Brand = "Samsung",
                    QuantityInStock = 18
                },

                new Product
                {
                    Name = "iPad Pro 13",
                    Description = "Apple tablet with M4 chip",
                    price = 1400,
                    PictureUrl = "/images/products/ipadpro13.jpg",
                    Type = "Tablet",
                    Brand = "Apple",
                    QuantityInStock = 24
                },

                new Product
                {
                    Name = "Samsung Galaxy Tab S10",
                    Description = "Android tablet with AMOLED display",
                    price = 900,
                    PictureUrl = "/images/products/tabs10.jpg",
                    Type = "Tablet",
                    Brand = "Samsung",
                    QuantityInStock = 21
                },

                new Product
                {
                    Name = "LG UltraFine 32\"",
                    Description = "32-inch 4K IPS monitor",
                    price = 650,
                    PictureUrl = "/images/products/lg32.jpg",
                    Type = "Monitor",
                    Brand = "LG",
                    QuantityInStock = 17
                },

                new Product
                {
                    Name = "Dell UltraSharp U2724D",
                    Description = "27-inch QHD monitor for professionals",
                    price = 480,
                    PictureUrl = "/images/products/u2724d.jpg",
                    Type = "Monitor",
                    Brand = "Dell",
                    QuantityInStock = 19
                },

                new Product
                {
                    Name = "Logitech MX Master 3S",
                    Description = "Premium wireless productivity mouse",
                    price = 110,
                    PictureUrl = "/images/products/mxmaster3s.jpg",
                    Type = "Mouse",
                    Brand = "Logitech",
                    QuantityInStock = 75
                },

                new Product
                {
                    Name = "Logitech MX Keys S",
                    Description = "Wireless backlit keyboard for productivity",
                    price = 120,
                    PictureUrl = "/images/products/mxkeys.jpg",
                    Type = "Keyboard",
                    Brand = "Logitech",
                    QuantityInStock = 55
                },

                new Product
                {
                    Name = "Razer BlackWidow V4",
                    Description = "Mechanical gaming keyboard with RGB lighting",
                    price = 180,
                    PictureUrl = "/images/products/blackwidowv4.jpg",
                    Type = "Keyboard",
                    Brand = "Razer",
                    QuantityInStock = 35
                },

                new Product
                {
                    Name = "PlayStation 5 Slim",
                    Description = "Sony next-generation gaming console",
                    price = 550,
                    PictureUrl = "/images/products/ps5slim.jpg",
                    Type = "Gaming Console",
                    Brand = "Sony",
                    QuantityInStock = 12
                },

                new Product
                {
                    Name = "Xbox Series X",
                    Description = "Microsoft gaming console with 4K support",
                    price = 550,
                    PictureUrl = "/images/products/xboxseriesx.jpg",
                    Type = "Gaming Console",
                    Brand = "Microsoft",
                    QuantityInStock = 14
                },

                new Product
                {
                    Name = "Nintendo Switch OLED",
                    Description = "Portable gaming console with OLED display",
                    price = 350,
                    PictureUrl = "/images/products/switcholed.jpg",
                    Type = "Gaming Console",
                    Brand = "Nintendo",
                    QuantityInStock = 26
                },

                new Product
                {
                    Name = "Canon EOS R8",
                    Description = "Full-frame mirrorless camera",
                    price = 1700,
                    PictureUrl = "/images/products/eosr8.jpg",
                    Type = "Camera",
                    Brand = "Canon",
                    QuantityInStock = 8
                },

                new Product
                {
                    Name = "GoPro Hero 13",
                    Description = "Action camera for adventure recording",
                    price = 450,
                    PictureUrl = "/images/products/gopro13.jpg",
                    Type = "Camera",
                    Brand = "GoPro",
                    QuantityInStock = 20
                }
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
