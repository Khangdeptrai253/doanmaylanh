namespace DoAnBanMayLanhNhomMu
{
    partial class frmQLMayLanh
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbomncc = new System.Windows.Forms.ComboBox();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txttenml = new System.Windows.Forms.TextBox();
            this.txtmaml = new System.Windows.Forms.TextBox();
            this.tx = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvQLML = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLML)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnlammoi);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbomncc);
            this.groupBox1.Controls.Add(this.txtgiaban);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.txttenml);
            this.groupBox1.Controls.Add(this.txtmaml);
            this.groupBox1.Controls.Add(this.tx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Máy Lạnh";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(534, 152);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(89, 29);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(400, 152);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(106, 29);
            this.btnlammoi.TabIndex = 5;
            this.btnlammoi.Text = "Làm Mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(286, 152);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(89, 29);
            this.btnsua.TabIndex = 5;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(173, 152);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(89, 29);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(56, 152);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(89, 29);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã NCC";
            // 
            // cbomncc
            // 
            this.cbomncc.FormattingEnabled = true;
            this.cbomncc.Location = new System.Drawing.Point(484, 68);
            this.cbomncc.Name = "cbomncc";
            this.cbomncc.Size = new System.Drawing.Size(139, 32);
            this.cbomncc.TabIndex = 3;
            this.cbomncc.SelectedIndexChanged += new System.EventHandler(this.cbomncc_SelectedIndexChanged);
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(484, 33);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(139, 29);
            this.txtgiaban.TabIndex = 2;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtsoluong.Location = new System.Drawing.Point(132, 111);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(227, 26);
            this.txtsoluong.TabIndex = 2;
            // 
            // txttenml
            // 
            this.txttenml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txttenml.Location = new System.Drawing.Point(132, 70);
            this.txttenml.Name = "txttenml";
            this.txttenml.Size = new System.Drawing.Size(227, 26);
            this.txttenml.TabIndex = 2;
            // 
            // txtmaml
            // 
            this.txtmaml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtmaml.Location = new System.Drawing.Point(132, 31);
            this.txtmaml.Name = "txtmaml";
            this.txtmaml.Size = new System.Drawing.Size(227, 26);
            this.txtmaml.TabIndex = 2;
            // 
            // tx
            // 
            this.tx.AutoSize = true;
            this.tx.Location = new System.Drawing.Point(365, 36);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(76, 24);
            this.tx.TabIndex = 1;
            this.tx.Text = "Giá Bán";
            this.tx.Click += new System.EventHandler(this.tx_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Máy Lạnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Máy Lạnh";
            // 
            // dtgvQLML
            // 
            this.dtgvQLML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLML.Location = new System.Drawing.Point(71, 187);
            this.dtgvQLML.Name = "dtgvQLML";
            this.dtgvQLML.Size = new System.Drawing.Size(552, 150);
            this.dtgvQLML.TabIndex = 1;
            // 
            // frmQLMayLanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 349);
            this.Controls.Add(this.dtgvQLML);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLMayLanh";
            this.Text = "frmQLMayLanh";
            this.Load += new System.EventHandler(this.frmQLMayLanh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLML)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbomncc;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.TextBox txttenml;
        private System.Windows.Forms.TextBox txtmaml;
        private System.Windows.Forms.Label tx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvQLML;
    }
}