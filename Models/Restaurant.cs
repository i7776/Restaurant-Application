using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название ресторана обязательно.")]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Адрес ресторана обязателен.")]
        [MaxLength(500)]
        public string Address { get; set; }

        [MaxLength(20)]
        public string PhoneNumber { get; set; } // Телефон самого ресторана

        [MaxLength(100)]
        [EmailAddress(ErrorMessage = "Некорректный формат Email.")]
        public string ContactEmail { get; set; } // Контактный email ресторана

        public string Description { get; set; } // Описание

        [MaxLength(100)]
        public string CuisineType { get; set; } // Тип кухни

        public string OperatingHours { get; set; } // Часы работы

        public bool IsActive { get; set; } = true; // по умолчанию ресторан активен

        // Связь с владельцем
        [Required]
        public int OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public virtual ApplicationUser Owner { get; set; } 

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; 

        // Связи с другими 
        public virtual ICollection<ApplicationUser> Employees { get; set; } = new List<ApplicationUser>();
        public virtual ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual ICollection<Supply> Supplies { get; set; } = new List<Supply>();
    }
}