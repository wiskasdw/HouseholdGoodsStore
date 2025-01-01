using System.Collections.ObjectModel;
using System.Threading.Tasks;
using HouseholdGoodsStore.Models;
using HouseholdGoodsStore.Services; // Убедитесь, что это пространство имен правильное
using HouseholdGoodsStore.ViewModels; // Убедитесь, что это пространство имен правильное

namespace HouseholdGoodsStore.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        private readonly IDataService _dataService;
        private ObservableCollection<Product> _products = new ObservableCollection<Product>(); // Инициализация

        public ProductViewModel(IDataService dataService)
        {
            _dataService = dataService;
            LoadProducts();
        }

        public ObservableCollection<Product> Products
        {
            get => _products;
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }

        private async void LoadProducts()
        {
            var products = await _dataService.GetProducts();
            Products = new ObservableCollection<Product>(products);
        }
    }
}
