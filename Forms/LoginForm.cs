using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using RestaurantApp;
using RestaurantApp.Forms;
using RestaurantManagement.Data;
using RestaurantManagement.Models;
using BCrypt.Net;

namespace RestaurantManagementApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ApplyCustomStyles(); // Применяю стили
            LoadLogo(); // Загружаю логотип

            // Подписка на события
            btnLogin.Click += new EventHandler(btnLogin_Click);
            linkGoToRegister.LinkClicked += new LinkLabelLinkClickedEventHandler(linkGoToRegister_LinkClicked);
        }

        private void ApplyCustomStyles()
        {
            // Цвета и стили для формы
            Color restaurantBlue = ColorTranslator.FromHtml("#3c6799");
            headerPanel.BackColor = restaurantBlue;
            lblLoginTitle.ForeColor = Color.White;
            lblLoginTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);

            // Настраиваю основные элементы
            contentPanel.BackColor = Color.White;
            txtPassword.PasswordChar = '●'; // Скрываю ввод пароля точками

            // Кнопка "Войти"
            btnLogin.BackColor = restaurantBlue;
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;

            // Ссылка на регистрацию
            linkGoToRegister.LinkColor = restaurantBlue;

            // Настраиваю сообщение об ошибке
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Visible = false;
        }

        private void LoadLogo()
        {
            // Пробую загрузить логотип
            try
            {
                string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Forms", "Resources", "logo.png");
                if (File.Exists(logoPath))
                {
                    pictureBoxLogo.Image = Image.FromFile(logoPath);
                }
            }
            catch (Exception ex)
            {
                // Покажу сообщение об ошибке, если что-то не так
                MessageBox.Show($"Ошибка загрузки логотипа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false; // Сразу скрываю старые ошибки
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Проверяю, что поля заполнены
            if (string.IsNullOrWhiteSpace(username))
            {
                ShowError("Введите имя пользователя.", txtUsername);
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                ShowError("Введите пароль.", txtPassword);
                return;
            }

            try
            {
                using (var context = new RestaurantDbContext())
                {
                    // Ищу пользователя по имени
                    var user = context.Users.Include(u => u.Role).FirstOrDefault(u => u.Username == username);

                    // Проверяю пароль
                    if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                    {
                        RestaurantApp.Program.CurrentUser = user; // Сохраняю пользователя
                        this.Hide();

                        // Открываю главную форму
                        using (MainForm mainForm = new MainForm(user))
                        {
                            mainForm.ShowDialog();

                            if (mainForm.DialogResult == DialogResult.Abort) // Logout
                            {
                                ClearLoginFields();
                                this.Show();
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                    }
                    else
                    {
                        ShowError("Неверное имя пользователя или пароль.", txtPassword);
                    }
                }
            }
            catch (Exception ex)
            {
                // Если что-то пошло не так
                ShowError("Системная ошибка при входе.", null);
                MessageBox.Show($"Ошибка: {ex.Message}", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkGoToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            using (RegisterForm registerForm = new RegisterForm())
            {
                if (registerForm.ShowDialog() == DialogResult.OK && RestaurantApp.Program.CurrentUser != null)
                {
                    // Если регистрация успешна, открываю главную форму
                    using (MainForm mainForm = new MainForm(RestaurantApp.Program.CurrentUser))
                    {
                        mainForm.ShowDialog();

                        if (mainForm.DialogResult == DialogResult.Abort) // Logout
                        {
                            ClearLoginFields();
                            this.Show();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    // Возврат на форму входа
                    ClearLoginFields();
                    this.Show();
                }
            }
        }

        private void ShowError(string message, Control controlToFocus)
        {
            // Показываю текст ошибки
            lblErrorMessage.Text = message;
            lblErrorMessage.Visible = true;
            controlToFocus?.Focus();
        }

        private void ClearLoginFields()
        {
            // Чистим поля
            txtUsername.Clear();
            txtPassword.Clear();
            lblErrorMessage.Visible = false;
            txtUsername.Focus();
        }
    }
}