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
    public partial class frmMeNu : Form
    {
        public frmMeNu()
        {
            InitializeComponent();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe tk =    new frmThongKe();
            this.Hide();
            tk.Show();
        }

        private void frmMeNu_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýMáyLạnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLMayLanh qlml = new frmQLMayLanh();
            this.Hide();
            qlml.Show();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNCC qlncc = new frmQLNCC();
            this.Hide();
            qlncc.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNV qlnv = new frmQLNV();
            this.Hide();
            qlnv.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void quảnLýHóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyHDB qlhdb = new frmQuanLyHDB();
            this.Hide();
            qlhdb.Show();
        }

        private void quảnLýHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyHDN qlhdn = new frmQuanLyHDN();
            this.Hide();
            qlhdn.Show();   
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKKhachHang tkkh = new frmTKKhachHang();
            this.Hide();
            tkkh.Show();
        }

        private void tìmKiếmNhânViêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKNhanVien tknv = new frmTKNhanVien();
            this.Hide();
            tknv.Show();
        }

        private void tìmKiếmNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKNhaCungCap tkncc = new frmTKNhaCungCap();
            this.Hide();
            tkncc.Show();
        }

        private void tìmKiếmMáyLạnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                frmdangnhap dn = new frmdangnhap();
                this.Hide();
                dn.Show();
            }
        }
    }
}
