namespace RestaurantManagementApp.Forms
    
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerPanel = new Panel();
            lblRegisterTitle = new Label();
            pictureBoxLogo = new PictureBox();
            contentPanel = new Panel();
            lblRole = new Label();
            cmbRole = new ComboBox();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            linkGoToLogin = new LinkLabel();
            btnRegister = new Button();
            lblErrorMessage = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(60, 103, 153);
            headerPanel.Controls.Add(lblRegisterTitle);
            headerPanel.Controls.Add(pictureBoxLogo);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(378, 112);
            headerPanel.TabIndex = 1;
            // 
            // lblRegisterTitle
            // 
            lblRegisterTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRegisterTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblRegisterTitle.ForeColor = Color.White;
            lblRegisterTitle.Location = new Point(0, 70);
            lblRegisterTitle.Name = "lblRegisterTitle";
            lblRegisterTitle.Size = new Size(378, 38);
            lblRegisterTitle.TabIndex = 1;
            lblRegisterTitle.Text = "Регистрация";
            lblRegisterTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(154, 11);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(70, 56);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.White;
            contentPanel.Controls.Add(lblRole);
            contentPanel.Controls.Add(cmbRole);
            contentPanel.Controls.Add(txtPhoneNumber);
            contentPanel.Controls.Add(lblPhoneNumber);
            contentPanel.Controls.Add(txtEmail);
            contentPanel.Controls.Add(lblEmail);
            contentPanel.Controls.Add(txtFullName);
            contentPanel.Controls.Add(lblFullName);
            contentPanel.Controls.Add(txtConfirmPassword);
            contentPanel.Controls.Add(lblConfirmPassword);
            contentPanel.Controls.Add(linkGoToLogin);
            contentPanel.Controls.Add(btnRegister);
            contentPanel.Controls.Add(lblErrorMessage);
            contentPanel.Controls.Add(txtPassword);
            contentPanel.Controls.Add(lblPassword);
            contentPanel.Controls.Add(txtUsername);
            contentPanel.Controls.Add(lblUsername);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 112);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(26, 14, 26, 14);
            contentPanel.Size = new Size(378, 481);
            contentPanel.TabIndex = 2;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9F);
            lblRole.Location = new Point(26, 329);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(37, 15);
            lblRole.TabIndex = 16;
            lblRole.Text = "Роль:";
            // 
            // cmbRole
            // 
            cmbRole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 10.2F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(29, 351);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(321, 27);
            cmbRole.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneNumber.Font = new Font("Segoe UI", 10.2F);
            txtPhoneNumber.Location = new Point(29, 293);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(321, 26);
            txtPhoneNumber.TabIndex = 5;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 9F);
            lblPhoneNumber.Location = new Point(26, 272);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(104, 15);
            lblPhoneNumber.TabIndex = 13;
            lblPhoneNumber.Text = "Номер телефона:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Segoe UI", 10.2F);
            txtEmail.Location = new Point(29, 236);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(321, 26);
            txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.Location = new Point(26, 215);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(121, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Электронная почта:*";
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.Font = new Font("Segoe UI", 10.2F);
            txtFullName.Location = new Point(29, 179);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(321, 26);
            txtFullName.TabIndex = 3;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 9F);
            lblFullName.Location = new Point(26, 158);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(121, 15);
            lblFullName.TabIndex = 9;
            lblFullName.Text = "Полное имя (ФИО):*";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmPassword.Font = new Font("Segoe UI", 10.2F);
            txtConfirmPassword.Location = new Point(29, 122);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new Size(321, 26);
            txtConfirmPassword.TabIndex = 2;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 9F);
            lblConfirmPassword.Location = new Point(26, 100);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(128, 15);
            lblConfirmPassword.TabIndex = 7;
            lblConfirmPassword.Text = "Подтвердите пароль:*";
            // 
            // linkGoToLogin
            // 
            linkGoToLogin.ActiveLinkColor = Color.FromArgb(50, 86, 129);
            linkGoToLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkGoToLogin.Font = new Font("Segoe UI", 9F);
            linkGoToLogin.LinkColor = Color.FromArgb(60, 103, 153);
            linkGoToLogin.Location = new Point(29, 445);
            linkGoToLogin.Name = "linkGoToLogin";
            linkGoToLogin.Size = new Size(320, 22);
            linkGoToLogin.TabIndex = 8;
            linkGoToLogin.TabStop = true;
            linkGoToLogin.Text = "Уже есть аккаунт? Войти";
            linkGoToLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegister.BackColor = Color.FromArgb(60, 103, 153);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(29, 403);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(320, 38);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Зарегистрироваться";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblErrorMessage.Font = new Font("Segoe UI", 9F);
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(29, 381);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(320, 22);
            lblErrorMessage.TabIndex = 6;
            lblErrorMessage.Text = "Сообщение об ошибке";
            lblErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblErrorMessage.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Font = new Font("Segoe UI", 10.2F);
            txtPassword.Location = new Point(29, 69);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(321, 26);
            txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.Location = new Point(26, 48);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Пароль:*";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Font = new Font("Segoe UI", 10.2F);
            txtUsername.Location = new Point(29, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(321, 26);
            txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F);
            lblUsername.Location = new Point(26, -9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(161, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Имя пользователя (логин):*";
            // 
            // RegisterForm
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 593);
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация - RestaurantApp";
            Load += RegisterForm_Load;
            headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblRegisterTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.LinkLabel linkGoToLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
    }
}