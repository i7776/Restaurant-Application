using System.Collections.Generic;

namespace RestaurantManagement.Models
{
    public class Role
    {
        public int Id { get; set; } // Уникальный идентификатор роли
        public string Name { get; set; } // Название
        public string Permissions { get; set; } // строка разрешений роли
        public ICollection<ApplicationUser> Users { get; set; } // Список пользователей, с этой ролью
    }
}