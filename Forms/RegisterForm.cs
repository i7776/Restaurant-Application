using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Data;
using RestaurantManagement.Models;

namespace RestaurantManagementApp.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly RestaurantDbContext _dbContext; // Контекст базы данных
        private readonly ApplicationUser? _callingUser; // Пользователь, открывший форму
        private Label lblRestaurant; // Метка для ресторана
        private ComboBox cmbRestaurant; // Выпадающий список ресторанов
        private bool _isLoadingData = false; // Флаг для проверки загрузки данных

        public RegisterForm(ApplicationUser? caller = null)
        {
            InitializeComponent();
            _callingUser = caller; // Сохраняем информацию о пользователе, открывшем форму
            _dbContext = new RestaurantDbContext(); // Создаем контекст базы

            ApplyCustomStyles(); // Стили оформления формы
            LoadLogo(); // Загружаем логотип
            InitializeRestaurantSelectorControls(); // Добавляем элементы для выбора ресторана
            this.Load += RegisterForm_Load; // Загрузка данных при открытии формы
        }

        private void ApplyCustomStyles()
        {
            // Настраиваем цвета и шрифты для элементов формы
            Color restaurantBlue = ColorTranslator.FromHtml("#3c6799");

            headerPanel.BackColor = restaurantBlue;
            lblRegisterTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            contentPanel.BackColor = Color.White;

            // Стили для меток
            foreach (var label in contentPanel.Controls.OfType<Label>().Where(l => l.Name.StartsWith("lbl") && l != lblErrorMessage))
            {
                label.Font = new Font("Segoe UI", 9F);
            }

            // Стили для текстовых полей
            foreach (var textBox in contentPanel.Controls.OfType<TextBox>())
            {
                textBox.Font = new Font("Segoe UI", 10.2F);
                if (textBox.Name.Contains("Password")) textBox.PasswordChar = '●'; // Звездочки для пароля
            }

            // Настройки кнопки
            btnRegister.BackColor = restaurantBlue;
            btnRegister.ForeColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;

            // Стили для ссылки на логин
            linkGoToLogin.LinkColor = restaurantBlue;
            lblErrorMessage.ForeColor = Color.Red; // Красный цвет для ошибок
            lblErrorMessage.Visible = false; // Скрываю сообщение об ошибке
        }

        private void LoadLogo()
        {
            try
            {
                // Загружаем логотип из папки Resources
                string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "logo.png");
                if (File.Exists(logoPath)) pictureBoxLogo.Image = Image.FromFile(logoPath);
            }
            catch (Exception ex)
            {
                // Показываем ошибку, если логотип не удалось загрузить
                MessageBox.Show($"Ошибка загрузки логотипа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeRestaurantSelectorControls()
        {
            // Добавляем элементы для выбора ресторана
            lblRestaurant = new Label
            {
                Name = "lblSelectRestaurant",
                Text = "Ресторан:",
                Location = new Point(txtPhoneNumber.Location.X, txtPhoneNumber.Bottom + 10),
                AutoSize = true,
                Visible = false // Скрыто по умолчанию
            };

            cmbRestaurant = new ComboBox
            {
                Name = "cmbSelectRestaurant",
                Location = new Point(lblRestaurant.Right + 5, lblRestaurant.Top),
                Size = new Size(txtFullName.Width, 25),
                Visible = false // Скрыто по умолчанию
            };

            // Добавляем контролы на панель контента
            contentPanel.Controls.Add(lblRestaurant);
            contentPanel.Controls.Add(cmbRestaurant);
        }

        private async void RegisterForm_Load(object sender, EventArgs e)
        {
            // Загружаю роли и рестораны при загрузке формы
            await LoadRolesAndRestaurantsAsync();
        }

        private async Task LoadRolesAndRestaurantsAsync()
        {
            if (_isLoadingData) return; // Если уже идет загрузка, выхожу

            _isLoadingData = true;
            btnRegister.Enabled = false; // Блокирую кнопку на время загрузки данных

            try
            {
                List<Role> availableRoles = new List<Role>();

                // Проверка роли вызывающего пользователя
                if (_callingUser != null)
                {
                    var effectiveUser = await _dbContext.Users
                        .Include(u => u.Role)
                        .FirstOrDefaultAsync(u => u.Id == _callingUser.Id);

                    // Если пользователь владелец, активирую выбор ресторана
                    if (effectiveUser?.Role?.Name == "Owner" || effectiveUser?.Role?.Name == "Владелец")
                    {
                        lblRestaurant.Visible = true;
                        cmbRestaurant.Visible = true;
                        cmbRestaurant.DataSource = effectiveUser.OwnedRestaurants?.ToList();
                        cmbRestaurant.DisplayMember = "Name";
                        cmbRestaurant.ValueMember = "Id";
                    }
                }

                // Загружаю роли из базы
                availableRoles = await _dbContext.Roles.OrderBy(r => r.Name).ToListAsync();
                cmbRole.DataSource = availableRoles;
                cmbRole.DisplayMember = "Name"; // Название роли
                cmbRole.ValueMember = "Id"; // ID роли
                btnRegister.Enabled = true; // Разблокирую кнопку регистрации
            }
            catch (Exception ex)
            {
                // Показываю ошибку, если загрузка данных не удалась
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isLoadingData = false; // Сбрасываю флаг загрузки
            }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            // Логика регистрации пользователя

            lblErrorMessage.Visible = false; // Скрываю ошибку перед началом проверки

            // Считываю данные из формы
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Проверка ввода
            if (string.IsNullOrWhiteSpace(username)) { ShowError("Введите логин.", txtUsername); return; }
            if (password != confirmPassword) { ShowError("Пароли не совпадают.", txtConfirmPassword); return; }

            try
            {
                // Проверяю уникальность логина
                if (await _dbContext.Users.AnyAsync(u => u.Username == username))
                {
                    ShowError("Пользователь с таким логином уже существует.", txtUsername);
                    return;
                }

                // Хеширую пароль и создаю нового пользователя
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                var newUser = new ApplicationUser
                {
                    Username = username,
                    PasswordHash = hashedPassword,
                    CreatedAt = DateTime.UtcNow
                };

                _dbContext.Users.Add(newUser); // Добавляю пользователя в базу
                await _dbContext.SaveChangesAsync();

                MessageBox.Show("Регистрация завершена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Успешная регистрация
                this.Close();
            }
            catch (Exception ex)
            {
                // Показываю ошибку, если произошел сбой
                MessageBox.Show($"Ошибка регистрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowError(string message, Control? controlToFocus)
        {
            // Показываю ошибку и фокусируюся на проблемном элементе
            lblErrorMessage.Text = message;
            lblErrorMessage.Visible = true;
            controlToFocus?.Focus();
        }

        private void linkGoToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Закрываю форму и возвращаюсь к логину
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _dbContext?.Dispose(); // Освобождаю ресурсы контекста
            base.OnFormClosed(e);
        }
    }
}