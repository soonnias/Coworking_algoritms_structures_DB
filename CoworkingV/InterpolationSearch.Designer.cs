namespace CoworkingV
{
    partial class InterpolationSearch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelTimeMy = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonSearch1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxEmployeeSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSearch3 = new System.Windows.Forms.Button();
            this.textBoxPlanNAme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(467, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(566, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(510, 244);
            this.dataGridView2.TabIndex = 0;
            // 
            // labelTimeMy
            // 
            this.labelTimeMy.AutoSize = true;
            this.labelTimeMy.Location = new System.Drawing.Point(563, 299);
            this.labelTimeMy.Name = "labelTimeMy";
            this.labelTimeMy.Size = new System.Drawing.Size(119, 16);
            this.labelTimeMy.TabIndex = 5;
            this.labelTimeMy.Text = "Час мого пошуку:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(27, 299);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(174, 16);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Час вбудованого пошуку:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearch1);
            this.groupBox1.Controls.Add(this.textBoxUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Користувачі за іменем";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(86, 32);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 22);
            this.textBoxUserName.TabIndex = 7;
            // 
            // buttonSearch1
            // 
            this.buttonSearch1.Location = new System.Drawing.Point(52, 65);
            this.buttonSearch1.Name = "buttonSearch1";
            this.buttonSearch1.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch1.TabIndex = 8;
            this.buttonSearch1.Text = "Search";
            this.buttonSearch1.UseVisualStyleBackColor = true;
            this.buttonSearch1.Click += new System.EventHandler(this.buttonSearch1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBoxEmployeeSalary);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(277, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Працівники з прізвищем";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEmployeeSalary
            // 
            this.textBoxEmployeeSalary.Location = new System.Drawing.Point(86, 32);
            this.textBoxEmployeeSalary.Name = "textBoxEmployeeSalary";
            this.textBoxEmployeeSalary.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmployeeSalary.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Прізвище";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSearch3);
            this.groupBox3.Controls.Add(this.textBoxPlanNAme);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(538, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Плани за назвою";
            // 
            // buttonSearch3
            // 
            this.buttonSearch3.Location = new System.Drawing.Point(52, 65);
            this.buttonSearch3.Name = "buttonSearch3";
            this.buttonSearch3.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch3.TabIndex = 8;
            this.buttonSearch3.Text = "Search";
            this.buttonSearch3.UseVisualStyleBackColor = true;
            this.buttonSearch3.Click += new System.EventHandler(this.buttonSearch3_Click);
            // 
            // textBoxPlanNAme
            // 
            this.textBoxPlanNAme.Location = new System.Drawing.Point(86, 32);
            this.textBoxPlanNAme.Name = "textBoxPlanNAme";
            this.textBoxPlanNAme.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlanNAme.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Назва";
            // 
            // InterpolationSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTimeMy);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InterpolationSearch";
            this.Text = "InterpolationSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelTimeMy;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonSearch1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxEmployeeSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSearch3;
        private System.Windows.Forms.TextBox textBoxPlanNAme;
        private System.Windows.Forms.Label label3;
    }
}