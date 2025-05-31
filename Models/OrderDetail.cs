using System;


namespace RestaurantManagement.Models
{
    public class OrderDetail
    {
        public int Id { get; set; } // Id
        public int OrderId { get; set; } // ID заказа
        public Order Order { get; set; } // Связь с заказом
        public int MenuItemId { get; set; } // ID блюда в заказе
        public MenuItem MenuItem { get; set; } // Связь с блюдом
        public int Quantity { get; set; } // Количество блюда в заказе
        public decimal TotalPrice { get; set; } // Общая стоимость (цена * количество)
    }
}
