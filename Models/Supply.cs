using System;

namespace RestaurantManagement.Models
{
    public class Supply
    {
        public int Id { get; set; } // Уникальный идентификатор поставки
        public string Name { get; set; } // Наименование товара
        public int Quantity { get; set; } // Количество поставленных товаров
        public decimal Cost { get; set; } // Стоимость поставки
        public int RestaurantId { get; set; } // ID ресторана, для которого заказано
        public Restaurant Restaurant { get; set; } // Связь с рестораном
        public int OrderedById { get; set; } // Сотрудник, который заказал
        public ApplicationUser OrderedBy { get; set; } // Связь с сотрудником
        public DateTime CreatedAt { get; set; } // Дата оформления заказа
    }
}