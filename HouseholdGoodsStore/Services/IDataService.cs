using System.Collections.Generic;
using System.Threading.Tasks;
using HouseholdGoodsStore.Models;

namespace HouseholdGoodsStore.Services
{
    public interface IDataService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<IEnumerable<Category>> GetCategories();
    }
}
