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
    public partial class Form_Customer : Form
    {
        public Form_Customer()
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
            cm.CommandText = "select * from tb_KH"; //dien cau truy van
            ad.SelectCommand = cm; //thuc thi tuy van
            data.Clear();
            ad.Fill(data);
            dtgDulieu.DataSource = data;
        }

        private void Form_Customer_Load(object sender, EventArgs e)
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

        private void NULL()
        {
            tbMa.Text = "";
            tbTen.Text = "";
            tbCmnd.Text = "";
            tbQt.Text = "";
            tbGT.Text = "";
            tbSDT.Text = "";
        }

        //Check Trùng
        public bool Duplicate(string manv)
        {
            string sql = "select MAKH FROM tb_KH WHERE MAKH = '" + tbMa.Text + "'";
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
                string sql = "insert into tb_KH values('" + tbMa.Text + "','" + tbTen.Text + "','" + tbCmnd.Text + "','" + tbQt.Text + "','" + tbGT.Text + "','" + tbSDT.Text + "')";
                if (tbMa.Text != "")
                {
                    //Nếu trùng mã nhân viên => tb : trùng
                    if (Duplicate(tbMa.Text) == true)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        using (conn = new SqlConnection(con_str))
                        {
                            conn.Open();
                            cm = new SqlCommand(sql, conn);
                            if (MessageBox.Show("Bạn có chắc muốn thêm không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                int Add = cm.ExecuteNonQuery();
                                if (Add > 0)
                                {
                                    getData();
                                    NULL();
                                }
                                else MessageBox.Show("Mã khách hàng không tồn tại  !!!", "Thông báo");
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
                string sql = "Update tb_KH " +
                    "set TENKH = '" + tbTen.Text + "', CMND = '" + tbCmnd.Text + "', QUOCTICH = '" + tbQt.Text + "', GIOITINH = '" + tbGT.Text + "', SDT = '" + tbSDT.Text + "' " +
                    "WHERE MAKH = '" + tbMa.Text + "'";
                using (conn = new SqlConnection(con_str))
                {
                    conn.Open();
                    cm = new SqlCommand(sql, conn);
                    if (MessageBox.Show("Bạn có chắc muốn sửa không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        int Update = cm.ExecuteNonQuery();
                        if (Update > 0)
                        {
                            getData();
                            NULL();
                        }
                        else MessageBox.Show("Mã khách hàng không tồn tại  !!!", "Thông báo");
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
                string sql = "DELETE tb_KH " +
                    "where TENKH = '" + tbTen.Text + "' or MAKH = '" + tbMa.Text + "'";
                using (conn = new SqlConnection(con_str))
                {
                    conn.Open();
                    cm = new SqlCommand(sql, conn);
                    if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xác nhận", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.OK)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            NULL();
        }

        private void btnRefesh_Click_1(object sender, EventArgs e)
        {
            NULL();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM tb_KH WHERE TENKH LIKE '%" + tbTim.Text + "%' OR MAKH LIKE '%" + tbTim.Text + "%'";
                using (conn = new SqlConnection(con_str))
                {
                    if (tbTim.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập khách hàng cần tìm !!!");
                    }
                    else
                    {
                        conn.Open();
                        cm = new SqlCommand(sql, conn);
                        cm.ExecuteNonQuery();
                        data = new DataTable();
                        ad = new SqlDataAdapter(cm);
                        ad.Fill(data);
                        dtgDulieu.DataSource = data;
                        dtgDulieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        NULL();
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
                tbCmnd.Text = dtgDulieu.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbQt.Text = dtgDulieu.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbGT.Text = dtgDulieu.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbSDT.Text = dtgDulieu.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
    }
}
