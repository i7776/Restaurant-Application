using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.Models
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; } 
        public int? RestaurantId { get; set; } // ID ресторана (если пользователь сотрудник)

        [ForeignKey("RestaurantId")] // явно указываем ForeignKey
        public virtual Restaurant Restaurant { get; set; } // связь с рестораном, где работает (сделал virtual)

        public DateTime CreatedAt { get; set; }

        // коллекция ресторанов, которыми владеет этот пользователь
        public virtual ICollection<Restaurant> OwnedRestaurants { get; set; } = new List<Restaurant>(); // <--- ДОБАВЛЕНО
    }
}