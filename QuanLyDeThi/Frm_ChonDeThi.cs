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
    public partial class Frm_ChonDeThi : Form
    {
        string qry;
        SqlDataAdapter da;
        SqlDataReader dr1;
        DataTable table1;
        SqlCommand cmd;

        string MaDe;
        int SoLanBoc;

        public Frm_ChonDeThi()
        {
            InitializeComponent();

            BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Background.jpg");

            DeThi.conn.Open();
            qry = @"SELECT TenMon FROM Mon";
            dr1 = new SqlCommand(qry, DeThi.conn).ExecuteReader();
            while (dr1.Read())
            {
                comboBox_Mon.Items.Add(dr1.GetValue(0).ToString());
            }
            DeThi.conn.Close();

            ShowTable();
        }

        public void ShowTable()
        {
            DeThi.conn.Open();

            qry = "SELECT * FROM View_BocDe";
            da = new SqlDataAdapter(qry, DeThi.conn);
            table1 = new DataTable();
            da.Fill(table1);
            dataGridView.DataSource = table1;

            DeThi.conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_Mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeThi.conn.Open();

            qry = "SELECT * FROM View_BocDe WHERE View_BocDe.[Tên Môn] = N'" + comboBox_Mon.Text + "' ORDER BY View_BocDe.[Số Lần Bốc]";
            da = new SqlDataAdapter(qry, DeThi.conn);
            table1 = new DataTable();
            da.Fill(table1);
            dataGridView.DataSource = table1;

            DeThi.conn.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView.Rows[rowIndex];

            MaDe = row.Cells[0].Value.ToString();
            SoLanBoc = Int32.Parse(row.Cells[3].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SoLanBoc++;
                DeThi.conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = DeThi.conn;

                string str_cmd = "UPDATE DeThi SET SoLanBoc =" + SoLanBoc.ToString() + "WHERE MaDe = N'" + MaDe + "'";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();

                DeThi.conn.Close();

                MessageBox.Show("Đã Chọn Đề " + MaDe + " Thành Công");
                ShowTable();
            }
            catch
            {
                MessageBox.Show("Chưa Chọn Đề");
            }
        }
    }
}
