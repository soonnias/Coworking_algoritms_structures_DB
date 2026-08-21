namespace CoworkingV
{
    partial class FormDesk
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
            this.dataGridViewDesk1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonDeleteFirst = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDesk2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDesk3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1q3 = new System.Windows.Forms.Label();
            this.label1q2 = new System.Windows.Forms.Label();
            this.labelDesk1q = new System.Windows.Forms.Label();
            this.buttonLookFirst = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelIsEmptyQueueL = new System.Windows.Forms.Label();
            this.labelIsEmptyQueueA = new System.Windows.Forms.Label();
            this.buttonCheckIsEmptyQueue = new System.Windows.Forms.Button();
            this.labelIsEmptyQueue = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonIsFullArray = new System.Windows.Forms.Button();
            this.labelArrayIsFull = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelSizeQueueL = new System.Windows.Forms.Label();
            this.labelSizeQueueA = new System.Windows.Forms.Label();
            this.buttonCountSizeQueue = new System.Windows.Forms.Button();
            this.labelSizeQueue = new System.Windows.Forms.Label();
            this.labelTimeQueue = new System.Windows.Forms.Label();
            this.labelTimeQueueArray = new System.Windows.Forms.Label();
            this.labelTimeQueueList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesk1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesk3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDesk1
            // 
            this.dataGridViewDesk1.AllowUserToAddRows = false;
            this.dataGridViewDesk1.AllowUserToDeleteRows = false;
            this.dataGridViewDesk1.AllowUserToResizeColumns = false;
            this.dataGridViewDesk1.AllowUserToResizeRows = false;
            this.dataGridViewDesk1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDesk1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewDesk1.Location = new System.Drawing.Point(55, 89);
            this.dataGridViewDesk1.Name = "dataGridViewDesk1";
            this.dataGridViewDesk1.ReadOnly = true;
            this.dataGridViewDesk1.RowHeadersVisible = false;
            this.dataGridViewDesk1.RowHeadersWidth = 51;
            this.dataGridViewDesk1.RowTemplate.Height = 24;
            this.dataGridViewDesk1.Size = new System.Drawing.Size(326, 129);
            this.dataGridViewDesk1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер стола";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Столи";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(46, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додавання елементу";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(9, 93);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(344, 39);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Додати в кінець черги";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Вільний",
            "Зайнятий",
            "Потребує прибирання",
            "Тимчасово недоступний"});
            this.comboBox1.Location = new System.Drawing.Point(155, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Доступність";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер столу";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(155, 25);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(119, 22);
            this.numericUpDown1.TabIndex = 0;
            // 
            // buttonDeleteFirst
            // 
            this.buttonDeleteFirst.Location = new System.Drawing.Point(30, 46);
            this.buttonDeleteFirst.Name = "buttonDeleteFirst";
            this.buttonDeleteFirst.Size = new System.Drawing.Size(204, 60);
            this.buttonDeleteFirst.TabIndex = 3;
            this.buttonDeleteFirst.Text = "Видалити з початку черги";
            this.buttonDeleteFirst.UseVisualStyleBackColor = true;
            this.buttonDeleteFirst.Click += new System.EventHandler(this.buttonDeleteFirst_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeleteFirst);
            this.groupBox2.Location = new System.Drawing.Point(466, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 138);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Видалення елементу";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // dataGridViewDesk2
            // 
            this.dataGridViewDesk2.AllowUserToAddRows = false;
            this.dataGridViewDesk2.AllowUserToDeleteRows = false;
            this.dataGridViewDesk2.AllowUserToResizeColumns = false;
            this.dataGridViewDesk2.AllowUserToResizeRows = false;
            this.dataGridViewDesk2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDesk2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewDesk2.Location = new System.Drawing.Point(431, 89);
            this.dataGridViewDesk2.Name = "dataGridViewDesk2";
            this.dataGridViewDesk2.ReadOnly = true;
            this.dataGridViewDesk2.RowHeadersVisible = false;
            this.dataGridViewDesk2.RowHeadersWidth = 51;
            this.dataGridViewDesk2.RowTemplate.Height = 24;
            this.dataGridViewDesk2.Size = new System.Drawing.Size(291, 129);
            this.dataGridViewDesk2.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер стола";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Доступність";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewDesk3
            // 
            this.dataGridViewDesk3.AllowUserToAddRows = false;
            this.dataGridViewDesk3.AllowUserToDeleteRows = false;
            this.dataGridViewDesk3.AllowUserToResizeColumns = false;
            this.dataGridViewDesk3.AllowUserToResizeRows = false;
            this.dataGridViewDesk3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDesk3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewDesk3.Location = new System.Drawing.Point(774, 89);
            this.dataGridViewDesk3.Name = "dataGridViewDesk3";
            this.dataGridViewDesk3.ReadOnly = true;
            this.dataGridViewDesk3.RowHeadersVisible = false;
            this.dataGridViewDesk3.RowHeadersWidth = 51;
            this.dataGridViewDesk3.RowTemplate.Height = 24;
            this.dataGridViewDesk3.Size = new System.Drawing.Size(303, 129);
            this.dataGridViewDesk3.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер стола";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Доступність";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(55, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Черга";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(428, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Черга на основі масиву";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(771, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Черга на основі зв\'яного списку";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1q3);
            this.groupBox3.Controls.Add(this.label1q2);
            this.groupBox3.Controls.Add(this.labelDesk1q);
            this.groupBox3.Controls.Add(this.buttonLookFirst);
            this.groupBox3.Location = new System.Drawing.Point(791, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 138);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Перегляд 1 елементу";
            // 
            // label1q3
            // 
            this.label1q3.AutoSize = true;
            this.label1q3.Location = new System.Drawing.Point(18, 68);
            this.label1q3.Name = "label1q3";
            this.label1q3.Size = new System.Drawing.Size(101, 16);
            this.label1q3.TabIndex = 8;
            this.label1q3.Text = "Черга/список: ";
            // 
            // label1q2
            // 
            this.label1q2.AutoSize = true;
            this.label1q2.Location = new System.Drawing.Point(18, 46);
            this.label1q2.Name = "label1q2";
            this.label1q2.Size = new System.Drawing.Size(96, 16);
            this.label1q2.TabIndex = 7;
            this.label1q2.Text = "Черга/масив: ";
            // 
            // labelDesk1q
            // 
            this.labelDesk1q.AutoSize = true;
            this.labelDesk1q.Location = new System.Drawing.Point(18, 25);
            this.labelDesk1q.Name = "labelDesk1q";
            this.labelDesk1q.Size = new System.Drawing.Size(52, 16);
            this.labelDesk1q.TabIndex = 6;
            this.labelDesk1q.Text = "Черга: ";
            // 
            // buttonLookFirst
            // 
            this.buttonLookFirst.Location = new System.Drawing.Point(21, 93);
            this.buttonLookFirst.Name = "buttonLookFirst";
            this.buttonLookFirst.Size = new System.Drawing.Size(235, 29);
            this.buttonLookFirst.TabIndex = 5;
            this.buttonLookFirst.Text = "Перегляд";
            this.buttonLookFirst.UseVisualStyleBackColor = true;
            this.buttonLookFirst.Click += new System.EventHandler(this.buttonLookFirst_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelIsEmptyQueueL);
            this.groupBox4.Controls.Add(this.labelIsEmptyQueueA);
            this.groupBox4.Controls.Add(this.buttonCheckIsEmptyQueue);
            this.groupBox4.Controls.Add(this.labelIsEmptyQueue);
            this.groupBox4.Location = new System.Drawing.Point(46, 444);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 103);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Чи черга порожня";
            // 
            // labelIsEmptyQueueL
            // 
            this.labelIsEmptyQueueL.AutoSize = true;
            this.labelIsEmptyQueueL.Location = new System.Drawing.Point(14, 73);
            this.labelIsEmptyQueueL.Name = "labelIsEmptyQueueL";
            this.labelIsEmptyQueueL.Size = new System.Drawing.Size(101, 16);
            this.labelIsEmptyQueueL.TabIndex = 3;
            this.labelIsEmptyQueueL.Text = "Черга/список: ";
            // 
            // labelIsEmptyQueueA
            // 
            this.labelIsEmptyQueueA.AutoSize = true;
            this.labelIsEmptyQueueA.Location = new System.Drawing.Point(14, 50);
            this.labelIsEmptyQueueA.Name = "labelIsEmptyQueueA";
            this.labelIsEmptyQueueA.Size = new System.Drawing.Size(96, 16);
            this.labelIsEmptyQueueA.TabIndex = 2;
            this.labelIsEmptyQueueA.Text = "Черга/масив: ";
            // 
            // buttonCheckIsEmptyQueue
            // 
            this.buttonCheckIsEmptyQueue.Location = new System.Drawing.Point(189, 34);
            this.buttonCheckIsEmptyQueue.Name = "buttonCheckIsEmptyQueue";
            this.buttonCheckIsEmptyQueue.Size = new System.Drawing.Size(146, 48);
            this.buttonCheckIsEmptyQueue.TabIndex = 1;
            this.buttonCheckIsEmptyQueue.Text = "Перевірити";
            this.buttonCheckIsEmptyQueue.UseVisualStyleBackColor = true;
            this.buttonCheckIsEmptyQueue.Click += new System.EventHandler(this.buttonCheckIsEmptyQueue_Click);
            // 
            // labelIsEmptyQueue
            // 
            this.labelIsEmptyQueue.AutoSize = true;
            this.labelIsEmptyQueue.Location = new System.Drawing.Point(14, 27);
            this.labelIsEmptyQueue.Name = "labelIsEmptyQueue";
            this.labelIsEmptyQueue.Size = new System.Drawing.Size(52, 16);
            this.labelIsEmptyQueue.TabIndex = 0;
            this.labelIsEmptyQueue.Text = "Черга: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonIsFullArray);
            this.groupBox5.Controls.Add(this.labelArrayIsFull);
            this.groupBox5.Location = new System.Drawing.Point(472, 444);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 103);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Перевірка на повноту(масив)";
            // 
            // buttonIsFullArray
            // 
            this.buttonIsFullArray.Location = new System.Drawing.Point(24, 66);
            this.buttonIsFullArray.Name = "buttonIsFullArray";
            this.buttonIsFullArray.Size = new System.Drawing.Size(204, 30);
            this.buttonIsFullArray.TabIndex = 1;
            this.buttonIsFullArray.Text = "Перевірити";
            this.buttonIsFullArray.UseVisualStyleBackColor = true;
            this.buttonIsFullArray.Click += new System.EventHandler(this.buttonIsFullArray_Click);
            // 
            // labelArrayIsFull
            // 
            this.labelArrayIsFull.AutoSize = true;
            this.labelArrayIsFull.Location = new System.Drawing.Point(21, 34);
            this.labelArrayIsFull.Name = "labelArrayIsFull";
            this.labelArrayIsFull.Size = new System.Drawing.Size(96, 16);
            this.labelArrayIsFull.TabIndex = 0;
            this.labelArrayIsFull.Text = "Черга/масив: ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelSizeQueueL);
            this.groupBox6.Controls.Add(this.labelSizeQueueA);
            this.groupBox6.Controls.Add(this.buttonCountSizeQueue);
            this.groupBox6.Controls.Add(this.labelSizeQueue);
            this.groupBox6.Location = new System.Drawing.Point(791, 444);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(273, 103);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Розмір черги";
            // 
            // labelSizeQueueL
            // 
            this.labelSizeQueueL.AutoSize = true;
            this.labelSizeQueueL.Location = new System.Drawing.Point(15, 73);
            this.labelSizeQueueL.Name = "labelSizeQueueL";
            this.labelSizeQueueL.Size = new System.Drawing.Size(98, 16);
            this.labelSizeQueueL.TabIndex = 4;
            this.labelSizeQueueL.Text = "Черга/список:";
            // 
            // labelSizeQueueA
            // 
            this.labelSizeQueueA.AutoSize = true;
            this.labelSizeQueueA.Location = new System.Drawing.Point(15, 50);
            this.labelSizeQueueA.Name = "labelSizeQueueA";
            this.labelSizeQueueA.Size = new System.Drawing.Size(93, 16);
            this.labelSizeQueueA.TabIndex = 3;
            this.labelSizeQueueA.Text = "Черга/масив:";
            // 
            // buttonCountSizeQueue
            // 
            this.buttonCountSizeQueue.Location = new System.Drawing.Point(161, 19);
            this.buttonCountSizeQueue.Name = "buttonCountSizeQueue";
            this.buttonCountSizeQueue.Size = new System.Drawing.Size(106, 32);
            this.buttonCountSizeQueue.TabIndex = 2;
            this.buttonCountSizeQueue.Text = "Порахувати";
            this.buttonCountSizeQueue.UseVisualStyleBackColor = true;
            this.buttonCountSizeQueue.Click += new System.EventHandler(this.buttonCountSizeQueue_Click);
            // 
            // labelSizeQueue
            // 
            this.labelSizeQueue.AutoSize = true;
            this.labelSizeQueue.Location = new System.Drawing.Point(15, 27);
            this.labelSizeQueue.Name = "labelSizeQueue";
            this.labelSizeQueue.Size = new System.Drawing.Size(52, 16);
            this.labelSizeQueue.TabIndex = 0;
            this.labelSizeQueue.Text = "Черга: ";
            // 
            // labelTimeQueue
            // 
            this.labelTimeQueue.AutoSize = true;
            this.labelTimeQueue.Location = new System.Drawing.Point(55, 236);
            this.labelTimeQueue.Name = "labelTimeQueue";
            this.labelTimeQueue.Size = new System.Drawing.Size(78, 16);
            this.labelTimeQueue.TabIndex = 14;
            this.labelTimeQueue.Text = "Час черга: ";
            // 
            // labelTimeQueueArray
            // 
            this.labelTimeQueueArray.AutoSize = true;
            this.labelTimeQueueArray.Location = new System.Drawing.Point(428, 236);
            this.labelTimeQueueArray.Name = "labelTimeQueueArray";
            this.labelTimeQueueArray.Size = new System.Drawing.Size(122, 16);
            this.labelTimeQueueArray.TabIndex = 15;
            this.labelTimeQueueArray.Text = "Час черга/масив: ";
            // 
            // labelTimeQueueList
            // 
            this.labelTimeQueueList.AutoSize = true;
            this.labelTimeQueueList.Location = new System.Drawing.Point(771, 236);
            this.labelTimeQueueList.Name = "labelTimeQueueList";
            this.labelTimeQueueList.Size = new System.Drawing.Size(127, 16);
            this.labelTimeQueueList.TabIndex = 16;
            this.labelTimeQueueList.Text = "Час черга/список: ";
            // 
            // FormDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 568);
            this.Controls.Add(this.labelTimeQueueList);
            this.Controls.Add(this.labelTimeQueueArray);
            this.Controls.Add(this.labelTimeQueue);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewDesk3);
            this.Controls.Add(this.dataGridViewDesk2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDesk1);
            this.Name = "FormDesk";
            this.Text = "FormDesk";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesk1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesk3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDesk1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDeleteFirst;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewDesk2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridViewDesk3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonLookFirst;
        private System.Windows.Forms.Label labelDesk1q;
        private System.Windows.Forms.Label label1q3;
        private System.Windows.Forms.Label label1q2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelIsEmptyQueue;
        private System.Windows.Forms.Button buttonCheckIsEmptyQueue;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonIsFullArray;
        private System.Windows.Forms.Label labelArrayIsFull;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonCountSizeQueue;
        private System.Windows.Forms.Label labelSizeQueue;
        private System.Windows.Forms.Label labelTimeQueue;
        private System.Windows.Forms.Label labelTimeQueueArray;
        private System.Windows.Forms.Label labelTimeQueueList;
        private System.Windows.Forms.Label labelIsEmptyQueueA;
        private System.Windows.Forms.Label labelIsEmptyQueueL;
        private System.Windows.Forms.Label labelSizeQueueA;
        private System.Windows.Forms.Label labelSizeQueueL;
    }
}