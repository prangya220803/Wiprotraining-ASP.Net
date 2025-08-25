using MiniShop.Models;
using System.Collections.Generic;

namespace MiniShop.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product Get(int id);
    }
}