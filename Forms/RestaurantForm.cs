using System;
using System.Windows.Forms;
using RestaurantManagement.Data;
using RestaurantManagement.Models;
using System.Linq;

namespace RestaurantManagementApp.Forms
{
    public partial class RestaurantForm : Form
    {
        private readonly RestaurantDbContext _dbContext;
        private readonly ApplicationUser _owner;
        private Restaurant _editingRestaurant;

        public RestaurantForm(ApplicationUser owner, Restaurant restaurantToEdit = null)
        {
            InitializeComponent();
            _dbContext = new RestaurantDbContext();
            _owner = owner;
            _editingRestaurant = restaurantToEdit;

            ApplyCustomStyles();

            if (_editingRestaurant != null)
            {
                // Настройки для редактирования
                this.Text = "Редактировать ресторан";
                btnSave.Text = "Обновить";
                PopulateFormForEditing();
            }
            else
            {
                // Настройки для создания нового ресторана
                this.Text = "Добавить новый ресторан";
                chkIsActive.Checked = true;
            }
        }

        private void ApplyCustomStyles()
        {
            // Основные цвета и стили
            Color restaurantBlue = ColorTranslator.FromHtml("#3c6799");
            this.BackColor = Color.WhiteSmoke;

            // Стили для меток
            foreach (var label in this.Controls.OfType<Label>().Where(l => l != lblErrorMessage))
            {
                label.Font = new Font("Segoe UI", 9F);
                label.ForeColor = Color.FromArgb(64, 64, 64);
            }

            // Стили для текстовых полей
            foreach (var textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Font = new Font("Segoe UI", 10.2F);
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.BackColor = Color.White;
            }

            // Чекбокс
            if (chkIsActive != null) chkIsActive.Font = new Font("Segoe UI", 9F);

            // Кнопки
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.BackColor = restaurantBlue;
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                button.Cursor = Cursors.Hand;
            }

            // Кнопка Отмена — отдельный стиль
            if (btnCancel != null) btnCancel.BackColor = Color.Gray;

            // Метка ошибки
            if (lblErrorMessage != null)
            {
                lblErrorMessage.ForeColor = Color.Red;
                lblErrorMessage.Visible = false;
            }

            // Оформление формы
            this.Font = new Font("Segoe UI", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void PopulateFormForEditing()
        {
            // Заполняем поля для редактирования
            if (_editingRestaurant == null) return;

            txtName.Text = _editingRestaurant.Name;
            txtAddress.Text = _editingRestaurant.Address;
            txtPhoneNumber.Text = _editingRestaurant.PhoneNumber;
            txtContactEmail.Text = _editingRestaurant.ContactEmail;
            txtDescription.Text = _editingRestaurant.Description;
            txtCuisineType.Text = _editingRestaurant.CuisineType;
            txtOperatingHours.Text = _editingRestaurant.OperatingHours;
            chkIsActive.Checked = _editingRestaurant.IsActive;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;

            // Проверяем корректность ввода
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                ShowError("Название ресторана обязательно.", txtName);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                ShowError("Адрес ресторана обязателен.", txtAddress);
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtContactEmail.Text) && !IsValidEmail(txtContactEmail.Text))
            {
                ShowError("Некорректный формат Email.", txtContactEmail);
                return;
            }

            try
            {
                if (_editingRestaurant == null) // Добавление нового ресторана
                {
                    var newRestaurant = new Restaurant
                    {
                        Name = txtName.Text.Trim(),
                        Address = txtAddress.Text.Trim(),
                        PhoneNumber = string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ? null : txtPhoneNumber.Text.Trim(),
                        ContactEmail = string.IsNullOrWhiteSpace(txtContactEmail.Text) ? null : txtContactEmail.Text.Trim(),
                        Description = string.IsNullOrWhiteSpace(txtDescription.Text) ? null : txtDescription.Text.Trim(),
                        CuisineType = string.IsNullOrWhiteSpace(txtCuisineType.Text) ? null : txtCuisineType.Text.Trim(),
                        OperatingHours = string.IsNullOrWhiteSpace(txtOperatingHours.Text) ? null : txtOperatingHours.Text.Trim(),
                        IsActive = chkIsActive.Checked,
                        OwnerId = _owner.Id,
                        CreatedAt = DateTime.UtcNow
                    };
                    _dbContext.Restaurants.Add(newRestaurant);
                    MessageBox.Show("Ресторан успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Редактирование существующего
                {
                    _editingRestaurant.Name = txtName.Text.Trim();
                    _editingRestaurant.Address = txtAddress.Text.Trim();
                    _editingRestaurant.PhoneNumber = string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ? null : txtPhoneNumber.Text.Trim();
                    _editingRestaurant.ContactEmail = string.IsNullOrWhiteSpace(txtContactEmail.Text) ? null : txtContactEmail.Text.Trim();
                    _editingRestaurant.Description = string.IsNullOrWhiteSpace(txtDescription.Text) ? null : txtDescription.Text.Trim();
                    _editingRestaurant.CuisineType = string.IsNullOrWhiteSpace(txtCuisineType.Text) ? null : txtCuisineType.Text.Trim();
                    _editingRestaurant.OperatingHours = string.IsNullOrWhiteSpace(txtOperatingHours.Text) ? null : txtOperatingHours.Text.Trim();
                    _editingRestaurant.IsActive = chkIsActive.Checked;

                    _dbContext.Restaurants.Update(_editingRestaurant);
                    MessageBox.Show("Данные ресторана успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                await _dbContext.SaveChangesAsync();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка сохранения: {ex.Message}", null);
                Console.WriteLine(ex); // Для отладки
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ShowError(string message, Control controlToFocus)
        {
            lblErrorMessage.Text = message;
            lblErrorMessage.Visible = true;
            controlToFocus?.Focus();
        }

        private bool IsValidEmail(string email)
        {
            // Простая проверка корректности email
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _dbContext?.Dispose(); // Освобождаем ресурсы
            base.OnFormClosed(e);
        }
    }
}