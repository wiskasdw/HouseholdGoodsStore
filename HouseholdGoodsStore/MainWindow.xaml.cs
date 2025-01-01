using System.Collections.Generic;
using System.Windows;

namespace HouseholdGoodsStore
{
    public partial class MainWindow : Window
    {
        public List<Product> Products { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            LoadProducts();
            ProductsDataGrid.ItemsSource = Products;
        }

        private void LoadProducts()
        {
            // Пример заполнения списка товаров
            Products = new List<Product>
            {
                new Product { Id = 1, Name = "Товар 1", Price = 100, Quantity = 10 },
                new Product { Id = 2, Name = "Товар 2", Price = 200, Quantity = 5 },
                new Product { Id = 3, Name = "Товар 3", Price = 300, Quantity = 8 }
            };
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Логика выхода из приложения
            Application.Current.Shutdown();
        }

        private void SaveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Логика сохранения данных
            MessageBox.Show("Данные сохранены!", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Логика показа информации о программе
            MessageBox.Show("Магазин Бытовых Товаров\nВерсия 1.0", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ResetFiltersButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика сброса фильтров
            CategoryFilterComboBox.SelectedIndex = -1;
            SearchTextBox.Clear();
        }

        private void CategoryFilterComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Логика обновления отображаемых товаров на основе выбранной категории
            // Здесь можно вызвать метод для обновления списка товаров
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
