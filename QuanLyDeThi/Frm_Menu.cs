using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeThi
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Menu.jpg");
            Icon = new Icon(Directory.GetCurrentDirectory() + "\\Pictures\\Icon.ico");

            Menu_QuanLy.Enabled = DeThi.QuanLy;
            Menu_ThongKe.Enabled = DeThi.ThongKe;
            Menu_ThongTin.Enabled = DeThi.ThongTin;

            Menu_QuanLy.Image = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\QuanLy.png");
            Menu_ThongKe.Image = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\ThongKe.png");
            Menu_ThongTin.Image = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\ThongTin.png");
            
            mônHọcToolStripMenuItem.Image = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\MonHoc.png");
            khoaBộMônToolStripMenuItem.Image = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\BoMon.png");
            giáoViênRaĐềToolStripMenuItem.Image = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\GiaoVien.png");
            đềThiToolStripMenuItem.Image = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\ChonDe.png");
            cậpNhậtToolStripMenuItem.Image = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\CapNhat.png");
            chọnĐềThiToolStripMenuItem.Image = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\ChonDe.png");
            lớpHọcToolStripMenuItem.Image = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\LopHoc.png");
            thoátToolStripMenuItem.Image = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Thoat.png");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_QuanLyMonHoc _f = new Frm_QuanLyMonHoc();
            _f.ShowDialog();
        }

        private void khoaBộMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_QuanLyBoMon _f = new Frm_QuanLyBoMon();
            _f.ShowDialog();
        }

        private void giáoViênRaĐềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GiaoVienRaDe _f = new Frm_GiaoVienRaDe();
            _f.ShowDialog();
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CapNhatDeThi _f = new Frm_CapNhatDeThi();
            _f.ShowDialog();
        }

        private void chọnĐềThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ChonDeThi _f = new Frm_ChonDeThi();
            _f.ShowDialog();
        }

        private void ThongKe_Click(object sender, EventArgs e)
        {
            Frm_ThongKeBaoCao _f = new Frm_ThongKeBaoCao();
            _f.ShowDialog();
        }

        private void ThongTin_Click(object sender, EventArgs e)
        {
            Frm_XemThongTin _f = new Frm_XemThongTin();
            _f.ShowDialog();
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_LopHoc _f = new Frm_LopHoc();
            _f.ShowDialog();
        }
    }
}
