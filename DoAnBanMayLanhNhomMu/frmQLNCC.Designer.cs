namespace DoAnBanMayLanhNhomMu
{
    partial class frmQLNCC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvqlncc = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.txtmncc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvqlncc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.dtgvqlncc);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnlammoi);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txttenncc);
            this.groupBox1.Controls.Add(this.txtmncc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Nhà Cung Cấp";
            // 
            // dtgvqlncc
            // 
            this.dtgvqlncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvqlncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvqlncc.Location = new System.Drawing.Point(6, 183);
            this.dtgvqlncc.Name = "dtgvqlncc";
            this.dtgvqlncc.Size = new System.Drawing.Size(834, 159);
            this.dtgvqlncc.TabIndex = 3;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(577, 141);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(92, 36);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlammoi.Location = new System.Drawing.Point(419, 141);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(113, 36);
            this.btnlammoi.TabIndex = 2;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnsua.Location = new System.Drawing.Point(302, 141);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(92, 36);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnxoa.Location = new System.Drawing.Point(183, 141);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(92, 36);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnthem.Location = new System.Drawing.Point(61, 141);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(92, 36);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtdiachi.Location = new System.Drawing.Point(613, 98);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(153, 29);
            this.txtdiachi.TabIndex = 1;
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtsdt.Location = new System.Drawing.Point(613, 46);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(153, 29);
            this.txtsdt.TabIndex = 1;
            // 
            // txttenncc
            // 
            this.txttenncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txttenncc.Location = new System.Drawing.Point(212, 93);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(199, 29);
            this.txttenncc.TabIndex = 1;
            // 
            // txtmncc
            // 
            this.txtmncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtmncc.Location = new System.Drawing.Point(212, 38);
            this.txtmncc.Name = "txtmncc";
            this.txtmncc.Size = new System.Drawing.Size(199, 29);
            this.txtmncc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(441, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(441, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Nhà Cung Cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhà Cung Cấp";
            // 
            // frmQLNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 352);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLNCC";
            this.Text = "frmQLNCC";
            this.Load += new System.EventHandler(this.frmQLNCC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvqlncc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvqlncc;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.TextBox txtmncc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}