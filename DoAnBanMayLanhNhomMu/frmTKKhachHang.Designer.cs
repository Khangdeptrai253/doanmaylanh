namespace DoAnBanMayLanhNhomMu
{
    partial class frmTKKhachHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvttkh = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvttkh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnquaylai);
            this.groupBox1.Controls.Add(this.btntim);
            this.groupBox1.Controls.Add(this.txttenkh);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(39, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Khách Hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnquaylai
            // 
            this.btnquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnquaylai.Location = new System.Drawing.Point(434, 106);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(112, 34);
            this.btnquaylai.TabIndex = 2;
            this.btnquaylai.Text = "Quay Lại";
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btntim.Location = new System.Drawing.Point(434, 60);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(112, 34);
            this.btntim.TabIndex = 2;
            this.btntim.Text = "Tìm Kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txttenkh
            // 
            this.txttenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txttenkh.Location = new System.Drawing.Point(192, 60);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(195, 26);
            this.txttenkh.TabIndex = 1;
            this.txttenkh.TextChanged += new System.EventHandler(this.txttenkh_TextChanged);
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtsdt.Location = new System.Drawing.Point(192, 106);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(195, 26);
            this.txtsdt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(28, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(28, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Điện Thoại";
            // 
            // dtgvttkh
            // 
            this.dtgvttkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvttkh.Location = new System.Drawing.Point(42, 211);
            this.dtgvttkh.Name = "dtgvttkh";
            this.dtgvttkh.Size = new System.Drawing.Size(691, 150);
            this.dtgvttkh.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTKKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvttkh);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTKKhachHang";
            this.Text = "frmTKKhachHang";
            this.Load += new System.EventHandler(this.frmTKKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvttkh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvttkh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}