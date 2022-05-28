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
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            try
            {
                string con_string = "Data Source=.;Initial Catalog=QLTourIVIVU;Integrated Security=True";
                SqlConnection conn = new SqlConnection(con_string);

                conn.Open();
                //MessageBox.Show("Kết nối thành công");

                string user = txtUser.Text;
                string pass = txtPass.Text;
                string query = "Select count(*) from tb_User where [Tai khoan] = @user and [[Mat khau] = @pass";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@user", user));
                cmd.Parameters.Add(new SqlParameter("@pass", pass));
                int soluong = (int)cmd.ExecuteScalar();

                conn.Close();

                if (soluong == 1)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }else if (user.Equals("") && pass.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Thông báo");
                }else if (user == string.Empty)
                {
                    MessageBox.Show("Bạn vui lòng nhập tài khoản");
                }
                else if (pass == string.Empty)
                {
                    MessageBox.Show("Bạn vui lòng nhập mật khẩu");
                }
                else MessageBox.Show("Sai tài khoản hoặc mật khẩu !", "Thông báo");


            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }


            
            /*if (user.Equals("trung") && pass.Equals("12082001"))
            {
                MessageBox.Show("Đăng nhập thành công","Thông báo");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (user == string.Empty)
            {
                MessageBox.Show("Bạn vui lòng nhập tài khoản");
            }
            else if (pass == string.Empty)
            {
                MessageBox.Show("Bạn vui lòng nhập mật khẩu");
            }
            else MessageBox.Show("Sai tài khoản hoặc mật Khẩu !", "Thông báo");*/



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?","Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question)  == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form_Register_Load(object sender, EventArgs e)
        {
            txtUser.Text = "Enter UserName...";
            //txtPass.Text = "";
            txtUser.ForeColor = Color.Gray;
            txtPass.ForeColor = Color.Gray;
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
        }
    }
}
