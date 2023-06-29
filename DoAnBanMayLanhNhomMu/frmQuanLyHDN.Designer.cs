namespace DoAnBanMayLanhNhomMu
{
    partial class frmQuanLyHDN
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.cbomancc = new System.Windows.Forms.ComboBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtmaml = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtmahoadon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvHDNhap = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHDNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnlammoi);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.cbomancc);
            this.groupBox1.Controls.Add(this.txttongtien);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txtmaml);
            this.groupBox1.Controls.Add(this.txtdongia);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.txtmahoadon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Hóa Đơn Nhập";
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnthoat.Location = new System.Drawing.Point(804, 161);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(88, 32);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlammoi.Location = new System.Drawing.Point(667, 161);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(88, 32);
            this.btnlammoi.TabIndex = 3;
            this.btnlammoi.Text = "Làm Mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnsua.Location = new System.Drawing.Point(535, 161);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(88, 32);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnxoa.Location = new System.Drawing.Point(407, 161);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(88, 32);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnthem.Location = new System.Drawing.Point(275, 161);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(88, 32);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cbomancc
            // 
            this.cbomancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbomancc.FormattingEnabled = true;
            this.cbomancc.Location = new System.Drawing.Point(484, 44);
            this.cbomancc.Name = "cbomancc";
            this.cbomancc.Size = new System.Drawing.Size(170, 28);
            this.cbomancc.TabIndex = 2;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtdiachi.Location = new System.Drawing.Point(761, 93);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(166, 26);
            this.txtdiachi.TabIndex = 1;
            // 
            // txtmaml
            // 
            this.txtmaml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtmaml.Location = new System.Drawing.Point(484, 93);
            this.txtmaml.Name = "txtmaml";
            this.txtmaml.Size = new System.Drawing.Size(170, 26);
            this.txtmaml.TabIndex = 1;
            // 
            // txtdongia
            // 
            this.txtdongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtdongia.Location = new System.Drawing.Point(484, 133);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(170, 26);
            this.txtdongia.TabIndex = 1;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtsoluong.Location = new System.Drawing.Point(141, 129);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(174, 26);
            this.txtsoluong.TabIndex = 1;
            // 
            // txtmanv
            // 
            this.txtmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtmanv.Location = new System.Drawing.Point(141, 89);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(174, 26);
            this.txtmanv.TabIndex = 1;
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtmahoadon.Location = new System.Drawing.Point(141, 44);
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.Size = new System.Drawing.Size(174, 26);
            this.txtmahoadon.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(677, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa Chỉ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(677, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày Bán";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(339, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã Nhà Cung Cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(354, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Máy Lạnh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(354, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(22, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Lượng";
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.m.Location = new System.Drawing.Point(22, 92);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(109, 20);
            this.m.TabIndex = 0;
            this.m.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // dtgvHDNhap
            // 
            this.dtgvHDNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHDNhap.Location = new System.Drawing.Point(50, 221);
            this.dtgvHDNhap.Name = "dtgvHDNhap";
            this.dtgvHDNhap.Size = new System.Drawing.Size(869, 150);
            this.dtgvHDNhap.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(761, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(677, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng Tiền";
            this.label3.Click += new System.EventHandler(this.label8_Click);
            // 
            // txttongtien
            // 
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txttongtien.Location = new System.Drawing.Point(761, 125);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(166, 26);
            this.txttongtien.TabIndex = 1;
            // 
            // frmQuanLyHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 450);
            this.Controls.Add(this.dtgvHDNhap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLyHDN";
            this.Text = "frmQuanLyHDN";
            this.Load += new System.EventHandler(this.frmQuanLyHDN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHDNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbomancc;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtmaml;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txtmahoadon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label m;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvHDNhap;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label3;
    }
}