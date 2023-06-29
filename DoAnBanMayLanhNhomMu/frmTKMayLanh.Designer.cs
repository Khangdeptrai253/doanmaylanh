namespace DoAnBanMayLanhNhomMu
{
    partial class frmTKMayLanh
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
            this.btntk = new System.Windows.Forms.Button();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.txttktheoten = new System.Windows.Forms.TextBox();
            this.dtgvtkml = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtkml)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btntk);
            this.groupBox1.Controls.Add(this.btnquaylai);
            this.groupBox1.Controls.Add(this.txttktheoten);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(32, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Máy Lạnh";
            // 
            // btntk
            // 
            this.btntk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btntk.Location = new System.Drawing.Point(94, 75);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(117, 31);
            this.btntk.TabIndex = 3;
            this.btntk.Text = "Tìm Kiếm ";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // btnquaylai
            // 
            this.btnquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnquaylai.Location = new System.Drawing.Point(238, 75);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(117, 31);
            this.btnquaylai.TabIndex = 3;
            this.btnquaylai.Text = "Quay Lại";
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // txttktheoten
            // 
            this.txttktheoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txttktheoten.Location = new System.Drawing.Point(26, 36);
            this.txttktheoten.Name = "txttktheoten";
            this.txttktheoten.Size = new System.Drawing.Size(405, 26);
            this.txttktheoten.TabIndex = 2;
            this.txttktheoten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgvtkml
            // 
            this.dtgvtkml.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvtkml.Location = new System.Drawing.Point(32, 143);
            this.dtgvtkml.Name = "dtgvtkml";
            this.dtgvtkml.Size = new System.Drawing.Size(470, 150);
            this.dtgvtkml.TabIndex = 1;
            // 
            // frmTKMayLanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 261);
            this.Controls.Add(this.dtgvtkml);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTKMayLanh";
            this.Text = "frmTKMayLanh";
            this.Load += new System.EventHandler(this.frmTKMayLanh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtkml)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.TextBox txttktheoten;
        private System.Windows.Forms.DataGridView dtgvtkml;
        private System.Windows.Forms.Button btnquaylai;
    }
}