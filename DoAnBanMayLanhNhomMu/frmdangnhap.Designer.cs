namespace DoAnBanMayLanhNhomMu
{
    partial class frmdangnhap
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
            this.txtdangnhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdangnhap
            // 
            this.txtdangnhap.Location = new System.Drawing.Point(210, 79);
            this.txtdangnhap.Name = "txtdangnhap";
            this.txtdangnhap.Size = new System.Drawing.Size(128, 20);
            this.txtdangnhap.TabIndex = 0;
            this.txtdangnhap.TextChanged += new System.EventHandler(this.txtdangnhap_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(72, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Đăng Nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Plum;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đăng Nhập";
            // 
            // btndangnhap
            // 
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btndangnhap.Location = new System.Drawing.Point(85, 171);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(117, 32);
            this.btndangnhap.TabIndex = 3;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(72, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(210, 112);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(128, 20);
            this.txtmatkhau.TabIndex = 0;
            this.txtmatkhau.TextChanged += new System.EventHandler(this.txtmatkhau_TextChanged);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnthoat.Location = new System.Drawing.Point(248, 171);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(117, 32);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txtdangnhap);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmdangnhap";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

