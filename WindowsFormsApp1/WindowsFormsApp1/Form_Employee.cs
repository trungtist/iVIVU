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
    public partial class Form_Employee : Form
    {
        public Form_Employee()
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
            cm.CommandText = "select * from tb_NV order by CHUCVU ASC"; //dien cau truy van
            ad.SelectCommand = cm ; //thuc thi tuy van
            data.Clear();
            ad.Fill(data);
            dtgDulieu.DataSource = data;
            dtgDulieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Set " " cho textbox
        public void NULL()
        {
            tbMa.Text = "";
            tbTen.Text = "";
            tbChucvu.Text = "";
            tbLuong.Text = "";
            tbGioitinh.Text = "";
            tbNote.Text = "";
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            NULL();
        }

        private void Form_Employee_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(con_str);
                conn.Open();
                getData();
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void dtgDulieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1) //khi click vào 1 ô bất kì thì hiện ta trên các combox, tb tương ứng dữ liệu
            {
                //Data.Hàng.Ô thứ 0.Giá tri.Hiện thị
                tbMa.Text = dtgDulieu.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbTen.Text = dtgDulieu.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbChucvu.Text = dtgDulieu.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbLuong.Text = dtgDulieu.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtNS.Text = dtgDulieu.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbGioitinh.Text = dtgDulieu.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbNote.Text = dtgDulieu.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        //Check Trùng
        public bool Duplicate(string manv)
        {
            string sql = "select MANV FROM tb_NV WHERE MANV = '" + tbMa.Text + "'";
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

        //Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into tb_NV values('" + tbMa.Text + "','" + tbTen.Text + "','" + tbChucvu.Text + "','" + tbLuong.Text + "','" + dtNS.Text + "','" + tbGioitinh.Text + "','" + tbNote.Text + "')";
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
                                else MessageBox.Show("Mã nhân viên không tồn tại  !!!", "Thông báo");
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

        //Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Update tb_NV set TENNV = '"+tbTen.Text+ "', CHUCVU = '" + tbChucvu.Text + "', LUONG = '" + tbLuong.Text + "', NGAYSINH = '" + dtNS.Text + "', GIOITINH = '" + tbGioitinh.Text + "', CHUTHICH =  '" + tbNote.Text + "' WHERE MANV = '" + tbMa.Text + "'";
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
                        else MessageBox.Show("Mã nhân viên không tồn tại  !!!", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        //Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "DELETE tb_NV where TENNV = '"+tbTen.Text+"' or MANV = '"+tbMa.Text+"'";
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

        //Search
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM tb_NV WHERE TENNV LIKE '%"+tbTim.Text+"%' OR CHUCVU LIKE '%"+tbTim.Text+"%'";
                using (conn = new SqlConnection(con_str))
                {
                    conn.Open();
                    cm = new SqlCommand(sql, conn);
                    if (tbTim.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập nhân viên cần tìm !!!");
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
    }
}
