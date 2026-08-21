namespace CoworkingV
{
    partial class SearchL
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
            this.dataGridViewFind = new System.Windows.Forms.DataGridView();
            this.dataGridViewFindMy = new System.Windows.Forms.DataGridView();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTimeMy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFind1 = new System.Windows.Forms.Button();
            this.textBoxUsersNameSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFind2 = new System.Windows.Forms.Button();
            this.textBoxEmployeesSalaryHigherThan = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonFind3 = new System.Windows.Forms.Button();
            this.textBoxNameCompanyStartWith = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFindMy)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFind
            // 
            this.dataGridViewFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFind.Location = new System.Drawing.Point(46, 38);
            this.dataGridViewFind.Name = "dataGridViewFind";
            this.dataGridViewFind.ReadOnly = true;
            this.dataGridViewFind.RowHeadersWidth = 51;
            this.dataGridViewFind.RowTemplate.Height = 24;
            this.dataGridViewFind.Size = new System.Drawing.Size(469, 277);
            this.dataGridViewFind.TabIndex = 0;
            // 
            // dataGridViewFindMy
            // 
            this.dataGridViewFindMy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFindMy.Location = new System.Drawing.Point(609, 38);
            this.dataGridViewFindMy.Name = "dataGridViewFindMy";
            this.dataGridViewFindMy.ReadOnly = true;
            this.dataGridViewFindMy.RowHeadersWidth = 51;
            this.dataGridViewFindMy.RowTemplate.Height = 24;
            this.dataGridViewFindMy.Size = new System.Drawing.Size(453, 277);
            this.dataGridViewFindMy.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(43, 332);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(174, 16);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Час вбудованого пошуку:";
            // 
            // labelTimeMy
            // 
            this.labelTimeMy.AutoSize = true;
            this.labelTimeMy.Location = new System.Drawing.Point(606, 332);
            this.labelTimeMy.Name = "labelTimeMy";
            this.labelTimeMy.Size = new System.Drawing.Size(119, 16);
            this.labelTimeMy.TabIndex = 3;
            this.labelTimeMy.Text = "Час мого пошуку:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFind1);
            this.groupBox1.Controls.Add(this.textBoxUsersNameSearch);
            this.groupBox1.Location = new System.Drawing.Point(104, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук в Users по імені";
            // 
            // buttonFind1
            // 
            this.buttonFind1.Location = new System.Drawing.Point(10, 71);
            this.buttonFind1.Name = "buttonFind1";
            this.buttonFind1.Size = new System.Drawing.Size(75, 23);
            this.buttonFind1.TabIndex = 1;
            this.buttonFind1.Text = "Find";
            this.buttonFind1.UseVisualStyleBackColor = true;
            this.buttonFind1.Click += new System.EventHandler(this.buttonFind1_Click);
            // 
            // textBoxUsersNameSearch
            // 
            this.textBoxUsersNameSearch.Location = new System.Drawing.Point(10, 32);
            this.textBoxUsersNameSearch.Name = "textBoxUsersNameSearch";
            this.textBoxUsersNameSearch.Size = new System.Drawing.Size(151, 22);
            this.textBoxUsersNameSearch.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFind2);
            this.groupBox2.Controls.Add(this.textBoxEmployeesSalaryHigherThan);
            this.groupBox2.Location = new System.Drawing.Point(387, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пошук в Employees зарплата >";
            // 
            // buttonFind2
            // 
            this.buttonFind2.Location = new System.Drawing.Point(10, 71);
            this.buttonFind2.Name = "buttonFind2";
            this.buttonFind2.Size = new System.Drawing.Size(75, 23);
            this.buttonFind2.TabIndex = 1;
            this.buttonFind2.Text = "Find";
            this.buttonFind2.UseVisualStyleBackColor = true;
            this.buttonFind2.Click += new System.EventHandler(this.buttonFind2_Click);
            // 
            // textBoxEmployeesSalaryHigherThan
            // 
            this.textBoxEmployeesSalaryHigherThan.Location = new System.Drawing.Point(10, 32);
            this.textBoxEmployeesSalaryHigherThan.Name = "textBoxEmployeesSalaryHigherThan";
            this.textBoxEmployeesSalaryHigherThan.Size = new System.Drawing.Size(151, 22);
            this.textBoxEmployeesSalaryHigherThan.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonFind3);
            this.groupBox3.Controls.Add(this.textBoxNameCompanyStartWith);
            this.groupBox3.Location = new System.Drawing.Point(692, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пошук в Companies назва починається на";
            // 
            // buttonFind3
            // 
            this.buttonFind3.Location = new System.Drawing.Point(10, 71);
            this.buttonFind3.Name = "buttonFind3";
            this.buttonFind3.Size = new System.Drawing.Size(75, 23);
            this.buttonFind3.TabIndex = 1;
            this.buttonFind3.Text = "Find";
            this.buttonFind3.UseVisualStyleBackColor = true;
            this.buttonFind3.Click += new System.EventHandler(this.buttonFind3_Click);
            // 
            // textBoxNameCompanyStartWith
            // 
            this.textBoxNameCompanyStartWith.Location = new System.Drawing.Point(10, 32);
            this.textBoxNameCompanyStartWith.Name = "textBoxNameCompanyStartWith";
            this.textBoxNameCompanyStartWith.Size = new System.Drawing.Size(151, 22);
            this.textBoxNameCompanyStartWith.TabIndex = 0;
            // 
            // SearchL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTimeMy);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.dataGridViewFindMy);
            this.Controls.Add(this.dataGridViewFind);
            this.Name = "SearchL";
            this.Text = "SearchL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFindMy)).EndInit();
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

        private System.Windows.Forms.DataGridView dataGridViewFind;
        private System.Windows.Forms.DataGridView dataGridViewFindMy;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTimeMy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFind1;
        private System.Windows.Forms.TextBox textBoxUsersNameSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFind2;
        private System.Windows.Forms.TextBox textBoxEmployeesSalaryHigherThan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonFind3;
        private System.Windows.Forms.TextBox textBoxNameCompanyStartWith;
    }
}