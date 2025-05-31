using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore; 
using RestaurantApp;
using RestaurantApp.Forms;
using RestaurantManagement.Data;
using RestaurantManagement.Models;
using RestaurantManagementApp.Forms;

namespace RestaurantApp.Forms // Убедитесь, что namespace правильный
{
    public partial class UserManagementForm : Form
    {
        private readonly RestaurantDbContext _context;
        private readonly ApplicationUser _actorUser;
        private bool _isDataLoading = false; // Флаг для отслеживания состояния загрузки

        public UserManagementForm(ApplicationUser actor)
        {
            InitializeComponent();
            _context = new RestaurantDbContext();
            _actorUser = actor;
            // ApplyCustomStyles(); // Если есть

            // Подписка на Load должна быть в Designer.cs, если нет - добавить здесь.
            // this.Load += UserManagementForm_Load;
        }

        // Если есть метод для кастомных стилей
        /*
        private void ApplyCustomStyles()
        {
            // ...
        }
        */

        // Обработчик события загрузки формы
        private async void UserManagementForm_Load(object sender, EventArgs e)
        {
            await LoadInitialDataAsync();
        }

        // Обертка для начальной загрузки данных с управлением UI
        private async Task LoadInitialDataAsync()
        {
            if (_isDataLoading) return; // Предотвращаем повторный вход, если уже грузится

            _isDataLoading = true;
            SetControlsEnabled(false); // Деактивируем кнопки

            try
            {
                await LoadUsersAsync(); // Вызываем основной метод загрузки пользователей
            }
            catch (Exception ex)
            {
                // Этот catch обработает ошибки именно из LoadUsersAsync при первоначальной загрузке
                MessageBox.Show($"Критическая ошибка при начальной загрузке данных: {ex.Message}\n{ex.StackTrace}", "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetControlsEnabled(true); // Активируем кнопки обратно
                _isDataLoading = false;
            }
        }

        // Метод для установки состояния Enabled для кнопок управления
        private void SetControlsEnabled(bool enabled)
        {
            // Предполагается, что у вас есть эти кнопки. Добавьте или удалите по необходимости.
            if (btnAddUser != null) btnAddUser.Enabled = enabled;
            // if (btnEditUser != null) btnEditUser.Enabled = enabled;
            // if (btnDeleteUser != null) btnDeleteUser.Enabled = enabled;
            // ... другие элементы управления, которые должны быть заблокированы ...
        }

        // Основной метод загрузки/обновления списка пользователей
        // (это ваш существующий метод LoadUsersAsync, он не должен сам менять Enabled кнопок)
        private async Task LoadUsersAsync()
        {
            try
            {
                IQueryable<ApplicationUser> query = _context.Users.Include(u => u.Role).Include(u => u.Restaurant);

                if (_actorUser == null)
                {
                    MessageBox.Show("Ошибка: не определен текущий пользователь, открывший форму управления.", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_actorUser.Role == null && _actorUser.RoleId > 0)
                {
                    _actorUser.Role = await _context.Roles.FindAsync(_actorUser.RoleId);
                }

                if (_actorUser.Role == null)
                {
                    MessageBox.Show("Ошибка: не удалось определить роль текущего пользователя. Данные не могут быть отфильтрованы.", "Ошибка роли", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_actorUser.Role.Name == "Owner" || _actorUser.Role.Name == "Владелец")
                {
                    if (_actorUser.OwnedRestaurants == null || !_actorUser.OwnedRestaurants.Any())
                    {
                        await _context.Entry(_actorUser).Collection(u => u.OwnedRestaurants).LoadAsync();
                    }

                    var ownedRestaurantIds = _actorUser.OwnedRestaurants?.Select(r => r.Id).ToList() ?? new System.Collections.Generic.List<int>();

                    if (ownedRestaurantIds.Any())
                    {
                        query = query.Where(u => u.RestaurantId.HasValue &&
                                                 ownedRestaurantIds.Contains(u.RestaurantId.Value) &&
                                                 u.Role.Name != "Owner" && u.Role.Name != "Владелец" &&
                                                 u.Role.Name != "Admin" && u.Role.Name != "Администратор");
                    }
                    else
                    {
                        query = query.Where(u => false);
                    }
                }
                else if (!(_actorUser.Role.Name == "Admin" || _actorUser.Role.Name == "Администратор"))
                {
                    if (_actorUser.RestaurantId.HasValue)
                    {
                        query = query.Where(u => u.RestaurantId == _actorUser.RestaurantId &&
                                                 u.Role.Name != "Owner" && u.Role.Name != "Владелец" &&
                                                 u.Role.Name != "Admin" && u.Role.Name != "Администратор");
                    }
                    else
                    {
                        query = query.Where(u => false);
                    }
                }

                var users = await query
                    .Select(u => new
                    {
                        u.Id,
                        u.Username,
                        u.FullName,
                        u.Email,
                        u.PhoneNumber,
                        RoleName = u.Role != null ? u.Role.Name : "Роль не назначена",
                        RestaurantName = u.Restaurant != null ? u.Restaurant.Name : "N/A",
                        u.CreatedAt
                    })
                    .ToListAsync();

                dgvUsers.DataSource = users;
                CustomizeDataGridViewColumns();
            }
            catch (Exception ex)
            {
                // Этот catch теперь будет ловить ошибки, если LoadUsersAsync вызван не из LoadInitialDataAsync
                // (например, после закрытия RegisterForm). LoadInitialDataAsync имеет свой try-catch.
                MessageBox.Show($"Ошибка загрузки списка пользователей: {ex.Message}\n{ex.StackTrace}", "Ошибка данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Можно решить, нужно ли здесь повторно выбрасывать исключение, чтобы внешний обработчик его поймал,
                // или достаточно показать MessageBox.
                // throw; // Если нужно, чтобы LoadInitialDataAsync тоже поймал ошибку из этого блока.
            }
        }

        private void CustomizeDataGridViewColumns()
        {
            // ... ваш код настройки колонок ...
            if (dgvUsers.Columns["Id"] != null) dgvUsers.Columns["Id"].HeaderText = "ID";
            if (dgvUsers.Columns["Username"] != null) dgvUsers.Columns["Username"].HeaderText = "Логин";
            if (dgvUsers.Columns["FullName"] != null) dgvUsers.Columns["FullName"].HeaderText = "ФИО";
            if (dgvUsers.Columns["Email"] != null) dgvUsers.Columns["Email"].HeaderText = "Email";
            if (dgvUsers.Columns["PhoneNumber"] != null) dgvUsers.Columns["PhoneNumber"].HeaderText = "Телефон";
            if (dgvUsers.Columns["RoleName"] != null) dgvUsers.Columns["RoleName"].HeaderText = "Роль";
            if (dgvUsers.Columns["RestaurantName"] != null)
            {
                dgvUsers.Columns["RestaurantName"].HeaderText = "Ресторан";
            }
            if (dgvUsers.Columns["CreatedAt"] != null) dgvUsers.Columns["CreatedAt"].HeaderText = "Дата создания";
        }

        private async void btnAddUser_Click(object sender, EventArgs e)
        {
            if (_isDataLoading)
            {
                MessageBox.Show("Пожалуйста, подождите, данные загружаются.", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ИЗМЕНЕНИЕ: Больше не передаем _context
            // RegisterForm теперь будет создавать свой собственный DbContext
            using (RegisterForm registerForm = new RegisterForm(_actorUser))
            {
                DialogResult result = registerForm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    // Обновляем список пользователей в UserManagementForm, используя ЕЁ _context
                    await LoadInitialDataAsync();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context?.Dispose();
            base.OnFormClosed(e);
        }
    }
}