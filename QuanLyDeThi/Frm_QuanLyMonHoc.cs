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
    public partial class Frm_QuanLyMonHoc : Form
    {
        string qry;
        SqlDataAdapter da;
        DataTable table1;
        SqlCommand cmd;

        public Frm_QuanLyMonHoc()
        {
            InitializeComponent();

            BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Background.jpg");

            button_Them.BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Add.png");
            button_Sua.BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Fix.png");
            button_Xoa.BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Delete.png");

            ShowTable();
        }

        public void ShowTable()
        {
            DeThi.conn.Open();

            qry = "SELECT * FROM View_MonHoc";
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

            textBox_MaMon.Text = row.Cells[0].Value.ToString();
            textBox_TenMon.Text = row.Cells[1].Value.ToString();
            textBox_MaBoMon.Text = row.Cells[2].Value.ToString();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                DeThi.conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = DeThi.conn;

                string str_cmd = "INSERT INTO Mon VALUES (N'" + textBox_MaMon.Text + "',N'" + textBox_TenMon.Text + "',N'" + textBox_MaBoMon.Text + "')";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();

                DeThi.conn.Close();

                MessageBox.Show("Thêm Môn Học Thành Công");
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

                string str_cmd = "UPDATE Mon SET MaMon = N'" + textBox_MaMon.Text + "', TenMon = N'" + textBox_TenMon.Text + "', MaBoMon = N'" + textBox_MaBoMon.Text + "' WHERE MaMon = N'" + textBox_MaMon.Text + "'";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();

                DeThi.conn.Close();

                MessageBox.Show("Sửa Môn Học Thành Công");
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

                string str_cmd = "DELETE FROM Mon WHERE MaMon = N'" + textBox_MaMon.Text + "'";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();

                DeThi.conn.Close();

                MessageBox.Show("Xoá Môn Học Thành Công");
                ShowTable();
            }
            catch
            {
                MessageBox.Show("Lỗi Cú Pháp");
            }
        }

        private void Frm_QuanLyMonHoc_Load(object sender, EventArgs e)
        {

        }
    }
}
