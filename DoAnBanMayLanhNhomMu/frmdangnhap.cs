using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnBanMayLanhNhomMu
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if ((this.txtdangnhap.Text == "NhomMu") && (this.txtmatkhau.Text == "2532002"))
            {
                this.Hide();
                frmMeNu frm = new frmMeNu();
                frm.Show();
            }
           else if ((this.txtdangnhap.Text == "user") && (this.txtmatkhau.Text == "123"))
            { 
                this.Hide();
                frmmenunhanvien frm = new frmmenunhanvien();
                frm.Show();
            
            }
            else
            {
                MessageBox.Show("không đúng tên người dùng / mật khẩu!!!", "Thông báo");
                this.txtdangnhap.Focus();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void txtdangnhap_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

            
        }
    }
}
