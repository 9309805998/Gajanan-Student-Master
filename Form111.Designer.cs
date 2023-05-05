namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.txt01 = new System.Windows.Forms.TextBox();
            this.txt02 = new System.Windows.Forms.TextBox();
            this.txt03 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(72, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(85, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Student Roll No.";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Location = new System.Drawing.Point(75, 66);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(75, 13);
            this.lbl02.TabIndex = 1;
            this.lbl02.Text = "Student Name";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(75, 112);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(85, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Student Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Class";
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(143, 197);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(75, 23);
            this.btn01.TabIndex = 4;
            this.btn01.Text = "Save";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(289, 196);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(75, 24);
            this.btn02.TabIndex = 5;
            this.btn02.Text = "Delete";
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.btn02_Click);
            // 
            // txt01
            // 
            this.txt01.Location = new System.Drawing.Point(192, 24);
            this.txt01.Name = "txt01";
            this.txt01.Size = new System.Drawing.Size(100, 20);
            this.txt01.TabIndex = 6;
            // 
            // txt02
            // 
            this.txt02.Location = new System.Drawing.Point(192, 59);
            this.txt02.Name = "txt02";
            this.txt02.Size = new System.Drawing.Size(172, 20);
            this.txt02.TabIndex = 7;
            // 
            // txt03
            // 
            this.txt03.Location = new System.Drawing.Point(192, 112);
            this.txt03.Name = "txt03";
            this.txt03.Size = new System.Drawing.Size(172, 20);
            this.txt03.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Std. 1",
            "Std. 2",
            "Std. 3",
            "Std. 4"});
            this.listBox1.Location = new System.Drawing.Point(192, 158);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 17);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt03);
            this.Controls.Add(this.txt02);
            this.Controls.Add(this.txt01);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.TextBox txt01;
        private System.Windows.Forms.TextBox txt02;
        private System.Windows.Forms.TextBox txt03;
        private System.Windows.Forms.ListBox listBox1;
    }
}

