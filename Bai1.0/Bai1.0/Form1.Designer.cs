namespace Bai1._0
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKhuVuc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtDiemChuan = new System.Windows.Forms.TextBox();
            this.txtMon3 = new System.Windows.Forms.TextBox();
            this.txtMon2 = new System.Windows.Forms.TextBox();
            this.txtMon1 = new System.Windows.Forms.TextBox();
            this.txtSBD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDSTrungTuyen = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblThiSinh = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTrungTuyen = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKhuVuc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtDiemChuan);
            this.groupBox1.Controls.Add(this.txtMon3);
            this.groupBox1.Controls.Add(this.txtMon2);
            this.groupBox1.Controls.Add(this.txtMon1);
            this.groupBox1.Controls.Add(this.txtSBD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1096, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thí sinh";
            // 
            // txtKhuVuc
            // 
            this.txtKhuVuc.BackColor = System.Drawing.Color.LightGreen;
            this.txtKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhuVuc.ForeColor = System.Drawing.Color.Red;
            this.txtKhuVuc.Location = new System.Drawing.Point(662, 95);
            this.txtKhuVuc.MaxLength = 1;
            this.txtKhuVuc.Name = "txtKhuVuc";
            this.txtKhuVuc.Size = new System.Drawing.Size(402, 27);
            this.txtKhuVuc.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txtKhuVuc, "Nhập khu vực (1,2,3)");
            this.txtKhuVuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapSo_keyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(553, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Khu vực:";
            // 
            // txthoten
            // 
            this.txthoten.BackColor = System.Drawing.Color.LightGreen;
            this.txthoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.ForeColor = System.Drawing.Color.Red;
            this.txthoten.Location = new System.Drawing.Point(662, 18);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(402, 27);
            this.txthoten.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txthoten, "Nhập họ tên");
            this.txthoten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthoten_KeyPress);
            // 
            // txtDiemChuan
            // 
            this.txtDiemChuan.BackColor = System.Drawing.Color.Yellow;
            this.txtDiemChuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemChuan.ForeColor = System.Drawing.Color.Red;
            this.txtDiemChuan.Location = new System.Drawing.Point(662, 138);
            this.txtDiemChuan.MaxLength = 5;
            this.txtDiemChuan.Name = "txtDiemChuan";
            this.txtDiemChuan.Size = new System.Drawing.Size(402, 27);
            this.txtDiemChuan.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtDiemChuan, "Nhập điểm chuẩn (tối đa 2 chữ số thập phân)");
            this.txtDiemChuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapSo_keyPress);
            // 
            // txtMon3
            // 
            this.txtMon3.BackColor = System.Drawing.Color.LightGreen;
            this.txtMon3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMon3.ForeColor = System.Drawing.Color.Red;
            this.txtMon3.Location = new System.Drawing.Point(139, 95);
            this.txtMon3.MaxLength = 4;
            this.txtMon3.Name = "txtMon3";
            this.txtMon3.Size = new System.Drawing.Size(402, 27);
            this.txtMon3.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtMon3, "Nhập điểm 3 (tối đa 2 chữ số thập phân)");
            this.txtMon3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapSo_keyPress);
            // 
            // txtMon2
            // 
            this.txtMon2.BackColor = System.Drawing.Color.LightGreen;
            this.txtMon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMon2.ForeColor = System.Drawing.Color.Red;
            this.txtMon2.Location = new System.Drawing.Point(662, 55);
            this.txtMon2.MaxLength = 4;
            this.txtMon2.Name = "txtMon2";
            this.txtMon2.Size = new System.Drawing.Size(402, 27);
            this.txtMon2.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtMon2, "Nhập điểm 2 (tối đa 2 chữ số thập phân)");
            this.txtMon2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapSo_keyPress);
            // 
            // txtMon1
            // 
            this.txtMon1.BackColor = System.Drawing.Color.LightGreen;
            this.txtMon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMon1.ForeColor = System.Drawing.Color.Red;
            this.txtMon1.Location = new System.Drawing.Point(139, 55);
            this.txtMon1.MaxLength = 4;
            this.txtMon1.Name = "txtMon1";
            this.txtMon1.Size = new System.Drawing.Size(402, 27);
            this.txtMon1.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtMon1, "Nhập điểm 1 (tối đa 2 chữ số thập phân)");
            this.txtMon1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapSo_keyPress);
            // 
            // txtSBD
            // 
            this.txtSBD.BackColor = System.Drawing.Color.LightGreen;
            this.txtSBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSBD.ForeColor = System.Drawing.Color.Red;
            this.txtSBD.Location = new System.Drawing.Point(139, 18);
            this.txtSBD.Name = "txtSBD";
            this.txtSBD.Size = new System.Drawing.Size(402, 27);
            this.txtSBD.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtSBD, "Số báo danh bao gồm các số [0-9]");
            this.txtSBD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapSo_keyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(553, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điểm chuẩn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(553, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số báo danh:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnDSTrungTuyen);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 535);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1096, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(806, 19);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(258, 25);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDSTrungTuyen
            // 
            this.btnDSTrungTuyen.Location = new System.Drawing.Point(419, 19);
            this.btnDSTrungTuyen.Name = "btnDSTrungTuyen";
            this.btnDSTrungTuyen.Size = new System.Drawing.Size(255, 25);
            this.btnDSTrungTuyen.TabIndex = 3;
            this.btnDSTrungTuyen.Text = "&Danh sách trúng tuyển";
            this.btnDSTrungTuyen.UseVisualStyleBackColor = true;
            this.btnDSTrungTuyen.Click += new System.EventHandler(this.btnDSTrungTuyen_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(25, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(243, 25);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm thí sinh";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblThiSinh);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 360);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách thí sinh";
            // 
            // lblThiSinh
            // 
            this.lblThiSinh.AutoSize = true;
            this.lblThiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThiSinh.ForeColor = System.Drawing.Color.Red;
            this.lblThiSinh.Location = new System.Drawing.Point(11, 28);
            this.lblThiSinh.Name = "lblThiSinh";
            this.lblThiSinh.Size = new System.Drawing.Size(0, 20);
            this.lblThiSinh.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTrungTuyen);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(545, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 360);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách trúng tuyển";
            // 
            // lblTrungTuyen
            // 
            this.lblTrungTuyen.AutoSize = true;
            this.lblTrungTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrungTuyen.ForeColor = System.Drawing.Color.Red;
            this.lblTrungTuyen.Location = new System.Drawing.Point(8, 28);
            this.lblTrungTuyen.Name = "lblTrungTuyen";
            this.lblTrungTuyen.Size = new System.Drawing.Size(0, 20);
            this.lblTrungTuyen.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1096, 593);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài tập 1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtDiemChuan;
        private System.Windows.Forms.TextBox txtMon3;
        private System.Windows.Forms.TextBox txtMon2;
        private System.Windows.Forms.TextBox txtMon1;
        private System.Windows.Forms.TextBox txtSBD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDSTrungTuyen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtKhuVuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblThiSinh;
        private System.Windows.Forms.Label lblTrungTuyen;
    }
}

