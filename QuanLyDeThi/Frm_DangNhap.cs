using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeThi
{
    public partial class Frm_DangNhap : Form
    {
        string qry;
        SqlDataAdapter da;
        SqlDataReader dr1;
        DataTable table1;
        SqlCommand cmd;

        string TenQuanLy = "QL";
        string TenGiaoVien = "GV";
        string MKQuanLy = "QL";
        string MKGiaoVien = "GV";
        int NhapSai = 0;
        int Second = 180;
        int Phut, Giay;

        int DangNhapDung = 0;

        public Frm_DangNhap()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\DangNhap.jpg");
            button_DangNhap.Text = "Đăng Nhập";
        }

        private void checkBox_P8_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_P8.Checked == true)
            {
                checkBox_GiaoVien.Checked = false;
            }
        }

        private void checkBox_GiaoVien_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_GiaoVien.Checked == true)
            {
                checkBox_P8.Checked = false;
            }
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            DeThi.conn.Open();
            qry = @"SELECT * FROM Users";
            dr1 = new SqlCommand(qry, DeThi.conn).ExecuteReader();
            while (dr1.Read())
            {
                if(textBox_Ten.Text == dr1.GetValue(1).ToString() && textBox_MatKhau.Text == dr1.GetValue(2).ToString() && dr1.GetValue(3).ToString() == "QL")
                {
                    DangNhapDung = 1;
                }

                if (textBox_Ten.Text == dr1.GetValue(1).ToString() && textBox_MatKhau.Text == dr1.GetValue(2).ToString() && dr1.GetValue(3).ToString() == "GV")
                {
                    DangNhapDung = 2;
                }
            }
            DeThi.conn.Close();

            if (DangNhapDung == 1 && checkBox_P8.Checked == true)
            {
                DeThi.QuanLy = true;
                DeThi.ThongKe = true;
                DeThi.ThongTin = true;
                Frm_Menu _f = new Frm_Menu();
                _f.Show();
                Visible = false;
            }
            else if (DangNhapDung == 2 && checkBox_GiaoVien.Checked == true)
            {
                DeThi.QuanLy = false;
                DeThi.ThongKe = false;
                DeThi.ThongTin = true;
                Frm_Menu _f = new Frm_Menu();
                _f.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Sai Tên Người Dùng Hoặc Mật Khẩu");
                NhapSai++;
                if (NhapSai > 3)
                {
                    MessageBox.Show("Đăng Nhập Sai Quá 3 Lần, Đợi 3 Phút Cho Lần Đăng Nhập Tiếp Theo");
                    button_DangNhap.Enabled = false;
                    ThoiGian.Start();
                }
            }
        }

        private void ThoiGian_Tick(object sender, EventArgs e)
        {
            Second--;
            if (Second == 180)
            {
                Phut = 3;
                Giay = 0;
            }
            else if (Second >= 120)
            {
                Phut = 2;
                Giay = Second - 120;
            }
            else if (Second >= 60)
            {
                Phut = 1;
                Giay = Second - 60;
            }
            else
            {
                Phut = 0;
                Giay = Second;
            }
            button_DangNhap.Text = Phut.ToString() + ":" + Giay.ToString();

            if (Second == 0)
            {
                ThoiGian.Stop();
                button_DangNhap.Enabled = true;
                button_DangNhap.Text = "Đăng Nhập";
                Second = 180;
            }
        }
    }
}
