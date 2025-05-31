using System;

namespace RestaurantManagement.Models
{
    public class MenuItem
    {
        public int Id { get; set; } // Уникальный идентификатор блюда
        public string Name { get; set; } // Название блюда
        public string Description { get; set; } // Описание блюда
        public decimal Price { get; set; } // Цена блюда
        public int RestaurantId { get; set; } // ID ресторана, которому принадлежит блюдо
        public Restaurant Restaurant { get; set; } // Связь с рестораном
        public DateTime CreatedAt { get; set; } // Дата добавления блюда в меню
    }
}