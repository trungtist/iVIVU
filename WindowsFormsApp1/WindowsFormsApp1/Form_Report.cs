using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Report : Form
    {
        public Form_Report()
        {
            InitializeComponent();
        }
        string con_str = "Data Source=.;Initial Catalog=QLTourIVIVU;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cm;
        SqlDataAdapter ad = new SqlDataAdapter();
        DataTable data = new DataTable();

        public void getData()
        {
            cm = conn.CreateCommand();
            cm.CommandText = "select MATOUR, SOLUONG, NGAYBAN, MAKH, MANV, DONGIA, THANHTIEN, TONGTIEN " +
                "from tb_CTHD, tb_HD " +
                "where tb_CTHD.MAHDBAN = tb_HD.MAHDBAN";//dien cau truy van
            ad.SelectCommand = cm; //thuc thi tuy van
            data.Clear();
            ad.Fill(data);
            dtgData.DataSource = data;
        }

        public void Null()
        {
            tbNgay.Text = "";
            tbNam1.Text = "";
            tbNam2.Text = "";
        }

        private void Form_Report_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(con_str);
                conn.Open();
                getData();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT COUNT(SOLUONG) AS SOTOUR, MONTH(NGAYBAN) AS THANG, SUM(TONGTIEN) AS DOANHTHU " +
                    "FROM tb_HD, tb_CTHD " +
                    "WHERE YEAR(NGAYBAN) = " + tbNam1.Text + " and tb_HD.MAHDBAN = tb_CTHD.MAHDBAN " +
                    "GROUP BY MONTH(NGAYBAN)";
                using (conn = new SqlConnection(con_str))
                {
                    conn.Open();
                    cm = new SqlCommand(sql, conn);
                    int i = cm.ExecuteNonQuery();
                    data = new DataTable();
                    ad = new SqlDataAdapter(cm);
                    ad.Fill(data);
                    dtgData.DataSource = data;
                    Null();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnNGAY_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT COUNT(SOLUONG) AS SOTOUR, NGAYBAN, SUM(TONGTIEN) AS DOANHTHU " +
                    "FROM tb_HD, tb_CTHD " +
                    "WHERE DAY(NGAYBAN) = "+tbNgay.Text+" and YEAR(NGAYBAN) = "+tbNam2.Text+ " " +
                    "and tb_HD.MAHDBAN = tb_CTHD.MAHDBAN " +
                    "GROUP BY NGAYBAN";
                using (conn = new SqlConnection(con_str))
                {
                    conn.Open();
                    cm = new SqlCommand(sql, conn);
                    int i = cm.ExecuteNonQuery();
                    data = new DataTable();
                    ad = new SqlDataAdapter(cm);
                    ad.Fill(data);
                    dtgData.DataSource = data;
                    Null();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(con_str);
                conn.Open();
                dtgData.Refresh();
                getData();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT MONTH(NGAYBAN) THANG,SUM(TONGTIEN) [DOANH THU] FROM tb_HD, tb_CTHD " +
                    "WHERE tb_HD.MAHDBAN = tb_CTHD.MAHDBAN AND YEAR(NGAYBAN)= "+tbNam1.Text+" GROUP BY MONTH(NGAYBAN)";
                using (conn = new SqlConnection(con_str))
                {
                    conn.Open();
                    cm = new SqlCommand(sql, conn);
                    int i = cm.ExecuteNonQuery();
                    data = new DataTable();
                    ad = new SqlDataAdapter(cm);
                    ad.Fill(data);
                    dtgData.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
