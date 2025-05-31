using System;
using System.Collections.Generic;

namespace RestaurantManagement.Models
{
    public class Order
    {
        public int Id { get; set; } // Уникальный идентификатор заказа
        public int RestaurantId { get; set; } // ID ресторана
        public Restaurant Restaurant { get; set; } // Связь с рестораном
        public int EmployeeId { get; set; } // ID сотрудника
        public ApplicationUser Employee { get; set; } // Связь с сотрудником
        public DateTime CreatedAt { get; set; } // Дата создания заказа
        public ICollection<OrderDetail> OrderDetails { get; set; } // Детали заказа
        public string Status { get; set; } // Статус заказа 
    }
}