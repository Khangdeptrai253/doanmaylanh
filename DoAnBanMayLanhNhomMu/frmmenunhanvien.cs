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
    public partial class frmmenunhanvien : Form
    {
        public frmmenunhanvien()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLKhachHang qlkh = new frmQLKhachHang();
            this.Hide();
            qlkh.Show();
        }

        private void máyLạnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKMayLanh tkml = new frmTKMayLanh();
            this.Hide();
            tkml.Show();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTKKhachHang tklh = new frmTKKhachHang();
            this.Hide();
            tklh.Show();
        }

        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyHDB hdb = new frmQuanLyHDB();
            this.Hide();
            hdb.Show();
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
