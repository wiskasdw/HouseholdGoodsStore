using System;
using System.Data.SQLite;

namespace WarehouseManagementSystem.Data
{
    public class ApplicationDbContext
    {
        private const string DatabaseFile = "HouseholdGoodsStore.db";

        public ApplicationDbContext()
        {
            CreateDatabase();
        }

        private void CreateDatabase()
        {
            // Создание базы данных
            SQLiteConnection.CreateFile(DatabaseFile);

            using (var connection = new SQLiteConnection($"Data Source={DatabaseFile};Version=3;"))
            {
                connection.Open();

                // Создание таблицы Products
                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Products (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Price REAL NOT NULL,
                    Quantity INTEGER NOT NULL
                );";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("База данных и таблица созданы.");
        }
    }
}
