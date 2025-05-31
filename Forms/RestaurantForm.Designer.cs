namespace RestaurantManagementApp.Forms

{
    partial class RestaurantForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblContactEmail = new System.Windows.Forms.Label();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCuisineType = new System.Windows.Forms.Label();
            this.txtCuisineType = new System.Windows.Forms.TextBox();
            this.lblOperatingHours = new System.Windows.Forms.Label();
            this.txtOperatingHours = new System.Windows.Forms.TextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Название:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(25, 60);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 17);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Адрес:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(150, 57);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(280, 22);
            this.txtAddress.TabIndex = 2; // Изменено на 2
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(25, 90);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(72, 17);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Телефон:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(150, 87);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(280, 22);
            this.txtPhoneNumber.TabIndex = 3; // Изменено на 3
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.AutoSize = true;
            this.lblContactEmail.Location = new System.Drawing.Point(25, 120);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(46, 17);
            this.lblContactEmail.TabIndex = 6;
            this.lblContactEmail.Text = "Email:";
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(150, 117);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(280, 22);
            this.txtContactEmail.TabIndex = 4; // Изменено на 4
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(25, 150);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(78, 17);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Описание:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 147);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(280, 70);
            this.txtDescription.TabIndex = 5; // Изменено на 5
            // 
            // lblCuisineType
            // 
            this.lblCuisineType.AutoSize = true;
            this.lblCuisineType.Location = new System.Drawing.Point(25, 230); // Сдвинуто вниз
            this.lblCuisineType.Name = "lblCuisineType";
            this.lblCuisineType.Size = new System.Drawing.Size(78, 17);
            this.lblCuisineType.TabIndex = 10;
            this.lblCuisineType.Text = "Тип кухни:";
            // 
            // txtCuisineType
            // 
            this.txtCuisineType.Location = new System.Drawing.Point(150, 227); // Сдвинуто вниз
            this.txtCuisineType.Name = "txtCuisineType";
            this.txtCuisineType.Size = new System.Drawing.Size(280, 22);
            this.txtCuisineType.TabIndex = 6; // Изменено на 6
            // 
            // lblOperatingHours
            // 
            this.lblOperatingHours.AutoSize = true;
            this.lblOperatingHours.Location = new System.Drawing.Point(25, 260); // Сдвинуто вниз
            this.lblOperatingHours.Name = "lblOperatingHours";
            this.lblOperatingHours.Size = new System.Drawing.Size(98, 17);
            this.lblOperatingHours.TabIndex = 12;
            this.lblOperatingHours.Text = "Часы работы:";
            // 
            // txtOperatingHours
            // 
            this.txtOperatingHours.Location = new System.Drawing.Point(150, 257); // Сдвинуто вниз
            this.txtOperatingHours.Name = "txtOperatingHours";
            this.txtOperatingHours.Size = new System.Drawing.Size(280, 22);
            this.txtOperatingHours.TabIndex = 7; // Изменено на 7
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(150, 290); // Сдвинуто вниз
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(82, 21);
            this.chkIsActive.TabIndex = 8; // Изменено на 8
            this.chkIsActive.Text = "Активен";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 330); // Сдвинуто вниз
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.TabIndex = 9; // Изменено на 9
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(285, 330); // Сдвинуто вниз, правее btnSave
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 35);
            this.btnCancel.TabIndex = 10; // Изменено на 10
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(147, 375); // Сдвинуто вниз
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(103, 17);
            this.lblErrorMessage.TabIndex = 17;
            this.lblErrorMessage.Text = "Error Message"; // Текст ошибки будет устанавливаться программно
            this.lblErrorMessage.Visible = false;
            // 
            // RestaurantForm
            // 
            this.AcceptButton = this.btnSave; // Нажатие Enter сработает как клик по btnSave
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel; // Нажатие Esc сработает как клик по btnCancel
            this.ClientSize = new System.Drawing.Size(462, 413); // Увеличил высоту для размещения всех элементов
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtOperatingHours);
            this.Controls.Add(this.lblOperatingHours);
            this.Controls.Add(this.txtCuisineType);
            this.Controls.Add(this.lblCuisineType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtContactEmail);
            this.Controls.Add(this.lblContactEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RestaurantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить Ресторан"; // Заголовок будет меняться в коде для редактирования
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblContactEmail;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCuisineType;
        private System.Windows.Forms.TextBox txtCuisineType;
        private System.Windows.Forms.Label lblOperatingHours;
        private System.Windows.Forms.TextBox txtOperatingHours;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}