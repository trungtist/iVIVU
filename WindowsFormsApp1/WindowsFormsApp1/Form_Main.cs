using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            Form_Register reg = new Form_Register();
            DialogResult rs =  reg.ShowDialog(); //hiển thị form đăng nhập ra, gán biến kết quả để xét điều kiện xuất hiện
            if(rs == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(rs != DialogResult.OK)
            {
                Application.Exit();
            } 
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            //Khi ân vào form nv thì ẩn form main, khi tắt form nv thì form main hiển lên
            Form_Employee em = new Form_Employee();
            this.Visible = false;
            em.ShowDialog();
            this.Visible = true;
        }

        private void btnBK_Click(object sender, EventArgs e)
        {
            Form_Booking bk = new Form_Booking();
            this.Visible = false;
            bk.ShowDialog();
            this.Visible = true;
        }
        
        private void btnRP_Click(object sender, EventArgs e)
        {
            Form_Report rp = new Form_Report();
            this.Visible = false;
            rp.ShowDialog();
            this.Visible = true;
        }

        private void btnIV_Click(object sender, EventArgs e)
        {
            Form_Invoice iv = new Form_Invoice();
            this.Visible = false;
            iv.ShowDialog();
            this.Visible = true;
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Form_Register re = new Form_Register();
            this.Visible = false;
            re.ShowDialog();
            this.Visible = true;

        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            Form_Customer cs = new Form_Customer();
            this.Visible = false;
            cs.ShowDialog();
            this.Visible = true;
        }
    }
}
