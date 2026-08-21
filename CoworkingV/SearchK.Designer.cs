namespace CoworkingV
{
    partial class SearchK
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearchESalary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSearchPlans = new System.Windows.Forms.Button();
            this.labelTimeMy = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSearchContractsPr = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSearchUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(827, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearchESalary);
            this.groupBox1.Location = new System.Drawing.Point(29, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Зарплата з Employees";
            // 
            // buttonSearchESalary
            // 
            this.buttonSearchESalary.Location = new System.Drawing.Point(48, 34);
            this.buttonSearchESalary.Name = "buttonSearchESalary";
            this.buttonSearchESalary.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchESalary.TabIndex = 3;
            this.buttonSearchESalary.Text = "Search";
            this.buttonSearchESalary.UseVisualStyleBackColor = true;
            this.buttonSearchESalary.Click += new System.EventHandler(this.buttonSearchESalary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Знайти найбільше і найменше значення";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSearchPlans);
            this.groupBox2.Location = new System.Drawing.Point(258, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ціна з Plans";
            // 
            // buttonSearchPlans
            // 
            this.buttonSearchPlans.Location = new System.Drawing.Point(48, 34);
            this.buttonSearchPlans.Name = "buttonSearchPlans";
            this.buttonSearchPlans.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchPlans.TabIndex = 3;
            this.buttonSearchPlans.Text = "Search";
            this.buttonSearchPlans.UseVisualStyleBackColor = true;
            this.buttonSearchPlans.Click += new System.EventHandler(this.buttonSearchPlans_Click);
            // 
            // labelTimeMy
            // 
            this.labelTimeMy.AutoSize = true;
            this.labelTimeMy.Location = new System.Drawing.Point(26, 398);
            this.labelTimeMy.Name = "labelTimeMy";
            this.labelTimeMy.Size = new System.Drawing.Size(85, 16);
            this.labelTimeMy.TabIndex = 3;
            this.labelTimeMy.Text = "Час пошуку:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSearchContractsPr);
            this.groupBox3.Location = new System.Drawing.Point(679, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 84);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ціна з Contracts";
            // 
            // buttonSearchContractsPr
            // 
            this.buttonSearchContractsPr.Location = new System.Drawing.Point(48, 34);
            this.buttonSearchContractsPr.Name = "buttonSearchContractsPr";
            this.buttonSearchContractsPr.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchContractsPr.TabIndex = 3;
            this.buttonSearchContractsPr.Text = "Search";
            this.buttonSearchContractsPr.UseVisualStyleBackColor = true;
            this.buttonSearchContractsPr.Click += new System.EventHandler(this.buttonSearchContractsPr_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSearchUser);
            this.groupBox4.Location = new System.Drawing.Point(466, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 84);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Прізвище з Users";
            // 
            // buttonSearchUser
            // 
            this.buttonSearchUser.Location = new System.Drawing.Point(48, 34);
            this.buttonSearchUser.Name = "buttonSearchUser";
            this.buttonSearchUser.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchUser.TabIndex = 3;
            this.buttonSearchUser.Text = "Search";
            this.buttonSearchUser.UseVisualStyleBackColor = true;
            this.buttonSearchUser.Click += new System.EventHandler(this.buttonSearchUser_Click);
            // 
            // SearchK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 491);
            this.Controls.Add(this.labelTimeMy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchK";
            this.Text = "SearchK";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchESalary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSearchPlans;
        private System.Windows.Forms.Label labelTimeMy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSearchContractsPr;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSearchUser;
    }
}