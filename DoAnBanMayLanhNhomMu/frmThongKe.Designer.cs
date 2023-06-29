namespace DoAnBanMayLanhNhomMu
{
    partial class frmThongKe
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
            this.btnThongKe = new System.Windows.Forms.Button();
            this.rdohdban = new System.Windows.Forms.RadioButton();
            this.rdohdnhap = new System.Windows.Forms.RadioButton();
            this.mskthangnam = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvThongKe = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.rdohdban);
            this.groupBox1.Controls.Add(this.rdohdnhap);
            this.groupBox1.Controls.Add(this.mskthangnam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê";
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnthoat.Location = new System.Drawing.Point(317, 152);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(122, 37);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThongKe.Location = new System.Drawing.Point(155, 150);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(123, 39);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // rdohdban
            // 
            this.rdohdban.AutoSize = true;
            this.rdohdban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdohdban.Location = new System.Drawing.Point(411, 93);
            this.rdohdban.Name = "rdohdban";
            this.rdohdban.Size = new System.Drawing.Size(124, 24);
            this.rdohdban.TabIndex = 2;
            this.rdohdban.TabStop = true;
            this.rdohdban.Text = "Hóa Đơn Bán";
            this.rdohdban.UseVisualStyleBackColor = true;
            // 
            // rdohdnhap
            // 
            this.rdohdnhap.AutoSize = true;
            this.rdohdnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdohdnhap.Location = new System.Drawing.Point(411, 48);
            this.rdohdnhap.Name = "rdohdnhap";
            this.rdohdnhap.Size = new System.Drawing.Size(133, 24);
            this.rdohdnhap.TabIndex = 2;
            this.rdohdnhap.TabStop = true;
            this.rdohdnhap.Text = "Hóa Đơn Nhập";
            this.rdohdnhap.UseVisualStyleBackColor = true;
            // 
            // mskthangnam
            // 
            this.mskthangnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskthangnam.Location = new System.Drawing.Point(182, 48);
            this.mskthangnam.Mask = "00/00/0000";
            this.mskthangnam.Name = "mskthangnam";
            this.mskthangnam.Size = new System.Drawing.Size(163, 26);
            this.mskthangnam.TabIndex = 1;
            this.mskthangnam.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng Năm";
            // 
            // dtgvThongKe
            // 
            this.dtgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongKe.Location = new System.Drawing.Point(22, 229);
            this.dtgvThongKe.Name = "dtgvThongKe";
            this.dtgvThongKe.Size = new System.Drawing.Size(766, 150);
            this.dtgvThongKe.TabIndex = 1;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvThongKe);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.RadioButton rdohdban;
        private System.Windows.Forms.RadioButton rdohdnhap;
        private System.Windows.Forms.MaskedTextBox mskthangnam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvThongKe;
    }
}