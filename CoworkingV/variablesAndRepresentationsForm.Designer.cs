namespace CoworkingV
{
    partial class variablesAndRepresentationsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonVariablesPosition = new System.Windows.Forms.Button();
            this.buttonCreateViewPosition = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonSelectFromViewPosition = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.buttonUpdateViewPosition = new System.Windows.Forms.Button();
            this.buttonDeleteFromViewPosition = new System.Windows.Forms.Button();
            this.buttonDropViewPosition = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(471, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDropViewPosition);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonDeleteFromViewPosition);
            this.groupBox1.Controls.Add(this.buttonUpdateViewPosition);
            this.groupBox1.Controls.Add(this.buttonSelectFromViewPosition);
            this.groupBox1.Controls.Add(this.buttonCreateViewPosition);
            this.groupBox1.Controls.Add(this.buttonVariablesPosition);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(549, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 282);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Посади";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "create view";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "set @endNamePosition = \"адміністратор\";\r\nselect * from positions where name....";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // buttonVariablesPosition
            // 
            this.buttonVariablesPosition.Location = new System.Drawing.Point(297, 33);
            this.buttonVariablesPosition.Name = "buttonVariablesPosition";
            this.buttonVariablesPosition.Size = new System.Drawing.Size(112, 28);
            this.buttonVariablesPosition.TabIndex = 2;
            this.buttonVariablesPosition.Text = "click";
            this.buttonVariablesPosition.UseVisualStyleBackColor = true;
            this.buttonVariablesPosition.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCreateViewPosition
            // 
            this.buttonCreateViewPosition.Location = new System.Drawing.Point(297, 82);
            this.buttonCreateViewPosition.Name = "buttonCreateViewPosition";
            this.buttonCreateViewPosition.Size = new System.Drawing.Size(112, 28);
            this.buttonCreateViewPosition.TabIndex = 2;
            this.buttonCreateViewPosition.Text = "create";
            this.buttonCreateViewPosition.UseVisualStyleBackColor = true;
            this.buttonCreateViewPosition.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "select * from";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // buttonSelectFromViewPosition
            // 
            this.buttonSelectFromViewPosition.Location = new System.Drawing.Point(297, 121);
            this.buttonSelectFromViewPosition.Name = "buttonSelectFromViewPosition";
            this.buttonSelectFromViewPosition.Size = new System.Drawing.Size(112, 28);
            this.buttonSelectFromViewPosition.TabIndex = 2;
            this.buttonSelectFromViewPosition.Text = "select";
            this.buttonSelectFromViewPosition.UseVisualStyleBackColor = true;
            this.buttonSelectFromViewPosition.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "update ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "delete from";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 203);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "drop view";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(106, 242);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 8;
            // 
            // buttonUpdateViewPosition
            // 
            this.buttonUpdateViewPosition.Location = new System.Drawing.Point(297, 160);
            this.buttonUpdateViewPosition.Name = "buttonUpdateViewPosition";
            this.buttonUpdateViewPosition.Size = new System.Drawing.Size(112, 28);
            this.buttonUpdateViewPosition.TabIndex = 2;
            this.buttonUpdateViewPosition.Text = "update";
            this.buttonUpdateViewPosition.UseVisualStyleBackColor = true;
            this.buttonUpdateViewPosition.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDeleteFromViewPosition
            // 
            this.buttonDeleteFromViewPosition.Location = new System.Drawing.Point(297, 200);
            this.buttonDeleteFromViewPosition.Name = "buttonDeleteFromViewPosition";
            this.buttonDeleteFromViewPosition.Size = new System.Drawing.Size(112, 28);
            this.buttonDeleteFromViewPosition.TabIndex = 2;
            this.buttonDeleteFromViewPosition.Text = "delete";
            this.buttonDeleteFromViewPosition.UseVisualStyleBackColor = true;
            this.buttonDeleteFromViewPosition.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDropViewPosition
            // 
            this.buttonDropViewPosition.Location = new System.Drawing.Point(297, 236);
            this.buttonDropViewPosition.Name = "buttonDropViewPosition";
            this.buttonDropViewPosition.Size = new System.Drawing.Size(112, 28);
            this.buttonDropViewPosition.TabIndex = 10;
            this.buttonDropViewPosition.Text = "drop";
            this.buttonDropViewPosition.UseVisualStyleBackColor = true;
            // 
            // variablesAndRepresentationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "variablesAndRepresentationsForm";
            this.Text = "variablesAndRepresentationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonVariablesPosition;
        private System.Windows.Forms.Button buttonCreateViewPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSelectFromViewPosition;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button buttonUpdateViewPosition;
        private System.Windows.Forms.Button buttonDropViewPosition;
        private System.Windows.Forms.Button buttonDeleteFromViewPosition;
    }
}