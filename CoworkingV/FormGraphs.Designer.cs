namespace CoworkingV
{
    partial class FormGraphs
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddV = new System.Windows.Forms.Button();
            this.comboBox1Add = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteV = new System.Windows.Forms.Button();
            this.textBoxAcDelete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxForDeleteV = new System.Windows.Forms.ComboBox();
            this.dataGridViewVertex = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAddEdge = new System.Windows.Forms.Button();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSecondA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSecondV = new System.Windows.Forms.ComboBox();
            this.textBoxFisrtA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxFirstV = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonDeketeEdge = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxDeleteS = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxDeleteF = new System.Windows.Forms.ComboBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVertex)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Граф зі столами";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddV);
            this.groupBox1.Controls.Add(this.comboBox1Add);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(35, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати нову вершину";
            // 
            // buttonAddV
            // 
            this.buttonAddV.Location = new System.Drawing.Point(6, 123);
            this.buttonAddV.Name = "buttonAddV";
            this.buttonAddV.Size = new System.Drawing.Size(292, 32);
            this.buttonAddV.TabIndex = 8;
            this.buttonAddV.Text = "Додати вершину";
            this.buttonAddV.UseVisualStyleBackColor = true;
            this.buttonAddV.Click += new System.EventHandler(this.buttonAddV_Click);
            // 
            // comboBox1Add
            // 
            this.comboBox1Add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1Add.FormattingEnabled = true;
            this.comboBox1Add.Items.AddRange(new object[] {
            "Вільний",
            "Зайнятий",
            "Потребує прибирання",
            "Тимчасово недоступний"});
            this.comboBox1Add.Location = new System.Drawing.Point(168, 81);
            this.comboBox1Add.Name = "comboBox1Add";
            this.comboBox1Add.Size = new System.Drawing.Size(121, 24);
            this.comboBox1Add.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Доступність";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер столу";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(168, 50);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(119, 22);
            this.numericUpDown1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeleteV);
            this.groupBox2.Controls.Add(this.textBoxAcDelete);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxForDeleteV);
            this.groupBox2.Location = new System.Drawing.Point(418, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 161);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Видалити вершину";
            // 
            // buttonDeleteV
            // 
            this.buttonDeleteV.Location = new System.Drawing.Point(6, 126);
            this.buttonDeleteV.Name = "buttonDeleteV";
            this.buttonDeleteV.Size = new System.Drawing.Size(292, 29);
            this.buttonDeleteV.TabIndex = 11;
            this.buttonDeleteV.Text = "Видалити вершину";
            this.buttonDeleteV.UseVisualStyleBackColor = true;
            this.buttonDeleteV.Click += new System.EventHandler(this.buttonDeleteV_Click);
            // 
            // textBoxAcDelete
            // 
            this.textBoxAcDelete.Location = new System.Drawing.Point(143, 81);
            this.textBoxAcDelete.Name = "textBoxAcDelete";
            this.textBoxAcDelete.ReadOnly = true;
            this.textBoxAcDelete.Size = new System.Drawing.Size(121, 22);
            this.textBoxAcDelete.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Доступність";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Номер столу";
            // 
            // comboBoxForDeleteV
            // 
            this.comboBoxForDeleteV.FormattingEnabled = true;
            this.comboBoxForDeleteV.Location = new System.Drawing.Point(143, 50);
            this.comboBoxForDeleteV.Name = "comboBoxForDeleteV";
            this.comboBoxForDeleteV.Size = new System.Drawing.Size(121, 24);
            this.comboBoxForDeleteV.TabIndex = 0;
            this.comboBoxForDeleteV.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dataGridViewVertex
            // 
            this.dataGridViewVertex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVertex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewVertex.Location = new System.Drawing.Point(798, 77);
            this.dataGridViewVertex.Name = "dataGridViewVertex";
            this.dataGridViewVertex.ReadOnly = true;
            this.dataGridViewVertex.RowHeadersVisible = false;
            this.dataGridViewVertex.RowHeadersWidth = 51;
            this.dataGridViewVertex.RowTemplate.Height = 24;
            this.dataGridViewVertex.Size = new System.Drawing.Size(353, 150);
            this.dataGridViewVertex.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Доступність";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAddEdge);
            this.groupBox3.Controls.Add(this.textBoxWeight);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxSecondA);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.comboBoxSecondV);
            this.groupBox3.Controls.Add(this.textBoxFisrtA);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBoxFirstV);
            this.groupBox3.Location = new System.Drawing.Point(35, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(572, 191);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Додати ребро";
            // 
            // buttonAddEdge
            // 
            this.buttonAddEdge.Location = new System.Drawing.Point(310, 117);
            this.buttonAddEdge.Name = "buttonAddEdge";
            this.buttonAddEdge.Size = new System.Drawing.Size(240, 23);
            this.buttonAddEdge.TabIndex = 21;
            this.buttonAddEdge.Text = "Додати ребро";
            this.buttonAddEdge.UseVisualStyleBackColor = true;
            this.buttonAddEdge.Click += new System.EventHandler(this.buttonAddEdge_Click);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(141, 117);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxWeight.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Відстань(м):";
            // 
            // textBoxSecondA
            // 
            this.textBoxSecondA.Location = new System.Drawing.Point(429, 75);
            this.textBoxSecondA.Name = "textBoxSecondA";
            this.textBoxSecondA.ReadOnly = true;
            this.textBoxSecondA.Size = new System.Drawing.Size(121, 22);
            this.textBoxSecondA.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Доступність";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Номер столу";
            // 
            // comboBoxSecondV
            // 
            this.comboBoxSecondV.FormattingEnabled = true;
            this.comboBoxSecondV.Location = new System.Drawing.Point(429, 44);
            this.comboBoxSecondV.Name = "comboBoxSecondV";
            this.comboBoxSecondV.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSecondV.TabIndex = 15;
            this.comboBoxSecondV.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecondV_SelectedIndexChanged);
            // 
            // textBoxFisrtA
            // 
            this.textBoxFisrtA.Location = new System.Drawing.Point(141, 75);
            this.textBoxFisrtA.Name = "textBoxFisrtA";
            this.textBoxFisrtA.ReadOnly = true;
            this.textBoxFisrtA.Size = new System.Drawing.Size(121, 22);
            this.textBoxFisrtA.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Доступність";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Номер столу";
            // 
            // comboBoxFirstV
            // 
            this.comboBoxFirstV.FormattingEnabled = true;
            this.comboBoxFirstV.Location = new System.Drawing.Point(141, 45);
            this.comboBoxFirstV.Name = "comboBoxFirstV";
            this.comboBoxFirstV.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFirstV.TabIndex = 11;
            this.comboBoxFirstV.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirstV_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(798, 287);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(353, 310);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonDeketeEdge);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.comboBoxDeleteS);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.comboBoxDeleteF);
            this.groupBox4.Location = new System.Drawing.Point(35, 503);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(572, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Видалити ребро";
            // 
            // buttonDeketeEdge
            // 
            this.buttonDeketeEdge.Location = new System.Drawing.Point(311, 60);
            this.buttonDeketeEdge.Name = "buttonDeketeEdge";
            this.buttonDeketeEdge.Size = new System.Drawing.Size(240, 23);
            this.buttonDeketeEdge.TabIndex = 22;
            this.buttonDeketeEdge.Text = "Видалити ребро";
            this.buttonDeketeEdge.UseVisualStyleBackColor = true;
            this.buttonDeketeEdge.Click += new System.EventHandler(this.buttonDeketeEdge_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(308, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Номер столу";
            // 
            // comboBoxDeleteS
            // 
            this.comboBoxDeleteS.FormattingEnabled = true;
            this.comboBoxDeleteS.Location = new System.Drawing.Point(430, 30);
            this.comboBoxDeleteS.Name = "comboBoxDeleteS";
            this.comboBoxDeleteS.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDeleteS.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Номер столу";
            // 
            // comboBoxDeleteF
            // 
            this.comboBoxDeleteF.FormattingEnabled = true;
            this.comboBoxDeleteF.Location = new System.Drawing.Point(142, 31);
            this.comboBoxDeleteF.Name = "comboBoxDeleteF";
            this.comboBoxDeleteF.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDeleteF.TabIndex = 18;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(798, 247);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(37, 16);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "Час: ";
            // 
            // FormGraphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 623);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridViewVertex);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormGraphs";
            this.Text = "FormGraphs";
            this.Load += new System.EventHandler(this.FormGraphs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVertex)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddV;
        private System.Windows.Forms.ComboBox comboBox1Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxForDeleteV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDeleteV;
        private System.Windows.Forms.TextBox textBoxAcDelete;
        private System.Windows.Forms.DataGridView dataGridViewVertex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxSecondA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxSecondV;
        private System.Windows.Forms.TextBox textBoxFisrtA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxFirstV;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAddEdge;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonDeketeEdge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxDeleteS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxDeleteF;
        private System.Windows.Forms.Label labelTime;
    }
}