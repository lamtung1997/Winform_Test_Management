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
    public partial class Frm_CapNhatDeThi : Form
    {
        string qry;
        SqlDataAdapter da;
        DataTable table1;
        SqlCommand cmd;
        SqlDataReader dr1;

        public Frm_CapNhatDeThi()
        {
            InitializeComponent();

            BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Background.jpg");

            ShowTable();

            button_Them.BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Add.png");
            button_Sua.BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Fix.png");
            button_Xoa.BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Delete.png");

            DeThi.conn.Open();
            qry = @"SELECT MaLop FROM Lop";
            dr1 = new SqlCommand(qry, DeThi.conn).ExecuteReader();
            while (dr1.Read())
            {
                comboBox_MaLop.Items.Add(dr1.GetValue(0).ToString());
            }
            DeThi.conn.Close();

            DeThi.conn.Open();
            qry = @"SELECT MaKhoa FROM Khoa";
            dr1 = new SqlCommand(qry, DeThi.conn).ExecuteReader();
            while (dr1.Read())
            {
                comboBox_MaKhoa.Items.Add(dr1.GetValue(0).ToString());
            }
            DeThi.conn.Close();

            DeThi.conn.Open();
            qry = @"SELECT MaGiaoVien FROM GiaoVien";
            dr1 = new SqlCommand(qry, DeThi.conn).ExecuteReader();
            while (dr1.Read())
            {
                comboBox_MaGiaoVien.Items.Add(dr1.GetValue(0).ToString());
            }
            DeThi.conn.Close();

            DeThi.conn.Open();
            qry = @"SELECT MaMon FROM Mon";
            dr1 = new SqlCommand(qry, DeThi.conn).ExecuteReader();
            while (dr1.Read())
            {
                comboBox_MaMon.Items.Add(dr1.GetValue(0).ToString());
            }
            DeThi.conn.Close();
        }

        public void ShowTable()
        {
            DeThi.conn.Open();

            qry = "SELECT * FROM View_CapNhatDeThi";
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView.Rows[rowIndex];

            textBox_MaDe.Text = row.Cells[0].Value.ToString();
            comboBox_MaLop.Text = row.Cells[1].Value.ToString();
            comboBox_MaKhoa.Text = row.Cells[2].Value.ToString();
            comboBox_MaMon.Text = row.Cells[3].Value.ToString();
            comboBox_MaGiaoVien.Text = row.Cells[4].Value.ToString();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                DeThi.conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = DeThi.conn;

                string str_cmd = "INSERT INTO DeThi VALUES (N'" + textBox_MaDe.Text + "',N'" + comboBox_MaLop.Text + "',N'" + comboBox_MaKhoa.Text + "',N'" + comboBox_MaMon.Text + "',N'" + comboBox_MaGiaoVien.Text + "',0)";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();

                DeThi.conn.Close();

                MessageBox.Show("Thêm Đề Thi Thành Công");
                ShowTable();
            }
            catch
            {
                MessageBox.Show("Thông Tin Nhập Sai");
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                DeThi.conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = DeThi.conn;

                string str_cmd = "UPDATE DeThi SET MaDe = N'" + textBox_MaDe.Text + "', MaLop = N'" + comboBox_MaLop.Text + "', MaKhoa = N'" + comboBox_MaKhoa.Text + "', MaMon = N'" + comboBox_MaMon.Text + "', MaGiaoVien = N'" + comboBox_MaGiaoVien.Text + "' WHERE MaDe = N'" + textBox_MaDe.Text + "'";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();

                DeThi.conn.Close();

                MessageBox.Show("Sửa Đề Thi Thành Công");
                ShowTable();
            }
            catch
            {
                MessageBox.Show("Lỗi Cú Pháp");
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DeThi.conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = DeThi.conn;

                string str_cmd = "DELETE FROM DeThi WHERE MaDe = N'" + textBox_MaDe.Text + "'";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();

                DeThi.conn.Close();

                MessageBox.Show("Xoá Đề Thành Công");
                ShowTable();
            }
            catch
            {
                MessageBox.Show("Lỗi Cú Pháp");
            }
        }

        private void comboBox_MaMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeThi.conn.Open();
            qry = @"SELECT TenMon FROM Mon WHERE MaMon = N'" + comboBox_MaMon.Text + "'";
            dr1 = new SqlCommand(qry, DeThi.conn).ExecuteReader();
            while (dr1.Read())
            {
                textBox_TenMon.Text = dr1.GetValue(0).ToString();
            }
            DeThi.conn.Close();
        }

        private void comboBox_MaGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeThi.conn.Open();
            qry = @"SELECT HoTen FROM GiaoVien WHERE MaGiaoVien = N'" + comboBox_MaGiaoVien.Text + "'";
            dr1 = new SqlCommand(qry, DeThi.conn).ExecuteReader();
            while (dr1.Read())
            {
                textBox_TenGiaoVien.Text = dr1.GetValue(0).ToString();
            }
            DeThi.conn.Close();
        }

        private void Frm_CapNhatDeThi_Load(object sender, EventArgs e)
        {

        }
    }
}
