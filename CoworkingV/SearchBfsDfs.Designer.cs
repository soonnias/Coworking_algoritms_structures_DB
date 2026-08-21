namespace CoworkingV
{
    partial class SearchBfsDfs
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
            this.buttonBFS = new System.Windows.Forms.Button();
            this.buttonDFS = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTimeBFS = new System.Windows.Forms.Label();
            this.labelTimeDFS = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(425, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonBFS
            // 
            this.buttonBFS.Location = new System.Drawing.Point(9, 77);
            this.buttonBFS.Name = "buttonBFS";
            this.buttonBFS.Size = new System.Drawing.Size(75, 23);
            this.buttonBFS.TabIndex = 1;
            this.buttonBFS.Text = "BFS";
            this.buttonBFS.UseVisualStyleBackColor = true;
            this.buttonBFS.Click += new System.EventHandler(this.buttonBFS_Click);
            // 
            // buttonDFS
            // 
            this.buttonDFS.Location = new System.Drawing.Point(119, 77);
            this.buttonDFS.Name = "buttonDFS";
            this.buttonDFS.Size = new System.Drawing.Size(75, 23);
            this.buttonDFS.TabIndex = 2;
            this.buttonDFS.Text = "DFS";
            this.buttonDFS.UseVisualStyleBackColor = true;
            this.buttonDFS.Click += new System.EventHandler(this.buttonDFS_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(220, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(144, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonDFS);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.buttonBFS);
            this.groupBox1.Location = new System.Drawing.Point(26, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 120);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук Employees за заданим іменем";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть ім\'я для пошуку:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTimeBFS
            // 
            this.labelTimeBFS.AutoSize = true;
            this.labelTimeBFS.Location = new System.Drawing.Point(543, 375);
            this.labelTimeBFS.Name = "labelTimeBFS";
            this.labelTimeBFS.Size = new System.Drawing.Size(114, 16);
            this.labelTimeBFS.TabIndex = 5;
            this.labelTimeBFS.Text = "Час пошуку BFS:";
            // 
            // labelTimeDFS
            // 
            this.labelTimeDFS.AutoSize = true;
            this.labelTimeDFS.Location = new System.Drawing.Point(543, 450);
            this.labelTimeDFS.Name = "labelTimeDFS";
            this.labelTimeDFS.Size = new System.Drawing.Size(115, 16);
            this.labelTimeDFS.TabIndex = 5;
            this.labelTimeDFS.Text = "Час пошуку DFS:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(555, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(425, 296);
            this.dataGridView2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Результати пошуку:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Порядок обходу дерева:";
            // 
            // SearchBfsDfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 498);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelTimeDFS);
            this.Controls.Add(this.labelTimeBFS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchBfsDfs";
            this.Text = "SearchBfsDfs";
            this.Load += new System.EventHandler(this.SearchBfsDfs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBFS;
        private System.Windows.Forms.Button buttonDFS;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTimeBFS;
        private System.Windows.Forms.Label labelTimeDFS;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}