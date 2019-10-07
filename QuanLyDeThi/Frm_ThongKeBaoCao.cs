﻿using System;
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
    public partial class Frm_ThongKeBaoCao : Form
    {
        string qry;
        SqlDataAdapter da;
        DataTable table1;

        public Frm_ThongKeBaoCao()
        {
            InitializeComponent();

            BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Pictures\\Background.jpg");

            DeThi.conn.Open();
            qry = "SELECT * FROM View_ThongKe";
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
    }
}
