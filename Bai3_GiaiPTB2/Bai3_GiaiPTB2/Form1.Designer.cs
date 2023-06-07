namespace Bai3_GiaiPTB2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnGiaiPT = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình Bậc 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập c:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(108, 55);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(512, 27);
            this.txtA.TabIndex = 4;
            this.txtA.Enter += new System.EventHandler(this.txtA_Enter);
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapSo_KeyPress);
            this.txtA.Leave += new System.EventHandler(this.txtA_Leave);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(108, 96);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(512, 27);
            this.txtB.TabIndex = 5;
            this.txtB.Enter += new System.EventHandler(this.txtA_Enter);
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapSo_KeyPress);
            this.txtB.Leave += new System.EventHandler(this.txtA_Leave);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(108, 131);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(512, 27);
            this.txtC.TabIndex = 6;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapSo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.SystemColors.Info;
            this.txtKetQua.ForeColor = System.Drawing.Color.Red;
            this.txtKetQua.Location = new System.Drawing.Point(107, 181);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtKetQua.Size = new System.Drawing.Size(512, 136);
            this.txtKetQua.TabIndex = 8;
            // 
            // btnGiaiPT
            // 
            this.btnGiaiPT.Location = new System.Drawing.Point(20, 345);
            this.btnGiaiPT.Name = "btnGiaiPT";
            this.btnGiaiPT.Size = new System.Drawing.Size(145, 39);
            this.btnGiaiPT.TabIndex = 9;
            this.btnGiaiPT.Text = "&Giải PT";
            this.btnGiaiPT.UseVisualStyleBackColor = true;
            this.btnGiaiPT.Click += new System.EventHandler(this.btnGiaiPT_Click);
            this.btnGiaiPT.MouseEnter += new System.EventHandler(this.btnGiaiPT_MouseEnter);
            this.btnGiaiPT.MouseLeave += new System.EventHandler(this.btnGiaiPT_MouseLeave);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(245, 345);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(145, 39);
            this.btnLamLai.TabIndex = 10;
            this.btnLamLai.Text = "&Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            this.btnLamLai.MouseEnter += new System.EventHandler(this.btnGiaiPT_MouseEnter);
            this.btnLamLai.MouseLeave += new System.EventHandler(this.btnGiaiPT_MouseLeave);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(474, 345);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 39);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.MouseEnter += new System.EventHandler(this.btnGiaiPT_MouseEnter);
            this.btnThoat.MouseLeave += new System.EventHandler(this.btnGiaiPT_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(649, 399);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnGiaiPT);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 3: Giải phương trình bậc 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnGiaiPT;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
    }
}

