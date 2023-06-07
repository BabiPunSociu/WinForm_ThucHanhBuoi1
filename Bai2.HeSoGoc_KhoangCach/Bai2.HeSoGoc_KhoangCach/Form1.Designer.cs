namespace Bai2.HeSoGoc_KhoangCach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeSoGoc = new System.Windows.Forms.TextBox();
            this.txtKhoangCach = new System.Windows.Forms.TextBox();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtY1);
            this.groupBox1.Controls.Add(this.txtX1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điểm thứ nhất";
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(70, 91);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(284, 27);
            this.txtY1.TabIndex = 3;
            this.txtY1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapSo_KeyPress);
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(70, 36);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(284, 27);
            this.txtX1.TabIndex = 2;
            this.txtX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapSo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtX2);
            this.groupBox2.Controls.Add(this.txtY2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(413, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điểm thứ hai";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(60, 36);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(284, 27);
            this.txtX2.TabIndex = 4;
            this.txtX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapSo_KeyPress);
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(60, 91);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(284, 27);
            this.txtY2.TabIndex = 5;
            this.txtY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapSo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hệ số góc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Khoảng cách";
            // 
            // txtHeSoGoc
            // 
            this.txtHeSoGoc.Location = new System.Drawing.Point(81, 212);
            this.txtHeSoGoc.Name = "txtHeSoGoc";
            this.txtHeSoGoc.ReadOnly = true;
            this.txtHeSoGoc.Size = new System.Drawing.Size(284, 27);
            this.txtHeSoGoc.TabIndex = 4;
            // 
            // txtKhoangCach
            // 
            this.txtKhoangCach.Location = new System.Drawing.Point(473, 212);
            this.txtKhoangCach.Name = "txtKhoangCach";
            this.txtKhoangCach.ReadOnly = true;
            this.txtKhoangCach.Size = new System.Drawing.Size(284, 27);
            this.txtKhoangCach.TabIndex = 5;
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.Location = new System.Drawing.Point(276, 275);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(234, 36);
            this.btnTinhToan.TabIndex = 6;
            this.btnTinhToan.Text = "&Tính toán";
            this.btnTinhToan.UseVisualStyleBackColor = true;
            this.btnTinhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(803, 323);
            this.Controls.Add(this.btnTinhToan);
            this.Controls.Add(this.txtKhoangCach);
            this.Controls.Add(this.txtHeSoGoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 2: Hệ số góc & Khoảng cách";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHeSoGoc;
        private System.Windows.Forms.TextBox txtKhoangCach;
        private System.Windows.Forms.Button btnTinhToan;
    }
}

