using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace RestaurantManagement.Data
{
    public class RestaurantDbContext : DbContext
    {
        // DbSet для каждой модели
        public DbSet<ApplicationUser> Users { get; set; } // таблица пользователей
        public DbSet<MenuItem> MenuItems { get; set; } // таблица блюд
        public DbSet<Order> Orders { get; set; } // таблица заказов
        public DbSet<OrderDetail> OrderDetails { get; set; } // таблица деталей заказов
        public DbSet<Restaurant> Restaurants { get; set; } // таблица ресторанов
        public DbSet<Role> Roles { get; set; } // ттаблица ролей
        public DbSet<Supply> Supplies { get; set; } // таблица поставок

        // подключения к базе данных
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=lolita-pc;Database=RestaurantDB_1;Trusted_Connection=True;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // связи между моделями
            base.OnModelCreating(modelBuilder);

            // Рест <-> Владелец (юзер)
            modelBuilder.Entity<Restaurant>()
                .HasOne(r => r.Owner)
                .WithMany(u => u.OwnedRestaurants) // ага, тут OwnedRestaurants
                .HasForeignKey(r => r.OwnerId)
                .OnDelete(DeleteBehavior.Restrict); // не удалять владельца, если есть ресты

            // Юзер <-> Роль
            modelBuilder.Entity<ApplicationUser>()
                .HasOne(user => user.Role)
                .WithMany(role => role.Users)
                .HasForeignKey(user => user.RoleId);

            // Сотрудник (юзер) <-> Рест (где работает)
            modelBuilder.Entity<ApplicationUser>()
                .HasOne(user => user.Restaurant) // Связь с рестом
                .WithMany(restaurant => restaurant.Employees) // много сотрудников в ресте
                .HasForeignKey(user => user.RestaurantId)
                .IsRequired(false) // RestaurantId может быть null (владельцы, админы)
                .OnDelete(DeleteBehavior.SetNull); // удалили рест -> RestaurantId = null у сотрудника

            // Уникальные поля юзера
            modelBuilder.Entity<ApplicationUser>()
                .HasIndex(u => u.Username)
                .IsUnique(); // Логин

            modelBuilder.Entity<ApplicationUser>()
                .HasIndex(u => u.Email)
                .IsUnique(); // Мыло

            // Уникальное имя роли
            modelBuilder.Entity<Role>()
                .HasIndex(r => r.Name)
                .IsUnique();

            // Рест <-> Блюда
            modelBuilder.Entity<MenuItem>()
                .HasOne(menuItem => menuItem.Restaurant)
                .WithMany(restaurant => restaurant.MenuItems)
                .HasForeignKey(menuItem => menuItem.RestaurantId);

            // Заказ <-> Детали
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(order => order.OrderDetails)
                .HasForeignKey(od => od.OrderId);

            // Деталь <-> Блюдо
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.MenuItem)
                .WithMany() // со стороны блюда списка деталей нет
                .HasForeignKey(od => od.MenuItemId);

            // Рест <-> Заказы
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Restaurant) // Заказ к ресторану
                .WithMany(r => r.Orders)   // Много заказов 
                .HasForeignKey(o => o.RestaurantId) 
                .OnDelete(DeleteBehavior.Restrict); 

            // Рест <-> Поставки
            modelBuilder.Entity<Supply>()
                .HasOne(supply => supply.Restaurant)
                .WithMany(restaurant => restaurant.Supplies)
                .HasForeignKey(supply => supply.RestaurantId);

            // Поставка <-> Заказчик (юзер)
            modelBuilder.Entity<Supply>()
                .HasOne(supply => supply.OrderedBy)
                .WithMany() // у юзера списка поставок нет
                .HasForeignKey(supply => supply.OrderedById);


            // Цена блюда
            modelBuilder.Entity<MenuItem>()
                .Property(m => m.Price)
                .HasPrecision(18, 2);

            // Сумма в детали заказа
            modelBuilder.Entity<OrderDetail>()
                .Property(od => od.TotalPrice)
                .HasPrecision(18, 2);

            // Цена поставки
            modelBuilder.Entity<Supply>()
                .Property(s => s.Cost)
                .HasPrecision(18, 2);
        }
    }
}