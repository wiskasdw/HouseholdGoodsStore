using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseholdGoodsStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Добавьте другие свойства, если это необходимо.
    }
}