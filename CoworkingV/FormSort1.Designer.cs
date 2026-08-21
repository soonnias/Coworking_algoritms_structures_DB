namespace CoworkingV
{
    partial class FormSort1
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
            this.buttonSelectAllUsers = new System.Windows.Forms.Button();
            this.buttonUserSort4 = new System.Windows.Forms.Button();
            this.buttonUserSort3 = new System.Windows.Forms.Button();
            this.buttonUserSort2 = new System.Windows.Forms.Button();
            this.buttonUserSort1 = new System.Windows.Forms.Button();
            this.labelUsersSortDef = new System.Windows.Forms.Label();
            this.labelUsersSortS = new System.Windows.Forms.Label();
            this.labelUsersSortInsert = new System.Windows.Forms.Label();
            this.labelSort1User = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSelectAllPlans = new System.Windows.Forms.Button();
            this.buttonSort4Plans = new System.Windows.Forms.Button();
            this.buttonSort3Plans = new System.Windows.Forms.Button();
            this.buttonSort2Plans = new System.Windows.Forms.Button();
            this.buttonSort1Plans = new System.Windows.Forms.Button();
            this.labelSort4Plans = new System.Windows.Forms.Label();
            this.labelSort3Plans = new System.Windows.Forms.Label();
            this.labelSort2Plans = new System.Windows.Forms.Label();
            this.labelSort1Plans = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(485, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSelectAllUsers);
            this.groupBox1.Controls.Add(this.buttonUserSort4);
            this.groupBox1.Controls.Add(this.buttonUserSort3);
            this.groupBox1.Controls.Add(this.buttonUserSort2);
            this.groupBox1.Controls.Add(this.buttonUserSort1);
            this.groupBox1.Controls.Add(this.labelUsersSortDef);
            this.groupBox1.Controls.Add(this.labelUsersSortS);
            this.groupBox1.Controls.Add(this.labelUsersSortInsert);
            this.groupBox1.Controls.Add(this.labelSort1User);
            this.groupBox1.Location = new System.Drawing.Point(601, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортування Users";
            // 
            // buttonSelectAllUsers
            // 
            this.buttonSelectAllUsers.Location = new System.Drawing.Point(23, 166);
            this.buttonSelectAllUsers.Name = "buttonSelectAllUsers";
            this.buttonSelectAllUsers.Size = new System.Drawing.Size(142, 32);
            this.buttonSelectAllUsers.TabIndex = 2;
            this.buttonSelectAllUsers.Text = "Весь список";
            this.buttonSelectAllUsers.UseVisualStyleBackColor = true;
            this.buttonSelectAllUsers.Click += new System.EventHandler(this.buttonSelectAllUsers_Click);
            // 
            // buttonUserSort4
            // 
            this.buttonUserSort4.Location = new System.Drawing.Point(387, 131);
            this.buttonUserSort4.Name = "buttonUserSort4";
            this.buttonUserSort4.Size = new System.Drawing.Size(75, 23);
            this.buttonUserSort4.TabIndex = 1;
            this.buttonUserSort4.Text = "click";
            this.buttonUserSort4.UseVisualStyleBackColor = true;
            this.buttonUserSort4.Click += new System.EventHandler(this.buttonUserSort4_Click);
            // 
            // buttonUserSort3
            // 
            this.buttonUserSort3.Location = new System.Drawing.Point(387, 97);
            this.buttonUserSort3.Name = "buttonUserSort3";
            this.buttonUserSort3.Size = new System.Drawing.Size(75, 23);
            this.buttonUserSort3.TabIndex = 1;
            this.buttonUserSort3.Text = "click";
            this.buttonUserSort3.UseVisualStyleBackColor = true;
            this.buttonUserSort3.Click += new System.EventHandler(this.buttonUserSort3_Click);
            // 
            // buttonUserSort2
            // 
            this.buttonUserSort2.Location = new System.Drawing.Point(387, 63);
            this.buttonUserSort2.Name = "buttonUserSort2";
            this.buttonUserSort2.Size = new System.Drawing.Size(75, 23);
            this.buttonUserSort2.TabIndex = 1;
            this.buttonUserSort2.Text = "click";
            this.buttonUserSort2.UseVisualStyleBackColor = true;
            this.buttonUserSort2.Click += new System.EventHandler(this.buttonUserSort2_Click);
            // 
            // buttonUserSort1
            // 
            this.buttonUserSort1.Location = new System.Drawing.Point(387, 32);
            this.buttonUserSort1.Name = "buttonUserSort1";
            this.buttonUserSort1.Size = new System.Drawing.Size(75, 23);
            this.buttonUserSort1.TabIndex = 1;
            this.buttonUserSort1.Text = "click";
            this.buttonUserSort1.UseVisualStyleBackColor = true;
            this.buttonUserSort1.Click += new System.EventHandler(this.buttonUserSort1_Click);
            // 
            // labelUsersSortDef
            // 
            this.labelUsersSortDef.AutoSize = true;
            this.labelUsersSortDef.Location = new System.Drawing.Point(20, 138);
            this.labelUsersSortDef.Name = "labelUsersSortDef";
            this.labelUsersSortDef.Size = new System.Drawing.Size(160, 16);
            this.labelUsersSortDef.TabIndex = 0;
            this.labelUsersSortDef.Text = "Метод sort вбудований:";
            // 
            // labelUsersSortS
            // 
            this.labelUsersSortS.AutoSize = true;
            this.labelUsersSortS.Location = new System.Drawing.Point(20, 104);
            this.labelUsersSortS.Name = "labelUsersSortS";
            this.labelUsersSortS.Size = new System.Drawing.Size(152, 16);
            this.labelUsersSortS.TabIndex = 0;
            this.labelUsersSortS.Text = "Сортування вибором: ";
            // 
            // labelUsersSortInsert
            // 
            this.labelUsersSortInsert.AutoSize = true;
            this.labelUsersSortInsert.Location = new System.Drawing.Point(20, 70);
            this.labelUsersSortInsert.Name = "labelUsersSortInsert";
            this.labelUsersSortInsert.Size = new System.Drawing.Size(155, 16);
            this.labelUsersSortInsert.TabIndex = 0;
            this.labelUsersSortInsert.Text = "Сортування вставкою:";
            // 
            // labelSort1User
            // 
            this.labelSort1User.AutoSize = true;
            this.labelSort1User.Location = new System.Drawing.Point(20, 35);
            this.labelSort1User.Name = "labelSort1User";
            this.labelSort1User.Size = new System.Drawing.Size(173, 16);
            this.labelSort1User.TabIndex = 0;
            this.labelSort1User.Text = "Сортування бульбашкою:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSelectAllPlans);
            this.groupBox3.Controls.Add(this.buttonSort4Plans);
            this.groupBox3.Controls.Add(this.buttonSort3Plans);
            this.groupBox3.Controls.Add(this.buttonSort2Plans);
            this.groupBox3.Controls.Add(this.buttonSort1Plans);
            this.groupBox3.Controls.Add(this.labelSort4Plans);
            this.groupBox3.Controls.Add(this.labelSort3Plans);
            this.groupBox3.Controls.Add(this.labelSort2Plans);
            this.groupBox3.Controls.Add(this.labelSort1Plans);
            this.groupBox3.Location = new System.Drawing.Point(601, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 210);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сортування Plans";
            // 
            // buttonSelectAllPlans
            // 
            this.buttonSelectAllPlans.Location = new System.Drawing.Point(23, 169);
            this.buttonSelectAllPlans.Name = "buttonSelectAllPlans";
            this.buttonSelectAllPlans.Size = new System.Drawing.Size(142, 32);
            this.buttonSelectAllPlans.TabIndex = 3;
            this.buttonSelectAllPlans.Text = "Весь список";
            this.buttonSelectAllPlans.UseVisualStyleBackColor = true;
            this.buttonSelectAllPlans.Click += new System.EventHandler(this.buttonSelectAllPlans_Click);
            // 
            // buttonSort4Plans
            // 
            this.buttonSort4Plans.Location = new System.Drawing.Point(387, 131);
            this.buttonSort4Plans.Name = "buttonSort4Plans";
            this.buttonSort4Plans.Size = new System.Drawing.Size(75, 23);
            this.buttonSort4Plans.TabIndex = 1;
            this.buttonSort4Plans.Text = "click";
            this.buttonSort4Plans.UseVisualStyleBackColor = true;
            this.buttonSort4Plans.Click += new System.EventHandler(this.buttonSort4Plans_Click);
            // 
            // buttonSort3Plans
            // 
            this.buttonSort3Plans.Location = new System.Drawing.Point(387, 97);
            this.buttonSort3Plans.Name = "buttonSort3Plans";
            this.buttonSort3Plans.Size = new System.Drawing.Size(75, 23);
            this.buttonSort3Plans.TabIndex = 1;
            this.buttonSort3Plans.Text = "click";
            this.buttonSort3Plans.UseVisualStyleBackColor = true;
            this.buttonSort3Plans.Click += new System.EventHandler(this.buttonSort3Plans_Click);
            // 
            // buttonSort2Plans
            // 
            this.buttonSort2Plans.Location = new System.Drawing.Point(387, 63);
            this.buttonSort2Plans.Name = "buttonSort2Plans";
            this.buttonSort2Plans.Size = new System.Drawing.Size(75, 23);
            this.buttonSort2Plans.TabIndex = 1;
            this.buttonSort2Plans.Text = "click";
            this.buttonSort2Plans.UseVisualStyleBackColor = true;
            this.buttonSort2Plans.Click += new System.EventHandler(this.buttonSort2Plans_Click);
            // 
            // buttonSort1Plans
            // 
            this.buttonSort1Plans.Location = new System.Drawing.Point(387, 32);
            this.buttonSort1Plans.Name = "buttonSort1Plans";
            this.buttonSort1Plans.Size = new System.Drawing.Size(75, 23);
            this.buttonSort1Plans.TabIndex = 1;
            this.buttonSort1Plans.Text = "click";
            this.buttonSort1Plans.UseVisualStyleBackColor = true;
            this.buttonSort1Plans.Click += new System.EventHandler(this.button8_Click);
            // 
            // labelSort4Plans
            // 
            this.labelSort4Plans.AutoSize = true;
            this.labelSort4Plans.Location = new System.Drawing.Point(20, 138);
            this.labelSort4Plans.Name = "labelSort4Plans";
            this.labelSort4Plans.Size = new System.Drawing.Size(160, 16);
            this.labelSort4Plans.TabIndex = 0;
            this.labelSort4Plans.Text = "Метод sort вбудований:";
            // 
            // labelSort3Plans
            // 
            this.labelSort3Plans.AutoSize = true;
            this.labelSort3Plans.Location = new System.Drawing.Point(20, 104);
            this.labelSort3Plans.Name = "labelSort3Plans";
            this.labelSort3Plans.Size = new System.Drawing.Size(152, 16);
            this.labelSort3Plans.TabIndex = 0;
            this.labelSort3Plans.Text = "Сортування вибором: ";
            // 
            // labelSort2Plans
            // 
            this.labelSort2Plans.AutoSize = true;
            this.labelSort2Plans.Location = new System.Drawing.Point(20, 70);
            this.labelSort2Plans.Name = "labelSort2Plans";
            this.labelSort2Plans.Size = new System.Drawing.Size(155, 16);
            this.labelSort2Plans.TabIndex = 0;
            this.labelSort2Plans.Text = "Сортування вставкою:";
            // 
            // labelSort1Plans
            // 
            this.labelSort1Plans.AutoSize = true;
            this.labelSort1Plans.Location = new System.Drawing.Point(20, 35);
            this.labelSort1Plans.Name = "labelSort1Plans";
            this.labelSort1Plans.Size = new System.Drawing.Size(173, 16);
            this.labelSort1Plans.TabIndex = 0;
            this.labelSort1Plans.Text = "Сортування бульбашкою:";
            // 
            // FormSort1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 538);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSort1";
            this.Text = "FormSort1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelUsersSortS;
        private System.Windows.Forms.Label labelUsersSortInsert;
        private System.Windows.Forms.Label labelUsersSortDef;
        private System.Windows.Forms.Button buttonUserSort1;
        private System.Windows.Forms.Button buttonUserSort4;
        private System.Windows.Forms.Button buttonUserSort3;
        private System.Windows.Forms.Button buttonUserSort2;
        private System.Windows.Forms.Label labelSort1User;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSort4Plans;
        private System.Windows.Forms.Button buttonSort3Plans;
        private System.Windows.Forms.Button buttonSort2Plans;
        private System.Windows.Forms.Button buttonSort1Plans;
        private System.Windows.Forms.Label labelSort4Plans;
        private System.Windows.Forms.Label labelSort3Plans;
        private System.Windows.Forms.Label labelSort2Plans;
        private System.Windows.Forms.Label labelSort1Plans;
        private System.Windows.Forms.Button buttonSelectAllUsers;
        private System.Windows.Forms.Button buttonSelectAllPlans;
    }
}