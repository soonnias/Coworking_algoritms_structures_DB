namespace CoworkingV
{
    partial class Plans
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSearchedPlan = new System.Windows.Forms.RichTextBox();
            this.buttonSerachPlanByName = new System.Windows.Forms.Button();
            this.textBoxForSearchPlan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelMedianaPlan = new System.Windows.Forms.RichTextBox();
            this.buttonMedianaPlan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelFindedIndexPlan = new System.Windows.Forms.RichTextBox();
            this.numericUpDownPlan = new System.Windows.Forms.NumericUpDown();
            this.buttonByIndexPlan = new System.Windows.Forms.Button();
            this.dataGridViewPlans = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.видалитиПланToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTimePlan = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteFromStartStartPlan = new System.Windows.Forms.Button();
            this.buttonDeleteFromEndPlan = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPricePlan = new System.Windows.Forms.TextBox();
            this.labelDescriptionPlan = new System.Windows.Forms.Label();
            this.textBoxDescriptionPlan = new System.Windows.Forms.TextBox();
            this.labelNamePlan = new System.Windows.Forms.Label();
            this.textBoxNamePlan = new System.Windows.Forms.TextBox();
            this.buttonAddToEndPlan = new System.Windows.Forms.Button();
            this.buttonAddToStartPlan = new System.Windows.Forms.Button();
            this.labelPlans = new System.Windows.Forms.Label();
            this.comboBoxSortPlan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlans)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSearchedPlan);
            this.groupBox1.Controls.Add(this.buttonSerachPlanByName);
            this.groupBox1.Controls.Add(this.textBoxForSearchPlan);
            this.groupBox1.Location = new System.Drawing.Point(567, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 119);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук за назвою";
            // 
            // labelSearchedPlan
            // 
            this.labelSearchedPlan.Location = new System.Drawing.Point(9, 51);
            this.labelSearchedPlan.Name = "labelSearchedPlan";
            this.labelSearchedPlan.ReadOnly = true;
            this.labelSearchedPlan.Size = new System.Drawing.Size(503, 62);
            this.labelSearchedPlan.TabIndex = 14;
            this.labelSearchedPlan.Text = "";
            // 
            // buttonSerachPlanByName
            // 
            this.buttonSerachPlanByName.Location = new System.Drawing.Point(6, 21);
            this.buttonSerachPlanByName.Name = "buttonSerachPlanByName";
            this.buttonSerachPlanByName.Size = new System.Drawing.Size(75, 23);
            this.buttonSerachPlanByName.TabIndex = 6;
            this.buttonSerachPlanByName.Text = "Пошук";
            this.buttonSerachPlanByName.UseVisualStyleBackColor = true;
            this.buttonSerachPlanByName.Click += new System.EventHandler(this.buttonSerachPlanByName_Click);
            // 
            // textBoxForSearchPlan
            // 
            this.textBoxForSearchPlan.Location = new System.Drawing.Point(91, 22);
            this.textBoxForSearchPlan.Name = "textBoxForSearchPlan";
            this.textBoxForSearchPlan.Size = new System.Drawing.Size(192, 22);
            this.textBoxForSearchPlan.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelMedianaPlan);
            this.groupBox2.Controls.Add(this.buttonMedianaPlan);
            this.groupBox2.Location = new System.Drawing.Point(31, 524);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 100);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Медіана";
            this.groupBox2.Visible = false;
            // 
            // labelMedianaPlan
            // 
            this.labelMedianaPlan.Location = new System.Drawing.Point(9, 60);
            this.labelMedianaPlan.Name = "labelMedianaPlan";
            this.labelMedianaPlan.ReadOnly = true;
            this.labelMedianaPlan.Size = new System.Drawing.Size(503, 34);
            this.labelMedianaPlan.TabIndex = 8;
            this.labelMedianaPlan.Text = "";
            // 
            // buttonMedianaPlan
            // 
            this.buttonMedianaPlan.Location = new System.Drawing.Point(9, 30);
            this.buttonMedianaPlan.Name = "buttonMedianaPlan";
            this.buttonMedianaPlan.Size = new System.Drawing.Size(75, 23);
            this.buttonMedianaPlan.TabIndex = 7;
            this.buttonMedianaPlan.Text = "Медіана";
            this.buttonMedianaPlan.UseVisualStyleBackColor = true;
            this.buttonMedianaPlan.Click += new System.EventHandler(this.buttonMedianaPlan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelFindedIndexPlan);
            this.groupBox3.Controls.Add(this.numericUpDownPlan);
            this.groupBox3.Controls.Add(this.buttonByIndexPlan);
            this.groupBox3.Location = new System.Drawing.Point(567, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 103);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пошук за індексом";
            // 
            // labelFindedIndexPlan
            // 
            this.labelFindedIndexPlan.Location = new System.Drawing.Point(9, 70);
            this.labelFindedIndexPlan.Name = "labelFindedIndexPlan";
            this.labelFindedIndexPlan.ReadOnly = true;
            this.labelFindedIndexPlan.Size = new System.Drawing.Size(503, 24);
            this.labelFindedIndexPlan.TabIndex = 18;
            this.labelFindedIndexPlan.Text = "";
            // 
            // numericUpDownPlan
            // 
            this.numericUpDownPlan.Location = new System.Drawing.Point(6, 31);
            this.numericUpDownPlan.Name = "numericUpDownPlan";
            this.numericUpDownPlan.Size = new System.Drawing.Size(56, 22);
            this.numericUpDownPlan.TabIndex = 15;
            // 
            // buttonByIndexPlan
            // 
            this.buttonByIndexPlan.Location = new System.Drawing.Point(73, 30);
            this.buttonByIndexPlan.Name = "buttonByIndexPlan";
            this.buttonByIndexPlan.Size = new System.Drawing.Size(121, 23);
            this.buttonByIndexPlan.TabIndex = 17;
            this.buttonByIndexPlan.Text = "За індексом";
            this.buttonByIndexPlan.UseVisualStyleBackColor = true;
            this.buttonByIndexPlan.Click += new System.EventHandler(this.buttonByIndexPlan_Click);
            // 
            // dataGridViewPlans
            // 
            this.dataGridViewPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column3,
            this.Column4});
            this.dataGridViewPlans.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewPlans.Location = new System.Drawing.Point(31, 119);
            this.dataGridViewPlans.Name = "dataGridViewPlans";
            this.dataGridViewPlans.RowHeadersVisible = false;
            this.dataGridViewPlans.RowHeadersWidth = 51;
            this.dataGridViewPlans.RowTemplate.Height = 24;
            this.dataGridViewPlans.Size = new System.Drawing.Size(508, 150);
            this.dataGridViewPlans.TabIndex = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видалитиПланToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // видалитиПланToolStripMenuItem
            // 
            this.видалитиПланToolStripMenuItem.Name = "видалитиПланToolStripMenuItem";
            this.видалитиПланToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.видалитиПланToolStripMenuItem.Text = "Видалити план";
            this.видалитиПланToolStripMenuItem.Click += new System.EventHandler(this.видалитиПланToolStripMenuItem_Click);
            // 
            // labelTimePlan
            // 
            this.labelTimePlan.AutoSize = true;
            this.labelTimePlan.Location = new System.Drawing.Point(172, 34);
            this.labelTimePlan.Name = "labelTimePlan";
            this.labelTimePlan.Size = new System.Drawing.Size(31, 16);
            this.labelTimePlan.TabIndex = 40;
            this.labelTimePlan.Text = "Час";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonDeleteFromStartStartPlan);
            this.groupBox4.Controls.Add(this.buttonDeleteFromEndPlan);
            this.groupBox4.Location = new System.Drawing.Point(567, 298);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 143);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Видалення";
            // 
            // buttonDeleteFromStartStartPlan
            // 
            this.buttonDeleteFromStartStartPlan.Location = new System.Drawing.Point(11, 57);
            this.buttonDeleteFromStartStartPlan.Name = "buttonDeleteFromStartStartPlan";
            this.buttonDeleteFromStartStartPlan.Size = new System.Drawing.Size(194, 23);
            this.buttonDeleteFromStartStartPlan.TabIndex = 4;
            this.buttonDeleteFromStartStartPlan.Text = "Видалити з початку";
            this.buttonDeleteFromStartStartPlan.UseVisualStyleBackColor = true;
            this.buttonDeleteFromStartStartPlan.Click += new System.EventHandler(this.buttonDeleteFromStartStartPlan_Click);
            // 
            // buttonDeleteFromEndPlan
            // 
            this.buttonDeleteFromEndPlan.Location = new System.Drawing.Point(11, 86);
            this.buttonDeleteFromEndPlan.Name = "buttonDeleteFromEndPlan";
            this.buttonDeleteFromEndPlan.Size = new System.Drawing.Size(194, 23);
            this.buttonDeleteFromEndPlan.TabIndex = 5;
            this.buttonDeleteFromEndPlan.Text = "Видалити з кінця";
            this.buttonDeleteFromEndPlan.UseVisualStyleBackColor = true;
            this.buttonDeleteFromEndPlan.Click += new System.EventHandler(this.buttonDeleteFromEndPlan_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelPrice);
            this.groupBox5.Controls.Add(this.textBoxPricePlan);
            this.groupBox5.Controls.Add(this.labelDescriptionPlan);
            this.groupBox5.Controls.Add(this.textBoxDescriptionPlan);
            this.groupBox5.Controls.Add(this.labelNamePlan);
            this.groupBox5.Controls.Add(this.textBoxNamePlan);
            this.groupBox5.Controls.Add(this.buttonAddToEndPlan);
            this.groupBox5.Controls.Add(this.buttonAddToStartPlan);
            this.groupBox5.Location = new System.Drawing.Point(21, 298);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(477, 143);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Вставка";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(23, 107);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(38, 16);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "Ціна:";
            // 
            // textBoxPricePlan
            // 
            this.textBoxPricePlan.Location = new System.Drawing.Point(91, 102);
            this.textBoxPricePlan.Name = "textBoxPricePlan";
            this.textBoxPricePlan.Size = new System.Drawing.Size(100, 22);
            this.textBoxPricePlan.TabIndex = 8;
            // 
            // labelDescriptionPlan
            // 
            this.labelDescriptionPlan.AutoSize = true;
            this.labelDescriptionPlan.Location = new System.Drawing.Point(23, 71);
            this.labelDescriptionPlan.Name = "labelDescriptionPlan";
            this.labelDescriptionPlan.Size = new System.Drawing.Size(43, 16);
            this.labelDescriptionPlan.TabIndex = 7;
            this.labelDescriptionPlan.Text = "Опис:";
            // 
            // textBoxDescriptionPlan
            // 
            this.textBoxDescriptionPlan.Location = new System.Drawing.Point(91, 66);
            this.textBoxDescriptionPlan.Name = "textBoxDescriptionPlan";
            this.textBoxDescriptionPlan.Size = new System.Drawing.Size(100, 22);
            this.textBoxDescriptionPlan.TabIndex = 6;
            // 
            // labelNamePlan
            // 
            this.labelNamePlan.AutoSize = true;
            this.labelNamePlan.Location = new System.Drawing.Point(23, 36);
            this.labelNamePlan.Name = "labelNamePlan";
            this.labelNamePlan.Size = new System.Drawing.Size(52, 16);
            this.labelNamePlan.TabIndex = 5;
            this.labelNamePlan.Text = "Назва:";
            // 
            // textBoxNamePlan
            // 
            this.textBoxNamePlan.Location = new System.Drawing.Point(91, 36);
            this.textBoxNamePlan.Name = "textBoxNamePlan";
            this.textBoxNamePlan.Size = new System.Drawing.Size(100, 22);
            this.textBoxNamePlan.TabIndex = 4;
            // 
            // buttonAddToEndPlan
            // 
            this.buttonAddToEndPlan.Location = new System.Drawing.Point(251, 86);
            this.buttonAddToEndPlan.Name = "buttonAddToEndPlan";
            this.buttonAddToEndPlan.Size = new System.Drawing.Size(194, 23);
            this.buttonAddToEndPlan.TabIndex = 2;
            this.buttonAddToEndPlan.Text = "Вставка в кінець";
            this.buttonAddToEndPlan.UseVisualStyleBackColor = true;
            this.buttonAddToEndPlan.Click += new System.EventHandler(this.buttonAddToEndPlan_Click);
            // 
            // buttonAddToStartPlan
            // 
            this.buttonAddToStartPlan.Location = new System.Drawing.Point(251, 57);
            this.buttonAddToStartPlan.Name = "buttonAddToStartPlan";
            this.buttonAddToStartPlan.Size = new System.Drawing.Size(194, 23);
            this.buttonAddToStartPlan.TabIndex = 3;
            this.buttonAddToStartPlan.Text = "Вставка на початок";
            this.buttonAddToStartPlan.UseVisualStyleBackColor = true;
            this.buttonAddToStartPlan.Click += new System.EventHandler(this.buttonAddToStartPlan_Click);
            // 
            // labelPlans
            // 
            this.labelPlans.AutoSize = true;
            this.labelPlans.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlans.Location = new System.Drawing.Point(28, 34);
            this.labelPlans.Name = "labelPlans";
            this.labelPlans.Size = new System.Drawing.Size(78, 16);
            this.labelPlans.TabIndex = 35;
            this.labelPlans.Text = "Всі плани";
            // 
            // comboBoxSortPlan
            // 
            this.comboBoxSortPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortPlan.FormattingEnabled = true;
            this.comboBoxSortPlan.Items.AddRange(new object[] {
            "Назва A-Я",
            "Назва Я-А",
            "Ціна min-max",
            "ЦІна max-min"});
            this.comboBoxSortPlan.Location = new System.Drawing.Point(143, 69);
            this.comboBoxSortPlan.Name = "comboBoxSortPlan";
            this.comboBoxSortPlan.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSortPlan.TabIndex = 46;
            this.comboBoxSortPlan.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortPlan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Сортування: ";
            // 
            // Plans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSortPlan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridViewPlans);
            this.Controls.Add(this.labelTimePlan);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.labelPlans);
            this.Name = "Plans";
            this.Text = "Plans";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlans)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSerachPlanByName;
        private System.Windows.Forms.TextBox textBoxForSearchPlan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonMedianaPlan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownPlan;
        private System.Windows.Forms.Button buttonByIndexPlan;
        private System.Windows.Forms.DataGridView dataGridViewPlans;
        private System.Windows.Forms.Label labelTimePlan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonDeleteFromStartStartPlan;
        private System.Windows.Forms.Button buttonDeleteFromEndPlan;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPricePlan;
        private System.Windows.Forms.Label labelDescriptionPlan;
        private System.Windows.Forms.TextBox textBoxDescriptionPlan;
        private System.Windows.Forms.Label labelNamePlan;
        private System.Windows.Forms.TextBox textBoxNamePlan;
        private System.Windows.Forms.Button buttonAddToEndPlan;
        private System.Windows.Forms.Button buttonAddToStartPlan;
        private System.Windows.Forms.Label labelPlans;
        private System.Windows.Forms.ComboBox comboBoxSortPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox labelSearchedPlan;
        private System.Windows.Forms.RichTextBox labelMedianaPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem видалитиПланToolStripMenuItem;
        private System.Windows.Forms.RichTextBox labelFindedIndexPlan;
    }
}