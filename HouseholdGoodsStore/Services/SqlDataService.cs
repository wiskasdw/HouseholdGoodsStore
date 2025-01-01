using System.Collections.Generic;
using System.Threading.Tasks;
using HouseholdGoodsStore.Models;

namespace HouseholdGoodsStore.Services
{
    public class SqlDataService : IDataService
    {
        public async Task<IEnumerable<Product>> GetProducts()
        {
            // Здесь должна быть логика получения продуктов из базы данных
            // Например, возвращаем заглушку:
            return await Task.FromResult(new List<Product>
            {
                new Product { Id = 1, Name = "Продукт 1", Price = 10.0m },
                new Product { Id = 2, Name = "Продукт 2", Price = 20.0m }
            });
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            // Здесь должна быть логика получения категорий из базы данных
            // Например, возвращаем заглушку:
            return await Task.FromResult(new List<Category>
            {
                new Category { Id = 1, Name = "Категория 1" },
                new Category { Id = 2, Name = "Категория 2" }
            });
        }
    }
}
