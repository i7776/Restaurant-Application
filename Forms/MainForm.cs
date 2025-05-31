using RestaurantManagement.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantApp.Forms
{
    public partial class MainForm : Form
    {
        private ApplicationUser _currentUser;
        private Color _restaurantBlue = ColorTranslator.FromHtml("#3c6799");
        private Color _lightBackground = ColorTranslator.FromHtml("#f8f9fa"); // Очень светлый фон
        private Color _darkText = Color.FromArgb(50, 50, 50); // Цвет для текста
        private Color _menuHighlight = ColorTranslator.FromHtml("#5c87b9"); // Цвет наведения на меню

        public MainForm(ApplicationUser user)
        {
            InitializeComponent();
            _currentUser = user; // Сохраняю текущего пользователя
            ApplyCustomStylesMainForm(); // Настраиваю стили для главной формы
        }

        private void ApplyCustomStylesMainForm()
        {
            this.BackColor = _lightBackground; // Задаю фон

            // Настраиваю MenuStrip
            if (mainMenuStrip != null)
            {
                mainMenuStrip.BackColor = _restaurantBlue;
                mainMenuStrip.ForeColor = Color.White;
                mainMenuStrip.Font = new Font("Segoe UI", 9.5F);

                foreach (ToolStripMenuItem topLevelItem in mainMenuStrip.Items)
                {
                    topLevelItem.ForeColor = Color.White;

                    // Настройка выпадающих пунктов меню
                    foreach (ToolStripItem dropDownItem in topLevelItem.DropDownItems)
                    {
                        if (dropDownItem is ToolStripMenuItem menuItem)
                        {
                            menuItem.BackColor = Color.White;
                            menuItem.ForeColor = _darkText;
                        }
                    }
                }
            }

            // Настраиваю Header Panel
            if (headerPanel != null)
            {
                headerPanel.BackColor = Color.White;

                // Граница снизу для стиля
                headerPanel.Paint += (s, e) =>
                {
                    ControlPaint.DrawBorder(e.Graphics, headerPanel.ClientRectangle,
                        _lightBackground, 0, ButtonBorderStyle.None,
                        _lightBackground, 0, ButtonBorderStyle.None,
                        _lightBackground, 0, ButtonBorderStyle.None,
                        Color.LightGray, 1, ButtonBorderStyle.Solid); // Только снизу
                };
            }

            // Приветственное сообщение
            if (lblWelcomeMessage != null)
            {
                lblWelcomeMessage.ForeColor = _restaurantBlue;
            }

            // Основная область контента
            if (mainContentPanel != null)
            {
                mainContentPanel.BackColor = _lightBackground;
            }

            // Настраиваю StatusStrip
            if (mainStatusStrip != null)
            {
                mainStatusStrip.BackColor = _restaurantBlue;
                mainStatusStrip.ForeColor = Color.White;
                mainStatusStrip.Font = new Font("Segoe UI", 9F);

                if (currentUserStatusLabel != null) currentUserStatusLabel.ForeColor = Color.White;
                if (dateTimeStatusLabel != null) dateTimeStatusLabel.ForeColor = Color.White;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                // Заполнение приветственного сообщения и статуса
                if (lblWelcomeMessage != null)
                {
                    lblWelcomeMessage.Text = $"Добро пожаловать, {_currentUser.FullName ?? _currentUser.Username}!";
                }
                if (currentUserStatusLabel != null)
                {
                    currentUserStatusLabel.Text = $"Пользователь: {_currentUser.Username} (Роль: {_currentUser.Role?.Name ?? "Не определена"})";
                }

                // Запускаю таймер для обновления времени
                statusTimer_Tick(null, null);

                SetupMenuBasedOnRole(); // Показываю меню, соответствующее роли
                LoadDefaultContentForRole(); // Загружаю контент по умолчанию
            }
            else
            {
                // Если пользователь не найден, показываю ошибку
                MessageBox.Show("Ошибка: информация о пользователе не найдена. Пожалуйста, войдите снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void SetupMenuBasedOnRole()
        {
            // Скрываю меню, в зависимости от роли
            if (managementToolStripMenuItem != null) managementToolStripMenuItem.Visible = false;
            if (operationsToolStripMenuItem != null) operationsToolStripMenuItem.Visible = false;

            if (_currentUser?.Role == null) return;
            string roleName = _currentUser.Role.Name;

            // Настройки для роли "Owner" или "Admin"
            if (roleName == "Owner" || roleName == "Admin" || roleName == "Владелец" || roleName == "Администратор")
            {
                if (managementToolStripMenuItem != null) managementToolStripMenuItem.Visible = true;
                if (operationsToolStripMenuItem != null) operationsToolStripMenuItem.Visible = true;
            }

            // Настройки для роли "Waiter"
            if (roleName == "Waiter" || roleName == "Официант")
            {
                if (operationsToolStripMenuItem != null) operationsToolStripMenuItem.Visible = true;
            }
        }

        private void LoadDefaultContentForRole()
        {
            // Загружаю контент на основе роли
            if (_currentUser?.Role?.Name == "Owner" || _currentUser?.Role?.Name == "Admin" || _currentUser?.Role?.Name == "Владелец" || _currentUser?.Role?.Name == "Администратор")
            {
                LoadUserControlWithPlaceholder("Панель администратора / Обзор");
            }
            else if (_currentUser?.Role?.Name == "Waiter" || _currentUser?.Role?.Name == "Официант")
            {
                LoadUserControlWithPlaceholder("Карта столов / Новые заказы");
            }
            else
            {
                LoadUserControlWithPlaceholder("Главная страница");
            }
        }

        private void LoadUserControlWithPlaceholder(string message, UserControl controlToLoad = null)
        {
            // Очистка контента и добавление нового
            mainContentPanel.Controls.Clear();
            if (controlToLoad != null)
            {
                controlToLoad.Dock = DockStyle.Fill;
                mainContentPanel.Controls.Add(controlToLoad);
            }
            else
            {
                Label placeholder = new Label
                {
                    Text = message,
                    Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                    ForeColor = Color.Gray,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };
                mainContentPanel.Controls.Add(placeholder);
            }
        }

        // Обработка пунктов меню
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogoutAndShowLogin();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываю управление пользователями
            UserManagementForm userManagementForm = new UserManagementForm(_currentUser);
            userManagementForm.ShowDialog(this);
        }

        private void menuEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControlWithPlaceholder("Редактор меню");
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControlWithPlaceholder("Отчеты");
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControlWithPlaceholder("Создание нового заказа");
        }

        private void viewTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControlWithPlaceholder("Карта столов");
        }

        private void activeOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControlWithPlaceholder("Просмотр активных заказов");
        }

        private void LogoutAndShowLogin()
        {
            // Выход из системы
            RestaurantApp.Program.CurrentUser = null;
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Проверка перед закрытием приложения
            if (this.DialogResult != DialogResult.Abort)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из приложения?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Отменяю закрытие
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            // Обновляю время в статусе
            if (dateTimeStatusLabel != null)
            {
                dateTimeStatusLabel.Text = DateTime.Now.ToString("F");
            }
        }
    }
}