namespace RestaurantApp.Forms

{
    partial class MainForm // Ключевое слово partial обязательно
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
            this.components = new System.ComponentModel.Container(); // Важно для Timer
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.currentUserStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateTimeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.operationsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(984, 24); // Примерный размер
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "&Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "В&ыход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.menuEditorToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.managementToolStripMenuItem.Text = "&Управление";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usersToolStripMenuItem.Text = "&Пользователи";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // menuEditorToolStripMenuItem
            // 
            this.menuEditorToolStripMenuItem.Name = "menuEditorToolStripMenuItem";
            this.menuEditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.menuEditorToolStripMenuItem.Text = "Редактор &меню";
            this.menuEditorToolStripMenuItem.Click += new System.EventHandler(this.menuEditorToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportsToolStripMenuItem.Text = "&Отчеты";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem,
            this.viewTablesToolStripMenuItem,
            this.activeOrdersToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.operationsToolStripMenuItem.Text = "&Операции";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newOrderToolStripMenuItem.Text = "&Новый заказ";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // viewTablesToolStripMenuItem
            // 
            this.viewTablesToolStripMenuItem.Name = "viewTablesToolStripMenuItem";
            this.viewTablesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewTablesToolStripMenuItem.Text = "Карта &столов";
            this.viewTablesToolStripMenuItem.Click += new System.EventHandler(this.viewTablesToolStripMenuItem_Click);
            // 
            // activeOrdersToolStripMenuItem
            // 
            this.activeOrdersToolStripMenuItem.Name = "activeOrdersToolStripMenuItem";
            this.activeOrdersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.activeOrdersToolStripMenuItem.Text = "&Активные заказы";
            this.activeOrdersToolStripMenuItem.Click += new System.EventHandler(this.activeOrdersToolStripMenuItem_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserStatusLabel,
            this.dateTimeStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 639); // Обновите, если нужно
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(984, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // currentUserStatusLabel
            // 
            this.currentUserStatusLabel.Name = "currentUserStatusLabel";
            this.currentUserStatusLabel.Size = new System.Drawing.Size(136, 17);
            this.currentUserStatusLabel.Text = "Пользователь: Статус";
            // 
            // dateTimeStatusLabel
            // 
            this.dateTimeStatusLabel.Name = "dateTimeStatusLabel";
            this.dateTimeStatusLabel.Size = new System.Drawing.Size(833, 17); // Для растягивания
            this.dateTimeStatusLabel.Spring = true; // Важно для растягивания
            this.dateTimeStatusLabel.Text = "Дата и Время";
            this.dateTimeStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusTimer
            // 
            this.statusTimer.Enabled = true;
            this.statusTimer.Interval = 1000; // 1 секунда
            this.statusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.lblWelcomeMessage);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 24); // Под menuStrip
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15); // Отступы
            this.headerPanel.Size = new System.Drawing.Size(984, 75); // Высота панели
            this.headerPanel.TabIndex = 2;
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(20, 15); // Учитываем Padding
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(944, 45);
            this.lblWelcomeMessage.TabIndex = 0;
            this.lblWelcomeMessage.Text = "Добро пожаловать!";
            this.lblWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentPanel.Location = new System.Drawing.Point(0, 99); // Под headerPanel (24 + 75)
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Padding = new System.Windows.Forms.Padding(15); // Отступы для контента
            this.mainContentPanel.Size = new System.Drawing.Size(984, 540); // (Общая - меню - хедер - статус)
            this.mainContentPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F); // Типично для Segoe UI
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661); // Увеличенный размер окна
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            // Порядок добавления для правильного Docking:
            this.Controls.Add(this.mainContentPanel);  // Заполняет оставшееся место
            this.Controls.Add(this.headerPanel);       // Сверху, под меню
            this.Controls.Add(this.mainStatusStrip);   // Внизу
            this.Controls.Add(this.mainMenuStrip);     // Самый верхний

            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600); // Минимальный размер окна
            this.Name = "MainForm";
            this.Text = "Панель управления рестораном";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Объявление контролов как полей класса
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel currentUserStatusLabel;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Panel mainContentPanel;
        private System.Windows.Forms.Panel headerPanel; // Для заголовка
        private System.Windows.Forms.ToolStripStatusLabel dateTimeStatusLabel; // Для даты/времени
        private System.Windows.Forms.Timer statusTimer; // Таймер

        // Новые пункты меню для управления и операций
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeOrdersToolStripMenuItem;
    }
}