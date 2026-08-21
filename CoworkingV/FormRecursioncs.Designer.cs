namespace CoworkingV
{
    partial class FormRecursioncs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelRec1 = new System.Windows.Forms.Label();
            this.labelJust1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelJust2 = new System.Windows.Forms.Label();
            this.labelRec2 = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelJust3 = new System.Windows.Forms.Label();
            this.labelRec3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTimeRec = new System.Windows.Forms.Label();
            this.labelTimeJust = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(41, 29);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(416, 479);
            this.treeView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelJust1);
            this.groupBox1.Controls.Add(this.labelRec1);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Location = new System.Drawing.Point(520, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 103);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук найменшого елемента в дереві";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(372, 34);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(113, 48);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelRec1
            // 
            this.labelRec1.AutoSize = true;
            this.labelRec1.Location = new System.Drawing.Point(20, 34);
            this.labelRec1.Name = "labelRec1";
            this.labelRec1.Size = new System.Drawing.Size(140, 16);
            this.labelRec1.TabIndex = 1;
            this.labelRec1.Text = "Рекурсивний пошук:";
            // 
            // labelJust1
            // 
            this.labelJust1.AutoSize = true;
            this.labelJust1.Location = new System.Drawing.Point(20, 66);
            this.labelJust1.Name = "labelJust1";
            this.labelJust1.Size = new System.Drawing.Size(126, 16);
            this.labelJust1.TabIndex = 2;
            this.labelJust1.Text = "Звичайний пошук:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelJust2);
            this.groupBox2.Controls.Add(this.labelRec2);
            this.groupBox2.Controls.Add(this.buttonGo);
            this.groupBox2.Location = new System.Drawing.Point(523, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 103);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обхід дерева у прямому порядку";
            // 
            // labelJust2
            // 
            this.labelJust2.AutoSize = true;
            this.labelJust2.Location = new System.Drawing.Point(20, 66);
            this.labelJust2.Name = "labelJust2";
            this.labelJust2.Size = new System.Drawing.Size(119, 16);
            this.labelJust2.TabIndex = 2;
            this.labelJust2.Text = "Звичайний обхід:";
            // 
            // labelRec2
            // 
            this.labelRec2.AutoSize = true;
            this.labelRec2.Location = new System.Drawing.Point(20, 34);
            this.labelRec2.Name = "labelRec2";
            this.labelRec2.Size = new System.Drawing.Size(133, 16);
            this.labelRec2.TabIndex = 1;
            this.labelRec2.Text = "Рекурсивний обхід:";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(372, 34);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(113, 48);
            this.buttonGo.TabIndex = 0;
            this.buttonGo.Text = "Обхід";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelJust3);
            this.groupBox3.Controls.Add(this.labelRec3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(520, 405);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 103);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кількість елементів у дереві";
            // 
            // labelJust3
            // 
            this.labelJust3.AutoSize = true;
            this.labelJust3.Location = new System.Drawing.Point(20, 66);
            this.labelJust3.Name = "labelJust3";
            this.labelJust3.Size = new System.Drawing.Size(183, 16);
            this.labelJust3.TabIndex = 2;
            this.labelJust3.Text = "Звичайний обрахунок к-ть:";
            // 
            // labelRec3
            // 
            this.labelRec3.AutoSize = true;
            this.labelRec3.Location = new System.Drawing.Point(20, 34);
            this.labelRec3.Name = "labelRec3";
            this.labelRec3.Size = new System.Drawing.Size(200, 16);
            this.labelRec3.TabIndex = 1;
            this.labelRec3.Text = "Рекурсивний обрахунок к-ть: \r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Порахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelTimeRec
            // 
            this.labelTimeRec.AutoSize = true;
            this.labelTimeRec.Location = new System.Drawing.Point(520, 38);
            this.labelTimeRec.Name = "labelTimeRec";
            this.labelTimeRec.Size = new System.Drawing.Size(118, 16);
            this.labelTimeRec.TabIndex = 5;
            this.labelTimeRec.Text = "Час рекурсивної:";
            // 
            // labelTimeJust
            // 
            this.labelTimeJust.AutoSize = true;
            this.labelTimeJust.Location = new System.Drawing.Point(793, 38);
            this.labelTimeJust.Name = "labelTimeJust";
            this.labelTimeJust.Size = new System.Drawing.Size(68, 16);
            this.labelTimeJust.TabIndex = 6;
            this.labelTimeJust.Text = "Час іншої:";
            // 
            // FormRecursioncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 543);
            this.Controls.Add(this.labelTimeJust);
            this.Controls.Add(this.labelTimeRec);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "FormRecursioncs";
            this.Text = "FormRecursioncs";
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

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelJust1;
        private System.Windows.Forms.Label labelRec1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelJust2;
        private System.Windows.Forms.Label labelRec2;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelJust3;
        private System.Windows.Forms.Label labelRec3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTimeRec;
        private System.Windows.Forms.Label labelTimeJust;
    }
}