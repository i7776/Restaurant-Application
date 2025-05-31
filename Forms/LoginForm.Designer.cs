namespace RestaurantManagementApp.Forms 
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            headerPanel = new Panel();
            lblLoginTitle = new Label();
            pictureBoxLogo = new PictureBox();
            contentPanel = new Panel();
            linkGoToRegister = new LinkLabel();
            btnLogin = new Button();
            lblErrorMessage = new Label();
            chkRememberMe = new CheckBox();
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
            headerPanel.Controls.Add(lblLoginTitle);
            headerPanel.Controls.Add(pictureBoxLogo);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(334, 112);
            headerPanel.TabIndex = 0;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLoginTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblLoginTitle.ForeColor = Color.White;
            lblLoginTitle.Location = new Point(0, 70);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(334, 38);
            lblLoginTitle.TabIndex = 1;
            lblLoginTitle.Text = "Вход в систему";
            lblLoginTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(132, 11);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(70, 56);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.White;
            contentPanel.Controls.Add(linkGoToRegister);
            contentPanel.Controls.Add(btnLogin);
            contentPanel.Controls.Add(lblErrorMessage);
            contentPanel.Controls.Add(chkRememberMe);
            contentPanel.Controls.Add(txtPassword);
            contentPanel.Controls.Add(lblPassword);
            contentPanel.Controls.Add(txtUsername);
            contentPanel.Controls.Add(lblUsername);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 112);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(26, 19, 26, 19);
            contentPanel.Size = new Size(334, 294);
            contentPanel.TabIndex = 1;
            // 
            // linkGoToRegister
            // 
            linkGoToRegister.ActiveLinkColor = Color.FromArgb(50, 86, 129);
            linkGoToRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkGoToRegister.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkGoToRegister.LinkColor = Color.FromArgb(60, 103, 153);
            linkGoToRegister.Location = new Point(29, 245);
            linkGoToRegister.Name = "linkGoToRegister";
            linkGoToRegister.Size = new Size(276, 22);
            linkGoToRegister.TabIndex = 5;
            linkGoToRegister.TabStop = true;
            linkGoToRegister.Text = "Нет аккаунта? Зарегистрируйтесь";
            linkGoToRegister.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(60, 103, 153);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(29, 192);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(276, 38);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblErrorMessage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(29, 164);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(276, 22);
            lblErrorMessage.TabIndex = 6;
            lblErrorMessage.Text = "Сообщение об ошибке";
            lblErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblErrorMessage.Visible = false;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chkRememberMe.Location = new Point(29, 136);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(118, 19);
            chkRememberMe.TabIndex = 3;
            chkRememberMe.Text = "Запомнить меня";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPassword.Location = new Point(29, 102);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(277, 26);
            txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPassword.Location = new Point(26, 81);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(52, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Пароль:";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtUsername.Location = new Point(29, 45);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(277, 26);
            txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblUsername.Location = new Point(26, 23);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(112, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Имя пользователя:";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 406);
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему - RestaurantApp";
            headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkGoToRegister;
    }
}