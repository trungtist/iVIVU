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
using WindowsFormsApp1.Class;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form_Invoice : Form
    {
        public Form_Invoice()
        {
            InitializeComponent();
        }
        DataTable tblCTHDB = new DataTable();
        DataTable tblHDB = new DataTable();

        private void Form_Invoice_Load(object sender, EventArgs e)
        {

            Functions.FillCombo("SELECT MAKH, TENKH FROM tb_KH", cbMakh, "MAKH", "MAKH");
            cbMakh.SelectedIndex = -1;
            Functions.FillCombo("SELECT MANV, TENNV FROM tb_NV", cbManv, "MANV", "MANV");
            cbManv.SelectedIndex = -1;
            Functions.FillCombo("SELECT MATOUR, TENTOUR FROM tb_TOUR", cbMaT, "MATOUR", "MATOUR");
            cbHD.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (tbMahd.Text != "")
            {
                LoadInfoHoaDon();
            }
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MATOUR, b.TENTOUR, a.SOLUONG, b.DONGIA, a.DISCOUNT ,a.THANHTIEN " +
                "FROM tb_CTHD AS a, tb_TOUR AS b " +
                "WHERE a.MAHDBAN = N'" + tbMahd.Text + "' AND a.MATOUR=b.MATOUR";
            Functions.Connect();
            tblCTHDB = Functions.GetDataToDataTable(sql);
            dtgHD.DataSource = tblCTHDB;
            dtgHD.Columns[0].HeaderText = "Mã Tour";
            dtgHD.Columns[1].HeaderText = "Tên Tour";
            dtgHD.Columns[2].HeaderText = "Số lượng";
            dtgHD.Columns[3].HeaderText = "Đơn giá";
            dtgHD.Columns[4].HeaderText = "Giảm giá %";
            dtgHD.Columns[5].HeaderText = "Thành tiền";
            dtgHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgHD.AllowUserToAddRows = false;
            dtgHD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NGAYBAN FROM tb_HD WHERE MAHDBAN = N'" + tbMahd.Text + "'";
            tbNB.Value = DateTime.Parse(Functions.GetFieldValues(str));
            str = "SELECT MANV FROM tb_HD WHERE MAHDBAN = N'" + tbMahd.Text + "'";
            cbManv.Text = Functions.GetFieldValues(str);
            str = "SELECT MAKH FROM tb_HD WHERE MAHDBAN = N'" + tbMahd.Text + "'";
            cbMakh.Text = Functions.GetFieldValues(str);
            str = "SELECT TONGTIEN FROM tb_HD WHERE MAHDBAN = N'" + tbMahd.Text + "'";
            tbTong.Text = Functions.GetFieldValues(str);
            lbCHU.Text = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(tbTong.Text));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            tbMahd.Text = Functions.CreateKey("HD");
            LoadDataGridView();
        }

        private void ResetValues()
        {
            tbMahd.Text = "";
            tbNB.Text = DateTime.Now.ToShortDateString();
            cbManv.Text = "";
            cbMakh.Text = "";
            tbTong.Text = "0";
            lbCHU.Text = "Bằng chữ: ";
            cbMaT.Text = "";
            tbSl.Text = "";
            tbTT.Text = "0";
            tbGG.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                double sl, SLcon, tong, Tongmoi;
                sql = "SELECT MAHDBAN FROM tb_HD WHERE MAHDBAN =N'" + tbMahd.Text + "'";
                if (!Functions.CheckKey(sql))
                {
                    // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                    // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                    if (tbNB.Text.Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbNB.Focus();
                        return;
                    }
                    if (cbManv.Text.Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbManv.Focus();
                        return;
                    }
                    if (cbMakh.Text.Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbMakh.Focus();
                        return;
                    }
                    sql = "INSERT INTO tb_HD(MAHDBAN, NGAYBAN, MANV, MAKH, TONGTIEN) " +
                        "VALUES (N'" + tbMahd.Text.Trim() + "','" +
                            Functions.ConvertDateTime(tbNB.Text.Trim()) + "',N'" + cbManv.SelectedValue + "',N'" +
                            cbMakh.SelectedValue + "'," + tbTong.Text + ")";
                    Functions.RunSQL(sql);
                }
                // Lưu thông tin của các mặt hàng
                if (cbMaT.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbMaT.Focus();
                    return;
                }
                if ((tbSl.Text.Trim().Length == 0) || (tbSl.Text == "0"))
                {
                    MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbSl.Text = "";
                    tbSl.Focus();
                    return;
                }
                if (tbGG.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbGG.Focus();
                    return;
                }
                sql = "SELECT MATOUR FROM tb_CTHD WHERE MATOUR =N'" + cbMaT.SelectedValue + "' " +
                    "AND MAHDBAN = N'" + tbMahd.Text.Trim() + "'";
                if (Functions.CheckKey(sql))
                {
                    MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValuesHang();
                    cbMaT.Focus();
                    return;
                }
                // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
                sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SOLUONG FROM tb_TOUR WHERE MATOUR = N'" + cbMaT.SelectedValue + "'"));
                if (Convert.ToDouble(tbSl.Text) > sl)
                {
                    MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbSl.Text = "";
                    tbSl.Focus();
                    return;
                }
                sql = "INSERT INTO tb_CTHD(MAHDBAN,MATOUR,SOLUONG,DONGIA,DISCOUNT,THANHTIEN) " +
                    "VALUES(N'" + tbMahd.Text.Trim() + "',N'" + cbMaT.SelectedValue + "'," +
                    "" + tbSl.Text + "," + tbDG.Text + ","+tbGG.Text+", "+ tbTT.Text + ")";
                Functions.RunSQL(sql);
                LoadDataGridView();
                // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
                SLcon = sl - Convert.ToDouble(tbSl.Text);
                sql = "UPDATE tb_TOUR SET SOLUONG =" + SLcon + " WHERE MATOUR = N'" + cbMaT.SelectedValue + "'";
                Functions.RunSQL(sql);

                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TONGTIEN FROM tb_HD " +
                    "WHERE MAHDBAN = N'" + tbMahd.Text + "'"));
                Tongmoi = tong + Convert.ToDouble(tbTT.Text);
                sql = "UPDATE tb_HD SET TongTien =" + Tongmoi + " " +
                    "WHERE MAHDBAN = N'" + tbMahd.Text + "'";
                Functions.RunSQL(sql);

                tbTong.Text = Tongmoi.ToString();
                lbCHU.Text = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(Tongmoi.ToString()));
                ResetValuesHang();
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void ResetValuesHang()
        {
            cbMaT.Text = "";
            tbSl.Text = "";
            tbTT.Text = "0";
        }

        private void dtgHD_DoubleClick(object sender, EventArgs e)
        {
            string MaTourxoa,sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaTourxoa = dtgHD.CurrentRow.Cells["MATOUR"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dtgHD.CurrentRow.Cells["SOLUONG"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dtgHD.CurrentRow.Cells["THANHTIEN"].Value.ToString());
                sql = "DELETE tb_CTHD WHERE MAHDBAN = N'" + tbMahd.Text + "' AND MATOUR = N'" + MaTourxoa + "'";
                Functions.RunSQL(sql);

                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SOLUONG FROM tb_TOUR WHERE MATOUR = N'" + MaTourxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE tb_TOUR SET SOLUONG =" + slcon + " WHERE MATOUR = N'" +  MaTourxoa + "'";
                Functions.RunSQL(sql);

                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TONGTIEN FROM tb_HD WHERE MAHDBAN = N'" + tbMahd.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE tb_HD SET TONGTIEN =" + tongmoi + " WHERE MAHDBAN = N'" + tbMahd.Text + "'";
                Functions.RunSQL(sql);
                tbTong.Text = tongmoi.ToString();
                lbCHU.Text = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(tongmoi);
                LoadDataGridView();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tbMahd.Text == "")
                {
                   MessageBox.Show("Không có Tour nào tồn tài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    string sql = "SELECT MATOUR,SOLUONG FROM tb_CTHD WHERE MAHDBAN = N'" + tbMahd.Text + "'";
                    DataTable tblHang = Functions.GetDataToDataTable(sql);
                    for (int hang = 0; hang <= tblHang.Rows.Count - 1; hang++)
                    {
                        // Cập nhật lại số lượng cho các mặt hàng
                        sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SOLUONG FROM tb_TOUR WHERE MATOUR = N'" + tblHang.Rows[hang][0].ToString() + "'"));
                        slxoa = Convert.ToDouble(tblHang.Rows[hang][1].ToString());
                        slcon = sl + slxoa;
                        sql = "UPDATE tb_TOUR SET SOLUONG =" + slcon + " WHERE MATOUR = N'" + tblHang.Rows[hang][0].ToString() + "'";
                        Functions.RunSQL(sql);
                    }

                    //Xóa chi tiết hóa đơn
                    sql = "DELETE tb_CTHD WHERE MAHDBAN =N'" + tbMahd.Text + "'";
                    Functions.RunSqlDel(sql);

                    //Xóa hóa đơn
                    sql = "DELETE tb_HD WHERE MAHDBan=N'" + tbMahd.Text + "'";
                    Functions.RunSqlDel(sql);
                    ResetValues();
                    LoadDataGridView();
                }
            }
        }

        private void cbManv_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbManv.Text == "")
                tbTenNV.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select TENNV from tb_NV where MANV =N'" + cbManv.SelectedValue + "'";
            tbTenNV.Text = Functions.GetFieldValues(str);
        }

        private void cbMakh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbMakh.Text == "")
            {
                tbTenKH.Text = "";
                tbCMND.Text = "";
                tbSdt.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select TENKH from tb_KH where MAKH = N'" + cbMakh.SelectedValue + "'";
            tbTenKH.Text = Functions.GetFieldValues(str);
            str = "Select CMND from tb_KH where MAKH = N'" + cbMakh.SelectedValue + "'";
            tbCMND.Text = Functions.GetFieldValues(str);
            str = "Select SDT from tb_KH where MAKH = N'" + cbMakh.SelectedValue + "'";
            tbSdt.Text = Functions.GetFieldValues(str);
        }

        private void cbMaT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbMaT.Text == "")
            {
                tbTour.Text = "";
                tbDG.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT TENTOUR FROM tb_TOUR WHERE MATOUR =N'" + cbMaT.SelectedValue + "'";
            tbTour.Text = Functions.GetFieldValues(str);
            str = "SELECT DONGIA FROM tb_TOUR WHERE MATOUR =N'" + cbMaT.SelectedValue + "'";
            tbDG.Text = Functions.GetFieldValues(str);
        }

        private void tbSl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void tbGG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi động chương trình Excel
                COMExcel.Application exApp = new COMExcel.Application();
                COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
                COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
                COMExcel.Range exRange;
                string sql;
                int hang = 0, cot = 0;
                DataTable tblThongtinHD, tblThongtinHang;
                exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
                exSheet = exBook.Worksheets[1];
                // Định dạng chung
                exRange = exSheet.Cells[1, 1];
                exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
                exRange.Range["A1:B3"].Font.Size = 14;
                exRange.Range["A1:B3"].Font.Bold = true;
                exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
                exRange.Range["A1:A1"].ColumnWidth = 11;
                exRange.Range["B1:B1"].ColumnWidth = 20;
                exRange.Range["A1:B1"].MergeCells = true;
                exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A1:B1"].Value = "Tour Du Lịch IVIVU";
                exRange.Range["A2:B2"].MergeCells = true;
                exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:B2"].Value = "Tân Triều - Hà Nội";
                exRange.Range["A3:B3"].MergeCells = true;
                exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A3:B3"].Value = "Điện thoại: 0977620025";
                exRange.Range["C2:E2"].Font.Size = 16;
                exRange.Range["C2:E2"].Font.Bold = true;
                exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
                exRange.Range["C2:E2"].MergeCells = true;
                exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C2:E2"].Value = "HÓA ĐƠN TOUR DU LỊCH";

                // Biểu diễn thông tin chung của hóa đơn bán
                sql = "SELECT A.MAHDBAN, A.NGAYBAN, A.TONGTIEN, B.TENKH, B.CMND, B.SDT, C.TENNV " +
                    "FROM tb_HD AS A , tb_KH AS B , tb_NV AS C  " +
                    "WHERE A.MAHDBAN = N'" + tbMahd.Text + "' AND A.MAKH = B.MAKH AND A.MANV = C.MANV";
                tblThongtinHD = Functions.GetDataToDataTable(sql);
                exRange.Range["B6:C9"].Font.Size = 13;
                exRange.Range["B6:B6"].Value = "Mã hóa đơn :";
                exRange.Range["C6:E6"].MergeCells = true;
                exRange.Range["C6:E6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
                exRange.Range["B7:B7"].Value = "Khách hàng :";
                exRange.Range["C7:E7"].MergeCells = true;
                exRange.Range["C7:E7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
                exRange.Range["B8:B8"].Value = "CMND :";
                exRange.Range["C8:C8"].MergeCells = true;
                exRange.Range["C8:C8"].Value = tblThongtinHD.Rows[0][4].ToString();
                exRange.Range["B9:B9"].Value = "Điện thoại :";
                exRange.Range["C9:C9"].MergeCells = true;
                exRange.Range["C9:C9"].Value = tblThongtinHD.Rows[0][5].ToString();

                //Lấy thông tin các mặt hàng
                sql = "SELECT tb_TOUR.TENTOUR, tb_CTHD.SOLUONG, tb_TOUR.DONGIA, tb_CTHD.DISCOUNT,tb_CTHD.THANHTIEN " +
                        "FROM tb_CTHD, tb_TOUR WHERE tb_CTHD.MAHDBAN = N'" +
                        tbMahd.Text + "' AND tb_CTHD.MATOUR = tb_TOUR.MATOUR";
                tblThongtinHang = Functions.GetDataToDataTable(sql);

                //Tạo dòng tiêu đề bảng
                exRange.Range["A11:F11"].Font.Bold = true;
                exRange.Range["A11:F11"].Font.Size = 12;
                exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C11:F11"].ColumnWidth = 14;
                exRange.Range["A11:A11"].Value = "STT";
                exRange.Range["B11:B11"].Value = "Tên Tour";
                exRange.Range["C11:C11"].Value = "Số lượng";
                exRange.Range["D11:D11"].Value = "Đơn giá";
                exRange.Range["E11:E11"].Value = "Giảm giá";
                exRange.Range["F11:F11"].Value = "Thành tiền";
                for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
                {
                    //Điền số thứ tự vào cột 1 từ dòng 12
                    exSheet.Cells[1][hang + 12] = hang + 1;
                    for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    {
                        exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                        if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                    }
                }
                exRange = exSheet.Cells[cot][hang + 14];
                exRange.Font.Bold = true;
                exRange.Value2 = "Tổng tiền:";
                exRange = exSheet.Cells[cot + 1][hang + 14];
                exRange.Font.Bold = true;
                exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
                exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
                exRange.Range["A1:F1"].MergeCells = true;
                exRange.Range["A1:F1"].Font.Bold = true;
                exRange.Range["A1:F1"].Font.Italic = true;
                exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
                exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(tblThongtinHD.Rows[0][2].ToString()));
                exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
                exRange.Range["A1:C1"].MergeCells = true;
                exRange.Range["A1:C1"].Font.Italic = true;
                exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
                exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
                exRange.Range["A2:C2"].MergeCells = true;
                exRange.Range["A2:C2"].Font.Italic = true;
                exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
                exRange.Range["A6:C6"].MergeCells = true;
                exRange.Range["A6:C6"].Font.Italic = true;
                exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
                exSheet.Name = "Hóa đơn bán";
                exApp.Visible = true;
                
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbHD.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbHD.Focus();
                return;
            }
            tbMahd.Text = cbHD.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            cbHD.SelectedIndex = -1;
        }

        private void cbHD_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT MAHDBAN FROM tb_HD", cbHD, "MaHDBan", "MaHDBan");
            cbHD.SelectedIndex = -1;
        }

        private void tbSl_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (tbSl.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(tbSl.Text);

            if (tbGG.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(tbGG.Text);

            if (tbDG.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(tbDG.Text);
            tt = sl * dg - sl * dg * gg / 100;
            tbTT.Text = tt.ToString();
        }

        private void tbGG_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (tbSl.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(tbSl.Text);
            if (tbGG.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(tbGG.Text);
            if (tbDG.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(tbDG.Text);
            tt = sl * dg - sl * dg * gg / 100;
            tbTT.Text = tt.ToString();
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

        private void btnTimT_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM tb_TOUR WHERE TENTOUR LIKE '%" + tbTim.Text + "%' OR DIADIEM" +
                    " LIKE '%" + tbTim.Text + "%' OR DONGIA LIKE '%" + tbTim.Text + "%'";
                using (conn = new SqlConnection(con_str))
                {
                    conn.Open();
                    cm = new SqlCommand(sql, conn);
                    if (tbTim.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập Tour cần tìm !!!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlDataReader rd = cm.ExecuteReader();
                        data = new DataTable();
                        if (rd.HasRows)
                        {
                            data.Load(rd);
                            dtgDulieu.DataSource = data;
                        }
                        else MessageBox.Show("Thông tin Tour không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         tbTim.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM tb_TOUR ORDER BY ASC";
                using (conn = new SqlConnection(con_str))
                {
                    conn.Open();
                    getData();
                    dtgDulieu.Columns[0].HeaderText = "Mã Tour";
                    dtgDulieu.Columns[1].HeaderText = "Tên hàng";
                    dtgDulieu.Columns[2].HeaderText = "Mã dịch vụ";
                    dtgDulieu.Columns[3].HeaderText = "Đơn giá";
                    dtgDulieu.Columns[4].HeaderText = "Địa điểm";
                    dtgDulieu.Columns[5].HeaderText = "Thời gian";
                    dtgDulieu.Columns[6].HeaderText = "Description";
                    dtgDulieu.Columns[7].HeaderText = "Số lượng";
                    dtgDulieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgDulieu.AllowUserToAddRows = false;
                    dtgDulieu.EditMode = DataGridViewEditMode.EditProgrammatically;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        
    }
}
