namespace CoworkingV
{
    partial class FormSearchInBST
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameFoeSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTime2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(23, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(323, 471);
            this.treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ім\'я для пошуку:";
            // 
            // textBoxNameFoeSearch
            // 
            this.textBoxNameFoeSearch.Location = new System.Drawing.Point(515, 39);
            this.textBoxNameFoeSearch.Name = "textBoxNameFoeSearch";
            this.textBoxNameFoeSearch.Size = new System.Drawing.Size(191, 22);
            this.textBoxNameFoeSearch.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(721, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(388, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 143);
            this.dataGridView1.TabIndex = 4;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(385, 90);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(85, 16);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Час пошуку:";
            // 
            // labelTime2
            // 
            this.labelTime2.AutoSize = true;
            this.labelTime2.Location = new System.Drawing.Point(743, 90);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(181, 16);
            this.labelTime2.TabIndex = 5;
            this.labelTime2.Text = "Час пошуку з дублікатами:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(388, 338);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(708, 141);
            this.dataGridView2.TabIndex = 4;
            // 
            // FormSearchInBST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 522);
            this.Controls.Add(this.labelTime2);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNameFoeSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "FormSearchInBST";
            this.Text = "FormSearchInBST";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameFoeSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTime2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}