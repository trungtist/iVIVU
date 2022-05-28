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
    public partial class Form_Booking : Form
    {
        public Form_Booking()
        {
            InitializeComponent();
        }
        string con_str = "Data Source=.;Initial Catalog=QLTourIVIVU;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cm;
        SqlDataAdapter ad = new SqlDataAdapter();
        DataTable data = new DataTable();

        //Truy vấn dữ liệu từ db
        public void getData()
        {
            cm = conn.CreateCommand();
            cm.CommandText = "select * from tb_Tour order by MATOUR ASC"; //dien cau truy van
            ad.SelectCommand = cm; //thuc thi tuy van
            data.Clear();
            ad.Fill(data);
            dtgDulieu.DataSource = data;
        }

        public void NULL()
        {
            tbMa.Text = "";
            tbTen.Text = "";
            tbDV.Text = "";
            tbGia.Text = "";
            tbDD.Text = "";
            tbTG.Text = "";
            tbNote.Text = "";
            tbSL.Text = "";
        }

        private void Form_Booking_Load(object sender, EventArgs e)
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

        public bool Duplicate(string matour)
        {
            string sql = "select MATOUR FROM tb_TOUR WHERE MATOUR = '" + tbMa.Text + "'";
            using (conn = new SqlConnection(con_str))
            {
                conn.Open();
                cm = new SqlCommand(sql, conn);
                SqlDataReader rd = cm.ExecuteReader();
                //Nếu đọc được mã nhân viên => return true
                if (rd.Read() == true)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into tb_TOUR values(@ma, @ten, @madv, @gia, @diadiem, @time, @des, @sl)";
                if (tbMa.Text != "")
                {
                    //Nếu trùng mã nhân viên => tb : trùng
                    if (Duplicate(tbMa.Text) == true)
                    {
                        MessageBox.Show("Mã Tour đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        using (conn = new SqlConnection(con_str))
                        {
                            conn.Open();
                            cm = new SqlCommand(sql, conn);
                            cm.Parameters.AddWithValue("ma", tbMa.Text);
                            cm.Parameters.AddWithValue("ten", tbTen.Text);
                            cm.Parameters.AddWithValue("madv", tbDV.Text);
                            cm.Parameters.AddWithValue("gia", tbGia.Text);
                            cm.Parameters.AddWithValue("diadiem", tbDD.Text);
                            cm.Parameters.AddWithValue("time", tbTG.Text);
                            cm.Parameters.AddWithValue("des", tbNote.Text);
                            cm.Parameters.AddWithValue("sl", tbSL.Text);
                            if (MessageBox.Show("Bạn có chắc muốn thêm không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                int Add = cm.ExecuteNonQuery();
                                if (Add > 0)
                                {
                                    getData();
                                    NULL();
                                }
                                else MessageBox.Show("Mã Tour không tồn tại  !!!", "Thông báo");
                            }
                        }
                }
                else MessageBox.Show("Chưa nhập đủ thông tin !", "Nhắc nhở");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Update tb_TOUR set TENTOUR = @tent, MADV = @dv, DONGIA = @dg, DIADIEM = @dd, THOIGIAN = @tg, SOLUONG = @sl, DESCRIPTION = @des where MATOUR = @mat ";
                using (conn = new SqlConnection(con_str))
                {
                    conn.Open();
                    cm = new SqlCommand(sql, conn);
                    cm.Parameters.AddWithValue("tent", tbTen.Text);
                    cm.Parameters.AddWithValue("dv", tbDV.Text);
                    cm.Parameters.AddWithValue("dg", tbGia.Text);
                    cm.Parameters.AddWithValue("dd", tbDD.Text);
                    cm.Parameters.AddWithValue("tg", tbTG.Text);
                    cm.Parameters.AddWithValue("des", tbNote.Text);
                    cm.Parameters.AddWithValue("mat", tbMa.Text);
                    cm.Parameters.AddWithValue("sl", tbSL.Text);
                    if (MessageBox.Show("Bạn có chắc muốn sửa không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        int Update = cm.ExecuteNonQuery();
                        if (Update > 0)
                        {
                            getData();
                            NULL();
                        }
                        else MessageBox.Show("Mã Tour không tồn tại  !!!", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "DELETE tb_TOUR where TENTOUR = '" + tbTen.Text + "' or MATOUR = '" + tbMa.Text + "'";
                using (conn = new SqlConnection(con_str))
                {
                    conn.Open();
                    cm = new SqlCommand(sql, conn);
                    if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        int NhanVien = cm.ExecuteNonQuery();
                        if (NhanVien > 0)
                        {
                            getData();
                            NULL();
                        }
                        else MessageBox.Show("Dữ liệu không tồn tại !!!", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            NULL();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "SELECT * FROM tb_TOUR WHERE TENTOUR LIKE '%" + tbTim.Text + "%' OR DIADIEM" +
                    " LIKE '%" + tbTim.Text + "%' OR DONGIA LIKE '%"+tbTim.Text+"%'";
                using (conn = new SqlConnection(con_str))
                {
                    conn.Open();
                    cm = new SqlCommand(sql, conn);
                    if (tbTim.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập Tour cần tìm !!!");
                    }
                    else
                    {
                        cm.ExecuteNonQuery();
                        data = new DataTable();
                        ad = new SqlDataAdapter(cm);
                        ad.Fill(data);
                        dtgDulieu.DataSource = data;
                        dtgDulieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void dtgDulieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) //khi click vào 1 ô bất kì thì hiện ta trên các combox, tb tương ứng dữ liệu
            {
                //Data.Hàng.Ô thứ 0.Giá tri.Hiện thị
                tbMa.Text = dtgDulieu.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbTen.Text = dtgDulieu.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbDV.Text = dtgDulieu.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbGia.Text = dtgDulieu.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbDD.Text = dtgDulieu.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbTG.Text = dtgDulieu.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbNote.Text = dtgDulieu.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbSL.Text = dtgDulieu.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }
    }
}
