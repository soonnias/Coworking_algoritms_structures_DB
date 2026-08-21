namespace CoworkingV
{
    partial class PositionForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSearchPosition = new System.Windows.Forms.GroupBox();
            this.labelSearchedItemPosition = new System.Windows.Forms.RichTextBox();
            this.buttonSearchPosition = new System.Windows.Forms.Button();
            this.textBoxItemForSearchPosition = new System.Windows.Forms.TextBox();
            this.groupBoxMedianaPosition = new System.Windows.Forms.GroupBox();
            this.labelMediana = new System.Windows.Forms.Label();
            this.buttonMedianaPosition = new System.Windows.Forms.Button();
            this.groupBoxFindIndexPosition = new System.Windows.Forms.GroupBox();
            this.numericUpDownIndexPosition = new System.Windows.Forms.NumericUpDown();
            this.buttonByIbdexPosition = new System.Windows.Forms.Button();
            this.labelFindByIndexPosition = new System.Windows.Forms.Label();
            this.dataGridViewPosition = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTimePositionArray = new System.Windows.Forms.Label();
            this.groupBoxDeletePosition = new System.Windows.Forms.GroupBox();
            this.buttonDeleteFromStartPosition = new System.Windows.Forms.Button();
            this.buttonDeleteFromEndPosition = new System.Windows.Forms.Button();
            this.groupBoxInsertPosition = new System.Windows.Forms.GroupBox();
            this.labelNamePosition = new System.Windows.Forms.Label();
            this.textBoxForAddPosition = new System.Windows.Forms.TextBox();
            this.buttonInsertEndPosition = new System.Windows.Forms.Button();
            this.buttonInsertStartPosition = new System.Windows.Forms.Button();
            this.buttonSortIDPosition = new System.Windows.Forms.Button();
            this.buttonSortNamePosition = new System.Windows.Forms.Button();
            this.labelPosition = new System.Windows.Forms.Label();
            this.buttonSortId = new System.Windows.Forms.Button();
            this.groupBoxSearchPosition.SuspendLayout();
            this.groupBoxMedianaPosition.SuspendLayout();
            this.groupBoxFindIndexPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndexPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosition)).BeginInit();
            this.groupBoxDeletePosition.SuspendLayout();
            this.groupBoxInsertPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSearchPosition
            // 
            this.groupBoxSearchPosition.Controls.Add(this.labelSearchedItemPosition);
            this.groupBoxSearchPosition.Controls.Add(this.buttonSearchPosition);
            this.groupBoxSearchPosition.Controls.Add(this.textBoxItemForSearchPosition);
            this.groupBoxSearchPosition.Location = new System.Drawing.Point(660, 49);
            this.groupBoxSearchPosition.Name = "groupBoxSearchPosition";
            this.groupBoxSearchPosition.Size = new System.Drawing.Size(518, 119);
            this.groupBoxSearchPosition.TabIndex = 33;
            this.groupBoxSearchPosition.TabStop = false;
            this.groupBoxSearchPosition.Text = "Пошук";
            // 
            // labelSearchedItemPosition
            // 
            this.labelSearchedItemPosition.Location = new System.Drawing.Point(6, 51);
            this.labelSearchedItemPosition.Name = "labelSearchedItemPosition";
            this.labelSearchedItemPosition.ReadOnly = true;
            this.labelSearchedItemPosition.Size = new System.Drawing.Size(493, 62);
            this.labelSearchedItemPosition.TabIndex = 14;
            this.labelSearchedItemPosition.Text = "Знайдене значення:";
            // 
            // buttonSearchPosition
            // 
            this.buttonSearchPosition.Location = new System.Drawing.Point(6, 21);
            this.buttonSearchPosition.Name = "buttonSearchPosition";
            this.buttonSearchPosition.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchPosition.TabIndex = 6;
            this.buttonSearchPosition.Text = "Пошук";
            this.buttonSearchPosition.UseVisualStyleBackColor = true;
            this.buttonSearchPosition.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxItemForSearchPosition
            // 
            this.textBoxItemForSearchPosition.Location = new System.Drawing.Point(91, 22);
            this.textBoxItemForSearchPosition.Name = "textBoxItemForSearchPosition";
            this.textBoxItemForSearchPosition.Size = new System.Drawing.Size(151, 22);
            this.textBoxItemForSearchPosition.TabIndex = 13;
            // 
            // groupBoxMedianaPosition
            // 
            this.groupBoxMedianaPosition.Controls.Add(this.labelMediana);
            this.groupBoxMedianaPosition.Controls.Add(this.buttonMedianaPosition);
            this.groupBoxMedianaPosition.Location = new System.Drawing.Point(660, 174);
            this.groupBoxMedianaPosition.Name = "groupBoxMedianaPosition";
            this.groupBoxMedianaPosition.Size = new System.Drawing.Size(518, 100);
            this.groupBoxMedianaPosition.TabIndex = 32;
            this.groupBoxMedianaPosition.TabStop = false;
            this.groupBoxMedianaPosition.Text = "Медіана";
            // 
            // labelMediana
            // 
            this.labelMediana.AutoSize = true;
            this.labelMediana.Location = new System.Drawing.Point(11, 70);
            this.labelMediana.Name = "labelMediana";
            this.labelMediana.Size = new System.Drawing.Size(61, 16);
            this.labelMediana.TabIndex = 16;
            this.labelMediana.Text = "Медіана";
            // 
            // buttonMedianaPosition
            // 
            this.buttonMedianaPosition.Location = new System.Drawing.Point(9, 30);
            this.buttonMedianaPosition.Name = "buttonMedianaPosition";
            this.buttonMedianaPosition.Size = new System.Drawing.Size(75, 23);
            this.buttonMedianaPosition.TabIndex = 7;
            this.buttonMedianaPosition.Text = "Медіана";
            this.buttonMedianaPosition.UseVisualStyleBackColor = true;
            this.buttonMedianaPosition.Click += new System.EventHandler(this.buttonMediana_Click);
            // 
            // groupBoxFindIndexPosition
            // 
            this.groupBoxFindIndexPosition.Controls.Add(this.numericUpDownIndexPosition);
            this.groupBoxFindIndexPosition.Controls.Add(this.buttonByIbdexPosition);
            this.groupBoxFindIndexPosition.Controls.Add(this.labelFindByIndexPosition);
            this.groupBoxFindIndexPosition.Location = new System.Drawing.Point(799, 280);
            this.groupBoxFindIndexPosition.Name = "groupBoxFindIndexPosition";
            this.groupBoxFindIndexPosition.Size = new System.Drawing.Size(379, 100);
            this.groupBoxFindIndexPosition.TabIndex = 31;
            this.groupBoxFindIndexPosition.TabStop = false;
            this.groupBoxFindIndexPosition.Text = "Пошук за індексом";
            // 
            // numericUpDownIndexPosition
            // 
            this.numericUpDownIndexPosition.Location = new System.Drawing.Point(6, 31);
            this.numericUpDownIndexPosition.Name = "numericUpDownIndexPosition";
            this.numericUpDownIndexPosition.Size = new System.Drawing.Size(56, 22);
            this.numericUpDownIndexPosition.TabIndex = 15;
            // 
            // buttonByIbdexPosition
            // 
            this.buttonByIbdexPosition.Location = new System.Drawing.Point(73, 30);
            this.buttonByIbdexPosition.Name = "buttonByIbdexPosition";
            this.buttonByIbdexPosition.Size = new System.Drawing.Size(121, 23);
            this.buttonByIbdexPosition.TabIndex = 17;
            this.buttonByIbdexPosition.Text = "За індексом";
            this.buttonByIbdexPosition.UseVisualStyleBackColor = true;
            this.buttonByIbdexPosition.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelFindByIndexPosition
            // 
            this.labelFindByIndexPosition.AutoSize = true;
            this.labelFindByIndexPosition.Location = new System.Drawing.Point(6, 75);
            this.labelFindByIndexPosition.Name = "labelFindByIndexPosition";
            this.labelFindByIndexPosition.Size = new System.Drawing.Size(138, 16);
            this.labelFindByIndexPosition.TabIndex = 18;
            this.labelFindByIndexPosition.Text = "Знайдене значення";
            // 
            // dataGridViewPosition
            // 
            this.dataGridViewPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dataGridViewPosition.Location = new System.Drawing.Point(40, 115);
            this.dataGridViewPosition.Name = "dataGridViewPosition";
            this.dataGridViewPosition.RowHeadersVisible = false;
            this.dataGridViewPosition.RowHeadersWidth = 51;
            this.dataGridViewPosition.RowTemplate.Height = 24;
            this.dataGridViewPosition.Size = new System.Drawing.Size(504, 150);
            this.dataGridViewPosition.TabIndex = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // labelTimePositionArray
            // 
            this.labelTimePositionArray.AutoSize = true;
            this.labelTimePositionArray.Location = new System.Drawing.Point(36, 402);
            this.labelTimePositionArray.Name = "labelTimePositionArray";
            this.labelTimePositionArray.Size = new System.Drawing.Size(31, 16);
            this.labelTimePositionArray.TabIndex = 29;
            this.labelTimePositionArray.Text = "Час";
            // 
            // groupBoxDeletePosition
            // 
            this.groupBoxDeletePosition.Controls.Add(this.buttonDeleteFromStartPosition);
            this.groupBoxDeletePosition.Controls.Add(this.buttonDeleteFromEndPosition);
            this.groupBoxDeletePosition.Location = new System.Drawing.Point(539, 280);
            this.groupBoxDeletePosition.Name = "groupBoxDeletePosition";
            this.groupBoxDeletePosition.Size = new System.Drawing.Size(224, 100);
            this.groupBoxDeletePosition.TabIndex = 28;
            this.groupBoxDeletePosition.TabStop = false;
            this.groupBoxDeletePosition.Text = "Видалення";
            // 
            // buttonDeleteFromStartPosition
            // 
            this.buttonDeleteFromStartPosition.Location = new System.Drawing.Point(11, 29);
            this.buttonDeleteFromStartPosition.Name = "buttonDeleteFromStartPosition";
            this.buttonDeleteFromStartPosition.Size = new System.Drawing.Size(194, 23);
            this.buttonDeleteFromStartPosition.TabIndex = 4;
            this.buttonDeleteFromStartPosition.Text = "Видалити з початку";
            this.buttonDeleteFromStartPosition.UseVisualStyleBackColor = true;
            this.buttonDeleteFromStartPosition.Click += new System.EventHandler(this.buttonDeleteFromStart_Click);
            // 
            // buttonDeleteFromEndPosition
            // 
            this.buttonDeleteFromEndPosition.Location = new System.Drawing.Point(11, 57);
            this.buttonDeleteFromEndPosition.Name = "buttonDeleteFromEndPosition";
            this.buttonDeleteFromEndPosition.Size = new System.Drawing.Size(194, 23);
            this.buttonDeleteFromEndPosition.TabIndex = 5;
            this.buttonDeleteFromEndPosition.Text = "Видалити з кінця";
            this.buttonDeleteFromEndPosition.UseVisualStyleBackColor = true;
            this.buttonDeleteFromEndPosition.Click += new System.EventHandler(this.buttonDeleteFromEnd_Click);
            // 
            // groupBoxInsertPosition
            // 
            this.groupBoxInsertPosition.Controls.Add(this.labelNamePosition);
            this.groupBoxInsertPosition.Controls.Add(this.textBoxForAddPosition);
            this.groupBoxInsertPosition.Controls.Add(this.buttonInsertEndPosition);
            this.groupBoxInsertPosition.Controls.Add(this.buttonInsertStartPosition);
            this.groupBoxInsertPosition.Location = new System.Drawing.Point(30, 280);
            this.groupBoxInsertPosition.Name = "groupBoxInsertPosition";
            this.groupBoxInsertPosition.Size = new System.Drawing.Size(477, 100);
            this.groupBoxInsertPosition.TabIndex = 27;
            this.groupBoxInsertPosition.TabStop = false;
            this.groupBoxInsertPosition.Text = "Вставка";
            // 
            // labelNamePosition
            // 
            this.labelNamePosition.AutoSize = true;
            this.labelNamePosition.Location = new System.Drawing.Point(20, 29);
            this.labelNamePosition.Name = "labelNamePosition";
            this.labelNamePosition.Size = new System.Drawing.Size(102, 16);
            this.labelNamePosition.TabIndex = 11;
            this.labelNamePosition.Text = "Назва посади:";
            // 
            // textBoxForAddPosition
            // 
            this.textBoxForAddPosition.Location = new System.Drawing.Point(20, 58);
            this.textBoxForAddPosition.Name = "textBoxForAddPosition";
            this.textBoxForAddPosition.Size = new System.Drawing.Size(195, 22);
            this.textBoxForAddPosition.TabIndex = 10;
            // 
            // buttonInsertEndPosition
            // 
            this.buttonInsertEndPosition.Location = new System.Drawing.Point(256, 57);
            this.buttonInsertEndPosition.Name = "buttonInsertEndPosition";
            this.buttonInsertEndPosition.Size = new System.Drawing.Size(194, 23);
            this.buttonInsertEndPosition.TabIndex = 2;
            this.buttonInsertEndPosition.Text = "Вставка в кінець";
            this.buttonInsertEndPosition.UseVisualStyleBackColor = true;
            this.buttonInsertEndPosition.Click += new System.EventHandler(this.buttonInsertEnd_Click);
            // 
            // buttonInsertStartPosition
            // 
            this.buttonInsertStartPosition.Location = new System.Drawing.Point(256, 29);
            this.buttonInsertStartPosition.Name = "buttonInsertStartPosition";
            this.buttonInsertStartPosition.Size = new System.Drawing.Size(194, 23);
            this.buttonInsertStartPosition.TabIndex = 3;
            this.buttonInsertStartPosition.Text = "Вставка на початок";
            this.buttonInsertStartPosition.UseVisualStyleBackColor = true;
            this.buttonInsertStartPosition.Click += new System.EventHandler(this.buttonInsertStart_Click);
            // 
            // buttonSortIDPosition
            // 
            this.buttonSortIDPosition.Location = new System.Drawing.Point(12, 452);
            this.buttonSortIDPosition.Name = "buttonSortIDPosition";
            this.buttonSortIDPosition.Size = new System.Drawing.Size(162, 23);
            this.buttonSortIDPosition.TabIndex = 26;
            this.buttonSortIDPosition.Text = "Сортування по ID";
            this.buttonSortIDPosition.UseVisualStyleBackColor = true;
            this.buttonSortIDPosition.Visible = false;
            this.buttonSortIDPosition.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSortNamePosition
            // 
            this.buttonSortNamePosition.Location = new System.Drawing.Point(40, 70);
            this.buttonSortNamePosition.Name = "buttonSortNamePosition";
            this.buttonSortNamePosition.Size = new System.Drawing.Size(162, 23);
            this.buttonSortNamePosition.TabIndex = 25;
            this.buttonSortNamePosition.Text = "Сортування по назві";
            this.buttonSortNamePosition.UseVisualStyleBackColor = true;
            this.buttonSortNamePosition.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPosition.Location = new System.Drawing.Point(37, 30);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(86, 16);
            this.labelPosition.TabIndex = 24;
            this.labelPosition.Text = "Всі посади";
            // 
            // buttonSortId
            // 
            this.buttonSortId.Location = new System.Drawing.Point(218, 70);
            this.buttonSortId.Name = "buttonSortId";
            this.buttonSortId.Size = new System.Drawing.Size(162, 23);
            this.buttonSortId.TabIndex = 25;
            this.buttonSortId.Text = "Сортування по ID";
            this.buttonSortId.UseVisualStyleBackColor = true;
            this.buttonSortId.Click += new System.EventHandler(this.buttonSortId_Click);
            // 
            // PositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 440);
            this.Controls.Add(this.groupBoxSearchPosition);
            this.Controls.Add(this.groupBoxMedianaPosition);
            this.Controls.Add(this.groupBoxFindIndexPosition);
            this.Controls.Add(this.dataGridViewPosition);
            this.Controls.Add(this.labelTimePositionArray);
            this.Controls.Add(this.groupBoxDeletePosition);
            this.Controls.Add(this.groupBoxInsertPosition);
            this.Controls.Add(this.buttonSortIDPosition);
            this.Controls.Add(this.buttonSortId);
            this.Controls.Add(this.buttonSortNamePosition);
            this.Controls.Add(this.labelPosition);
            this.Name = "PositionForm";
            this.Text = "Coworking";
            this.groupBoxSearchPosition.ResumeLayout(false);
            this.groupBoxSearchPosition.PerformLayout();
            this.groupBoxMedianaPosition.ResumeLayout(false);
            this.groupBoxMedianaPosition.PerformLayout();
            this.groupBoxFindIndexPosition.ResumeLayout(false);
            this.groupBoxFindIndexPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndexPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosition)).EndInit();
            this.groupBoxDeletePosition.ResumeLayout(false);
            this.groupBoxInsertPosition.ResumeLayout(false);
            this.groupBoxInsertPosition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearchPosition;
        private System.Windows.Forms.Button buttonSearchPosition;
        private System.Windows.Forms.TextBox textBoxItemForSearchPosition;
        private System.Windows.Forms.GroupBox groupBoxMedianaPosition;
        private System.Windows.Forms.Label labelMediana;
        private System.Windows.Forms.Button buttonMedianaPosition;
        private System.Windows.Forms.GroupBox groupBoxFindIndexPosition;
        private System.Windows.Forms.NumericUpDown numericUpDownIndexPosition;
        private System.Windows.Forms.Button buttonByIbdexPosition;
        private System.Windows.Forms.Label labelFindByIndexPosition;
        private System.Windows.Forms.DataGridView dataGridViewPosition;
        private System.Windows.Forms.Label labelTimePositionArray;
        private System.Windows.Forms.GroupBox groupBoxDeletePosition;
        private System.Windows.Forms.Button buttonDeleteFromStartPosition;
        private System.Windows.Forms.Button buttonDeleteFromEndPosition;
        private System.Windows.Forms.GroupBox groupBoxInsertPosition;
        private System.Windows.Forms.Label labelNamePosition;
        private System.Windows.Forms.TextBox textBoxForAddPosition;
        private System.Windows.Forms.Button buttonInsertEndPosition;
        private System.Windows.Forms.Button buttonInsertStartPosition;
        private System.Windows.Forms.Button buttonSortIDPosition;
        private System.Windows.Forms.Button buttonSortNamePosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.RichTextBox labelSearchedItemPosition;
        private System.Windows.Forms.Button buttonSortId;
    }
}

