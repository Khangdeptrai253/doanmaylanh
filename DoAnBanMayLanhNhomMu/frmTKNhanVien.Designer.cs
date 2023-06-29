namespace DoAnBanMayLanhNhomMu
{
    partial class frmTKNhanVien
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
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtnhapten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datgvtknv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgvtknv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnquaylai);
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtnhapten);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(62, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Nhân Viên";
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.Color.LightSalmon;
            this.btnquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnquaylai.Location = new System.Drawing.Point(263, 65);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(113, 30);
            this.btnquaylai.TabIndex = 2;
            this.btnquaylai.Text = "Quay Lại";
            this.btnquaylai.UseVisualStyleBackColor = false;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.LightSalmon;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btntimkiem.Location = new System.Drawing.Point(263, 29);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(113, 30);
            this.btntimkiem.TabIndex = 2;
            this.btntimkiem.Text = "tìm kiếm ";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtsdt.Location = new System.Drawing.Point(35, 63);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(222, 26);
            this.txtsdt.TabIndex = 1;
            this.txtsdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnhapten
            // 
            this.txtnhapten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnhapten.Location = new System.Drawing.Point(35, 31);
            this.txtnhapten.Name = "txtnhapten";
            this.txtnhapten.Size = new System.Drawing.Size(222, 26);
            this.txtnhapten.TabIndex = 1;
            this.txtnhapten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // datgvtknv
            // 
            this.datgvtknv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgvtknv.Location = new System.Drawing.Point(62, 146);
            this.datgvtknv.Name = "datgvtknv";
            this.datgvtknv.Size = new System.Drawing.Size(604, 150);
            this.datgvtknv.TabIndex = 1;
            // 
            // frmTKNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 261);
            this.Controls.Add(this.datgvtknv);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTKNhanVien";
            this.Text = "frmTKNhanVien";
            this.Load += new System.EventHandler(this.frmTKNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgvtknv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnhapten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.DataGridView datgvtknv;
        private System.Windows.Forms.Button btnquaylai;
    }
}