using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDeThi
{
    public static class DeThi
    {
        public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CV8KF9D;Initial Catalog=QuanLyDeThi;Integrated Security=True");
        public static bool QuanLy = true, ThongKe = true, ThongTin = true;
    }
}
