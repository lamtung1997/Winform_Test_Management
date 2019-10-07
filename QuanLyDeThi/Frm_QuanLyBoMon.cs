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
    public partial class Frm_QuanLyBoMon : Form
    {
        string qry;
        SqlDataAdapter da;
        DataTable table1;
        SqlCommand cmd;

        public Frm_QuanLyBoMon()
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

            qry = "SELECT * FROM View_BoMon";
            da = new SqlDataAdapter(qry, DeThi.conn);
            table1 = new DataTable();
            da.Fill(table1);
            dataGridView.DataSource = table1;

            DeThi.conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                DeThi.conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = DeThi.conn;

                string str_cmd = "INSERT INTO BoMon VALUES (N'" + textBox_MaBoMon.Text + "',N'" + textBox_TenBoMon.Text + "')";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();

                DeThi.conn.Close();

                MessageBox.Show("Thêm Bộ Môn Thành Công");
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

                string str_cmd = "UPDATE BoMon SET MaBoMon = N'" + textBox_MaBoMon.Text + "', TenBoMon = N'" + textBox_TenBoMon.Text + "' WHERE MaBoMon = N'" + textBox_MaBoMon.Text + "'";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();

                DeThi.conn.Close();

                MessageBox.Show("Sửa Bộ Môn Thành Công");
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

                string str_cmd = "DELETE FROM BoMon WHERE MaBoMon = N'" + textBox_MaBoMon.Text + "'";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();

                DeThi.conn.Close();

                MessageBox.Show("Xoá Bộ Môn Thành Công");
                ShowTable();
            }
            catch
            {
                MessageBox.Show("Lỗi Cú Pháp");
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView.Rows[rowIndex];

            textBox_MaBoMon.Text = row.Cells[0].Value.ToString();
            textBox_TenBoMon.Text = row.Cells[1].Value.ToString();
        }

        private void Frm_QuanLyBoMon_Load(object sender, EventArgs e)
        {

        }
    }
}
