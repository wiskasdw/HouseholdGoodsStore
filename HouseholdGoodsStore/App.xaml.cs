using System.Windows;
using WarehouseManagementSystem.Data;

namespace WarehouseManagementSystem
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var dbContext = new ApplicationDbContext(); // Инициализация базы данных
        }
    }
}
