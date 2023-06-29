namespace DoAnBanMayLanhNhomMu
{
    partial class frmTKNhaCungCap
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
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvncc = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvncc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnquaylai);
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txttenncc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Nhà Cung Cấp";
            // 
            // btnquaylai
            // 
            this.btnquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnquaylai.Location = new System.Drawing.Point(447, 73);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(109, 33);
            this.btnquaylai.TabIndex = 2;
            this.btnquaylai.Text = "Quay Lại";
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btntimkiem.Location = new System.Drawing.Point(447, 31);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(109, 33);
            this.btntimkiem.TabIndex = 2;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtdiachi.Location = new System.Drawing.Point(199, 80);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(217, 26);
            this.txtdiachi.TabIndex = 1;
            // 
            // txttenncc
            // 
            this.txttenncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txttenncc.Location = new System.Drawing.Point(199, 44);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(217, 26);
            this.txttenncc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(30, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Nhà Cung Cấp";
            // 
            // dtgvncc
            // 
            this.dtgvncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvncc.Location = new System.Drawing.Point(12, 185);
            this.dtgvncc.Name = "dtgvncc";
            this.dtgvncc.Size = new System.Drawing.Size(715, 150);
            this.dtgvncc.TabIndex = 1;
            // 
            // frmTKNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 327);
            this.Controls.Add(this.dtgvncc);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTKNhaCungCap";
            this.Text = "frmTKNhaCungCap";
            this.Load += new System.EventHandler(this.frmTKNhaCungCap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvncc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvncc;
    }
}