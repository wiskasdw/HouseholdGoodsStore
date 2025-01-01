using System.Collections.Generic;
using System.Collections.ObjectModel;
using HouseholdGoodsStore.Models;
using HouseholdGoodsStore.Services;
using System.Threading.Tasks;

namespace HouseholdGoodsStore.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IDataService _dataService;
        private ObservableCollection<Product> _products;
        private ObservableCollection<Category> _categories;
        private string _searchText;

        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
            LoadData();
        }

        private async void LoadData()
        {
            await LoadProducts();
            await LoadCategories();
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

        public ObservableCollection<Category> Categories
        {
            get => _categories;
            set
            {
                _categories = value;
                OnPropertyChanged();
            }
        }
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                SearchProducts(_searchText);
                OnPropertyChanged();
            }
        }
        private async Task LoadProducts()
        {
            try
            {
                var products = await _dataService.GetProducts();
                Products = new ObservableCollection<Product>(products);
            }
            catch (Exception ex)
            {
                // Обработка исключений
                System.Diagnostics.Debug.WriteLine($"Ошибка загрузки данных: {ex.Message}");
            }
        }
        private async Task LoadCategories()
        {
            try
            {
                var categories = await _dataService.GetCategories();
                Categories = new ObservableCollection<Category>(categories);
            }
            catch (Exception ex)
            {
                // Обработка исключений
                System.Diagnostics.Debug.WriteLine($"Ошибка загрузки категорий: {ex.Message}");
            }
        }
        private void SearchProducts(string searchText)
        {
            //Тут должна быть реализация фильтрации товаров
        }
    }
}