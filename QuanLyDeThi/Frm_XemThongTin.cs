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
    public partial class Frm_XemThongTin : Form
    {
        string qry;
        SqlDataAdapter da;
        DataTable table1;

        public Frm_XemThongTin()
        {
            InitializeComponent();

            BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Background.jpg");

            DeThi.conn.Open();

            qry = "SELECT * FROM View_ThongTin";
            da = new SqlDataAdapter(qry, DeThi.conn);
            table1 = new DataTable();
            da.Fill(table1);
            dataGridView.DataSource = table1;

            DeThi.conn.Close();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Tim_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Giáo Viên")
            {
                DeThi.conn.Open();
                qry = "SELECT * FROM View_ThongTin WHERE "
            //+ " dbo.View_ThongTin.[Đề Thi] like N'%" + textBox.Text + "%' "
            //+ " dbo.View_ThongTin.[Mã Khoa] like N'%" + textBox.Text + "%' "
            //+ " dbo.View_ThongTin.[Mã Lớp] like N'%" + textBox.Text + "%' "
            //+ " dbo.View_ThongTin.[Tên Môn] like N'%" + textBox.Text + "%' "
            + " dbo.View_ThongTin.[Giáo Viên Ra Đề] like N'%" + textBox.Text + "%' ";
                da = new SqlDataAdapter(qry, DeThi.conn);
                table1 = new DataTable();
                da.Fill(table1);
                dataGridView.DataSource = table1;
                DeThi.conn.Close();
            }

            if (comboBox1.Text == "Môn")
            {
                DeThi.conn.Open();
                qry = "SELECT * FROM View_ThongTin WHERE "
            //+ " dbo.View_ThongTin.[Đề Thi] like N'%" + textBox.Text + "%' "
            //+ " dbo.View_ThongTin.[Mã Khoa] like N'%" + textBox.Text + "%' "
            //+ " dbo.View_ThongTin.[Mã Lớp] like N'%" + textBox.Text + "%' "
            + " dbo.View_ThongTin.[Tên Môn] like N'%" + textBox.Text + "%' ";
                //+ " dbo.View_ThongTin.[Giáo Viên Ra Đề] like N'%" + textBox.Text + "%' ";
                da = new SqlDataAdapter(qry, DeThi.conn);
                table1 = new DataTable();
                da.Fill(table1);
                dataGridView.DataSource = table1;
                DeThi.conn.Close();
            }

            if (comboBox1.Text == "Lớp")
            {
                DeThi.conn.Open();
                qry = "SELECT * FROM View_ThongTin WHERE "
            //+ " dbo.View_ThongTin.[Đề Thi] like N'%" + textBox.Text + "%' ";
            //+ " dbo.View_ThongTin.[Mã Khoa] like N'%" + textBox.Text + "%' "
            + " dbo.View_ThongTin.[Mã Lớp] like N'%" + textBox.Text + "%' ";
                //+ " dbo.View_ThongTin.[Tên Môn] like N'%" + textBox.Text + "%' ";
                //+ " dbo.View_ThongTin.[Giáo Viên Ra Đề] like N'%" + textBox.Text + "%' ";
                da = new SqlDataAdapter(qry, DeThi.conn);
                table1 = new DataTable();
                da.Fill(table1);
                dataGridView.DataSource = table1;
                DeThi.conn.Close();
            }
            if (comboBox1.Text == "Khoá")
            {
                DeThi.conn.Open();
                qry = "SELECT * FROM View_ThongTin WHERE "
            //+ " dbo.View_ThongTin.[Đề Thi] like N'%" + textBox.Text + "%' "
            + " dbo.View_ThongTin.[Mã Khoá] like N'%" + textBox.Text + "%' ";
                //+ " dbo.View_ThongTin.[Mã Lớp] like N'%" + textBox.Text + "%' "
                //+ " dbo.View_ThongTin.[Tên Môn] like N'%" + textBox.Text + "%' ";
                //+ " dbo.View_ThongTin.[Giáo Viên Ra Đề] like N'%" + textBox.Text + "%' ";
                da = new SqlDataAdapter(qry, DeThi.conn);
                table1 = new DataTable();
                da.Fill(table1);
                dataGridView.DataSource = table1;
                DeThi.conn.Close();
            }
            if (comboBox1.Text == "Đề Thi")
            {
                DeThi.conn.Open();
                qry = "SELECT * FROM View_ThongTin WHERE "
            + " dbo.View_ThongTin.[Đề Thi] like N'%" + textBox.Text + "%' ";
                //+ " dbo.View_ThongTin.[Mã Khoa] like N'%" + textBox.Text + "%' "
                //+ " dbo.View_ThongTin.[Mã Lớp] like N'%" + textBox.Text + "%' "
                //+ " dbo.View_ThongTin.[Tên Môn] like N'%" + textBox.Text + "%' ";
                //+ " dbo.View_ThongTin.[Giáo Viên Ra Đề] like N'%" + textBox.Text + "%' ";
                da = new SqlDataAdapter(qry, DeThi.conn);
                table1 = new DataTable();
                da.Fill(table1);
                dataGridView.DataSource = table1;
                DeThi.conn.Close();
            }
        }
    }
}
