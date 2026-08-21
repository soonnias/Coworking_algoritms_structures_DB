namespace CoworkingV
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.посадиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.планиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.компаніїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.граф1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.граф2ДейкстраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.деревоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хештаблиціToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рекурсіяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запитиБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортуванняКвToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортуванняЛлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лінійнийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bFSDFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.логарифмічнийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратнийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукBSTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інтерполяційнийПошукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ширToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посадиToolStripMenuItem,
            this.планиToolStripMenuItem,
            this.столиToolStripMenuItem,
            this.компаніїToolStripMenuItem,
            this.графToolStripMenuItem,
            this.деревоToolStripMenuItem,
            this.хештаблиціToolStripMenuItem,
            this.рекурсіяToolStripMenuItem,
            this.запитиБДToolStripMenuItem,
            this.сортуванняКвToolStripMenuItem,
            this.сортуванняЛлToolStripMenuItem,
            this.пошукToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1192, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // посадиToolStripMenuItem
            // 
            this.посадиToolStripMenuItem.Name = "посадиToolStripMenuItem";
            this.посадиToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.посадиToolStripMenuItem.Text = "Посади";
            this.посадиToolStripMenuItem.Click += new System.EventHandler(this.посадиToolStripMenuItem_Click);
            // 
            // планиToolStripMenuItem
            // 
            this.планиToolStripMenuItem.Name = "планиToolStripMenuItem";
            this.планиToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.планиToolStripMenuItem.Text = "Плани";
            this.планиToolStripMenuItem.Click += new System.EventHandler(this.планиToolStripMenuItem_Click);
            // 
            // столиToolStripMenuItem
            // 
            this.столиToolStripMenuItem.Name = "столиToolStripMenuItem";
            this.столиToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.столиToolStripMenuItem.Text = "Столи";
            this.столиToolStripMenuItem.Click += new System.EventHandler(this.столиToolStripMenuItem_Click);
            // 
            // компаніїToolStripMenuItem
            // 
            this.компаніїToolStripMenuItem.Name = "компаніїToolStripMenuItem";
            this.компаніїToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.компаніїToolStripMenuItem.Text = "Компанії";
            this.компаніїToolStripMenuItem.Click += new System.EventHandler(this.компаніїToolStripMenuItem_Click);
            // 
            // графToolStripMenuItem
            // 
            this.графToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.граф1ToolStripMenuItem,
            this.граф2ДейкстраToolStripMenuItem,
            this.ширToolStripMenuItem});
            this.графToolStripMenuItem.Name = "графToolStripMenuItem";
            this.графToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.графToolStripMenuItem.Text = "Граф";
            this.графToolStripMenuItem.Click += new System.EventHandler(this.графToolStripMenuItem_Click);
            // 
            // граф1ToolStripMenuItem
            // 
            this.граф1ToolStripMenuItem.Name = "граф1ToolStripMenuItem";
            this.граф1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.граф1ToolStripMenuItem.Text = "Граф1";
            this.граф1ToolStripMenuItem.Click += new System.EventHandler(this.граф1ToolStripMenuItem_Click);
            // 
            // граф2ДейкстраToolStripMenuItem
            // 
            this.граф2ДейкстраToolStripMenuItem.Name = "граф2ДейкстраToolStripMenuItem";
            this.граф2ДейкстраToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.граф2ДейкстраToolStripMenuItem.Text = "Граф2+Дейкстра";
            this.граф2ДейкстраToolStripMenuItem.Click += new System.EventHandler(this.граф2ДейкстраToolStripMenuItem_Click);
            // 
            // деревоToolStripMenuItem
            // 
            this.деревоToolStripMenuItem.Name = "деревоToolStripMenuItem";
            this.деревоToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.деревоToolStripMenuItem.Text = "Дерево";
            this.деревоToolStripMenuItem.Click += new System.EventHandler(this.деревоToolStripMenuItem_Click);
            // 
            // хештаблиціToolStripMenuItem
            // 
            this.хештаблиціToolStripMenuItem.Name = "хештаблиціToolStripMenuItem";
            this.хештаблиціToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.хештаблиціToolStripMenuItem.Text = "Хеш-таблиці";
            this.хештаблиціToolStripMenuItem.Click += new System.EventHandler(this.хештаблиціToolStripMenuItem_Click);
            // 
            // рекурсіяToolStripMenuItem
            // 
            this.рекурсіяToolStripMenuItem.Name = "рекурсіяToolStripMenuItem";
            this.рекурсіяToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.рекурсіяToolStripMenuItem.Text = "Рекурсія";
            this.рекурсіяToolStripMenuItem.Click += new System.EventHandler(this.рекурсіяToolStripMenuItem_Click);
            // 
            // запитиБДToolStripMenuItem
            // 
            this.запитиБДToolStripMenuItem.Name = "запитиБДToolStripMenuItem";
            this.запитиБДToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.запитиБДToolStripMenuItem.Text = "Запити БД";
            this.запитиБДToolStripMenuItem.Click += new System.EventHandler(this.запитиБДToolStripMenuItem_Click);
            // 
            // сортуванняКвToolStripMenuItem
            // 
            this.сортуванняКвToolStripMenuItem.Name = "сортуванняКвToolStripMenuItem";
            this.сортуванняКвToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.сортуванняКвToolStripMenuItem.Text = "Сортування кв.";
            this.сортуванняКвToolStripMenuItem.Click += new System.EventHandler(this.сортуванняКвToolStripMenuItem_Click);
            // 
            // сортуванняЛлToolStripMenuItem
            // 
            this.сортуванняЛлToolStripMenuItem.Name = "сортуванняЛлToolStripMenuItem";
            this.сортуванняЛлToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.сортуванняЛлToolStripMenuItem.Text = "Сортування л.-л.";
            this.сортуванняЛлToolStripMenuItem.Click += new System.EventHandler(this.сортуванняЛлToolStripMenuItem_Click);
            // 
            // пошукToolStripMenuItem
            // 
            this.пошукToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лінійнийToolStripMenuItem,
            this.bFSDFSToolStripMenuItem,
            this.логарифмічнийToolStripMenuItem,
            this.квадратнийToolStripMenuItem,
            this.пошукBSTToolStripMenuItem,
            this.інтерполяційнийПошукToolStripMenuItem});
            this.пошукToolStripMenuItem.Name = "пошукToolStripMenuItem";
            this.пошукToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.пошукToolStripMenuItem.Text = "Пошук";
            // 
            // лінійнийToolStripMenuItem
            // 
            this.лінійнийToolStripMenuItem.Name = "лінійнийToolStripMenuItem";
            this.лінійнийToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.лінійнийToolStripMenuItem.Text = "Лінійний";
            this.лінійнийToolStripMenuItem.Click += new System.EventHandler(this.лінійнийToolStripMenuItem_Click);
            // 
            // bFSDFSToolStripMenuItem
            // 
            this.bFSDFSToolStripMenuItem.Name = "bFSDFSToolStripMenuItem";
            this.bFSDFSToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.bFSDFSToolStripMenuItem.Text = "BFS/DFS";
            this.bFSDFSToolStripMenuItem.Click += new System.EventHandler(this.bFSDFSToolStripMenuItem_Click);
            // 
            // логарифмічнийToolStripMenuItem
            // 
            this.логарифмічнийToolStripMenuItem.Name = "логарифмічнийToolStripMenuItem";
            this.логарифмічнийToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.логарифмічнийToolStripMenuItem.Text = "Логарифмічний";
            this.логарифмічнийToolStripMenuItem.Click += new System.EventHandler(this.логарифмічнийToolStripMenuItem_Click);
            // 
            // квадратнийToolStripMenuItem
            // 
            this.квадратнийToolStripMenuItem.Name = "квадратнийToolStripMenuItem";
            this.квадратнийToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.квадратнийToolStripMenuItem.Text = "Квадратичний";
            this.квадратнийToolStripMenuItem.Click += new System.EventHandler(this.квадратнийToolStripMenuItem_Click);
            // 
            // пошукBSTToolStripMenuItem
            // 
            this.пошукBSTToolStripMenuItem.Name = "пошукBSTToolStripMenuItem";
            this.пошукBSTToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.пошукBSTToolStripMenuItem.Text = "Пошук BST";
            this.пошукBSTToolStripMenuItem.Click += new System.EventHandler(this.пошукBSTToolStripMenuItem_Click);
            // 
            // інтерполяційнийПошукToolStripMenuItem
            // 
            this.інтерполяційнийПошукToolStripMenuItem.Name = "інтерполяційнийПошукToolStripMenuItem";
            this.інтерполяційнийПошукToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.інтерполяційнийПошукToolStripMenuItem.Text = "Інтерполяційний";
            this.інтерполяційнийПошукToolStripMenuItem.Click += new System.EventHandler(this.інтерполяційнийПошукToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 522);
            this.panel1.TabIndex = 1;
            // 
            // ширToolStripMenuItem
            // 
            this.ширToolStripMenuItem.Name = "ширToolStripMenuItem";
            this.ширToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ширToolStripMenuItem.Text = "Шифрування";
            this.ширToolStripMenuItem.Click += new System.EventHandler(this.ширToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem посадиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem планиToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem столиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem компаніїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem деревоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хештаблиціToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рекурсіяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запитиБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортуванняКвToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортуванняЛлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лінійнийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bFSDFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem логарифмічнийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадратнийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукBSTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інтерполяційнийПошукToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem граф1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem граф2ДейкстраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ширToolStripMenuItem;
    }
}