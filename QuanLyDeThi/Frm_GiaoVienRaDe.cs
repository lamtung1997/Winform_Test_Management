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
    public partial class Frm_GiaoVienRaDe : Form
    {
        string qry;
        SqlDataAdapter da;
        DataTable table1;
        SqlCommand cmd;
        SqlDataReader dr1;

        public Frm_GiaoVienRaDe()
        {
            InitializeComponent();

            BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Background.jpg");

            button_Them.BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Add.png");
            button_Sua.BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Fix.png");
            button_Xoa.BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Delete.png");

            DeThi.conn.Open();
            qry = @"SELECT MaBoMon FROM BoMon";
            dr1 = new SqlCommand(qry, DeThi.conn).ExecuteReader();
            while (dr1.Read())
            {
                comboBox_MaBoMon.Items.Add(dr1.GetValue(0).ToString());
            }
            DeThi.conn.Close();

            ShowTable();
        }

        public void ShowTable()
        {
            DeThi.conn.Open();

            qry = "SELECT * FROM View_GiaoVien";
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

            textBox_MaGiaoVien.Text = row.Cells[0].Value.ToString();
            textBox_HoTen.Text = row.Cells[1].Value.ToString();
            comboBox_MaBoMon.Text = row.Cells[2].Value.ToString();
            textBox_TenBoMon.Text = row.Cells[3].Value.ToString();
            textBox_ChucVu.Text = row.Cells[4].Value.ToString();
            textBox_GioiTinh.Text = row.Cells[5].Value.ToString();
            textBox_SDT.Text = row.Cells[6].Value.ToString();
        }

        private void comboBox_MaBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeThi.conn.Open();
            qry = @"SELECT TenBoMon FROM BoMon WHERE MaBoMon = N'" + comboBox_MaBoMon.Text + "'";
            dr1 = new SqlCommand(qry, DeThi.conn).ExecuteReader();
            while (dr1.Read())
            {
                textBox_TenBoMon.Text = dr1.GetValue(0).ToString();
            }
            DeThi.conn.Close();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            if(comboBox_MaBoMon.Text != "")
            {
                try
                {
                    DeThi.conn.Open();

                    cmd = new SqlCommand();
                    cmd.Connection = DeThi.conn;

                    string str_cmd = "INSERT INTO GiaoVien VALUES (N'" + textBox_MaGiaoVien.Text + "', N'" + textBox_HoTen.Text + "', N'" + comboBox_MaBoMon.Text + "',N'" + textBox_ChucVu.Text + "',N'" + textBox_GioiTinh.Text + "',N'" + textBox_SDT.Text + "')";
                    cmd.CommandText = str_cmd;
                    cmd.ExecuteNonQuery();

                    DeThi.conn.Close();

                    MessageBox.Show("Thêm Giáo Viên Thành Công");
                    ShowTable();
                }
                catch
                {
                    MessageBox.Show("Thông Tin Nhập Sai");
                }
            }
            else
            {
                MessageBox.Show("Chưa Điền Mã Bộ Môn");
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                DeThi.conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = DeThi.conn;

                string str_cmd = "UPDATE GiaoVien SET HoTen = N'" + textBox_HoTen.Text + "',MaBoMon = N'" + comboBox_MaBoMon.Text + "',ChucVu = N'" + textBox_ChucVu.Text + "', GioiTinh = N'" + textBox_GioiTinh.Text + "', SDT = '" + textBox_SDT.Text + "' WHERE MaGiaoVien = N'" + textBox_MaGiaoVien.Text + "'";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();

                DeThi.conn.Close();

                MessageBox.Show("Sửa Giáo Viên Thành Công");
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

                    string str_cmd = "DELETE FROM GiaoVien WHERE MaGiaoVien = N'" + textBox_MaGiaoVien.Text + "'";
                    cmd.CommandText = str_cmd;
                    cmd.ExecuteNonQuery();

                    DeThi.conn.Close();

                    MessageBox.Show("Xoá Giáo Viên Thành Công");
                    ShowTable();
                }
                catch
                {
                    MessageBox.Show("Lỗi Cú Pháp");
                }
        }
    }
}
