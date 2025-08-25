using MiniShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace MiniShop.Services
{
    public class InMemoryProductRepository : IProductRepository
    {
        private List<Product> products;

        public InMemoryProductRepository()
        {
            products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 50000, ImageUrl ="images/laptop.jpg" },
                new Product { Id = 2, Name = "Mobile", Price = 20000, ImageUrl = "images/mobile5.jpg" },
                new Product { Id = 3, Name = "Headphone", Price = 6000, ImageUrl = "images/headphone.jfif" },
                new Product { Id = 4, Name = "Smartwatch", Price = 8000, ImageUrl = "images/smartwatch.jpg" },
                new Product { Id = 5, Name = "Tablet", Price = 30000, ImageUrl = "images/tablet.jpg" },
                new Product { Id = 6, Name = "Power Bank", Price = 2500, ImageUrl = "images/powerbank.jfif" },
                new Product { Id = 7, Name = "Wireless Mouse", Price = 1200, ImageUrl = "images/wirelessmouse.jpg" },
                new Product { Id = 8, Name = "Keyboard", Price = 1800, ImageUrl = "images/keyboard.jpg" },
                new Product { Id = 9, Name = "Camera", Price =55000, ImageUrl = "images/camera.jpg" },
                new Product { Id = 10, Name = "Microwave Oven", Price = 12000, ImageUrl = "images/microwaveovan.jpg" },
                new Product { Id = 11, Name = "Washing Machine", Price = 35000, ImageUrl = "images/washingmachine.jpg" },
                new Product { Id = 12, Name = "Air Conditioner", Price = 45000, ImageUrl = "images/airconditioner.jpg" },

            };
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public Product Get(int id)   // 👈 Add this
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}