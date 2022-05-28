
namespace WindowsFormsApp1
{
    partial class Form_Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Invoice));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbGG = new System.Windows.Forms.TextBox();
            this.cbMaT = new System.Windows.Forms.ComboBox();
            this.tbTT = new System.Windows.Forms.TextBox();
            this.tbDG = new System.Windows.Forms.TextBox();
            this.tbTour = new System.Windows.Forms.TextBox();
            this.tbSl = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtgHD = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMahd = new System.Windows.Forms.TextBox();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.tbNB = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.cbMakh = new System.Windows.Forms.ComboBox();
            this.cbHD = new System.Windows.Forms.ComboBox();
            this.lbCHU = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbTim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.dtgDulieu = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHD)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDulieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(832, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý hóa đơn Booking";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.tbGG);
            this.groupBox2.Controls.Add(this.cbMaT);
            this.groupBox2.Controls.Add(this.tbTT);
            this.groupBox2.Controls.Add(this.tbDG);
            this.groupBox2.Controls.Add(this.tbTour);
            this.groupBox2.Controls.Add(this.tbSl);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1041, 121);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các Tour";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(695, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 24);
            this.label19.TabIndex = 31;
            this.label19.Text = "Giảm giá";
            // 
            // tbGG
            // 
            this.tbGG.Location = new System.Drawing.Point(822, 77);
            this.tbGG.Name = "tbGG";
            this.tbGG.Size = new System.Drawing.Size(122, 28);
            this.tbGG.TabIndex = 30;
            this.tbGG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGG.TextChanged += new System.EventHandler(this.tbGG_TextChanged);
            this.tbGG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGG_KeyPress);
            // 
            // cbMaT
            // 
            this.cbMaT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMaT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMaT.FormattingEnabled = true;
            this.cbMaT.Location = new System.Drawing.Point(104, 39);
            this.cbMaT.Name = "cbMaT";
            this.cbMaT.Size = new System.Drawing.Size(158, 30);
            this.cbMaT.TabIndex = 29;
            this.cbMaT.SelectedIndexChanged += new System.EventHandler(this.cbMaT_SelectedIndexChanged);
            // 
            // tbTT
            // 
            this.tbTT.ForeColor = System.Drawing.Color.Crimson;
            this.tbTT.Location = new System.Drawing.Point(822, 39);
            this.tbTT.Name = "tbTT";
            this.tbTT.ReadOnly = true;
            this.tbTT.Size = new System.Drawing.Size(172, 28);
            this.tbTT.TabIndex = 22;
            this.tbTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbDG
            // 
            this.tbDG.Location = new System.Drawing.Point(423, 77);
            this.tbDG.Name = "tbDG";
            this.tbDG.ReadOnly = true;
            this.tbDG.Size = new System.Drawing.Size(122, 28);
            this.tbDG.TabIndex = 21;
            this.tbDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTour
            // 
            this.tbTour.Location = new System.Drawing.Point(423, 39);
            this.tbTour.Name = "tbTour";
            this.tbTour.ReadOnly = true;
            this.tbTour.Size = new System.Drawing.Size(218, 28);
            this.tbTour.TabIndex = 20;
            // 
            // tbSl
            // 
            this.tbSl.Location = new System.Drawing.Point(104, 76);
            this.tbSl.Name = "tbSl";
            this.tbSl.Size = new System.Drawing.Size(158, 28);
            this.tbSl.TabIndex = 19;
            this.tbSl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSl.TextChanged += new System.EventHandler(this.tbSl_TextChanged);
            this.tbSl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSl_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.SkyBlue;
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(695, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 24);
            this.label14.TabIndex = 10;
            this.label14.Text = "Thành tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Mã Tour";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "Số lượng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(317, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 24);
            this.label12.TabIndex = 7;
            this.label12.Text = "Tên Tour";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(317, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 24);
            this.label13.TabIndex = 6;
            this.label13.Text = "Đơn giá";
            // 
            // dtgHD
            // 
            this.dtgHD.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dtgHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHD.Location = new System.Drawing.Point(12, 394);
            this.dtgHD.Name = "dtgHD";
            this.dtgHD.RowHeadersWidth = 51;
            this.dtgHD.RowTemplate.Height = 24;
            this.dtgHD.Size = new System.Drawing.Size(1041, 221);
            this.dtgHD.TabIndex = 11;
            this.dtgHD.DoubleClick += new System.EventHandler(this.dtgHD_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox3.Controls.Add(this.btnIn);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(834, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 172);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác";
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(125, 110);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(88, 35);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(125, 39);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 39);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(6, 110);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 35);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Azure;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(6, 39);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(431, 628);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 24);
            this.label15.TabIndex = 23;
            this.label15.Text = "Mã hóa đơn";
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTim.BackColor = System.Drawing.Color.Salmon;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(701, 625);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(106, 31);
            this.btnTim.TabIndex = 24;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Indigo;
            this.label16.Location = new System.Drawing.Point(774, 356);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 24);
            this.label16.TabIndex = 25;
            this.label16.Text = "Tổng tiền";
            // 
            // tbTong
            // 
            this.tbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTong.Location = new System.Drawing.Point(881, 356);
            this.tbTong.Name = "tbTong";
            this.tbTong.Size = new System.Drawing.Size(172, 28);
            this.tbTong.TabIndex = 23;
            this.tbTong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tên khách hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "CMND";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Số điện thoại";
            // 
            // tbMahd
            // 
            this.tbMahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMahd.Location = new System.Drawing.Point(136, 26);
            this.tbMahd.Name = "tbMahd";
            this.tbMahd.ReadOnly = true;
            this.tbMahd.Size = new System.Drawing.Size(241, 28);
            this.tbMahd.TabIndex = 10;
            // 
            // tbTenKH
            // 
            this.tbTenKH.Location = new System.Drawing.Point(568, 62);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.ReadOnly = true;
            this.tbTenKH.Size = new System.Drawing.Size(241, 28);
            this.tbTenKH.TabIndex = 13;
            // 
            // tbTenNV
            // 
            this.tbTenNV.Location = new System.Drawing.Point(136, 138);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.ReadOnly = true;
            this.tbTenNV.Size = new System.Drawing.Size(241, 28);
            this.tbTenNV.TabIndex = 15;
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(568, 97);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.ReadOnly = true;
            this.tbCMND.Size = new System.Drawing.Size(192, 28);
            this.tbCMND.TabIndex = 16;
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(568, 134);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.ReadOnly = true;
            this.tbSdt.Size = new System.Drawing.Size(192, 28);
            this.tbSdt.TabIndex = 17;
            // 
            // tbNB
            // 
            this.tbNB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbNB.Location = new System.Drawing.Point(136, 65);
            this.tbNB.Name = "tbNB";
            this.tbNB.Size = new System.Drawing.Size(158, 28);
            this.tbNB.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.cbManv);
            this.groupBox1.Controls.Add(this.cbMakh);
            this.groupBox1.Controls.Add(this.tbNB);
            this.groupBox1.Controls.Add(this.tbSdt);
            this.groupBox1.Controls.Add(this.tbCMND);
            this.groupBox1.Controls.Add(this.tbTenNV);
            this.groupBox1.Controls.Add(this.tbTenKH);
            this.groupBox1.Controls.Add(this.tbMahd);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // cbManv
            // 
            this.cbManv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(136, 102);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(158, 30);
            this.cbManv.TabIndex = 28;
            this.cbManv.TextChanged += new System.EventHandler(this.cbManv_TextChanged);
            // 
            // cbMakh
            // 
            this.cbMakh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMakh.FormattingEnabled = true;
            this.cbMakh.Location = new System.Drawing.Point(568, 23);
            this.cbMakh.Name = "cbMakh";
            this.cbMakh.Size = new System.Drawing.Size(138, 30);
            this.cbMakh.TabIndex = 27;
            this.cbMakh.SelectedIndexChanged += new System.EventHandler(this.cbMakh_SelectedIndexChanged);
            // 
            // cbHD
            // 
            this.cbHD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbHD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbHD.FormattingEnabled = true;
            this.cbHD.Location = new System.Drawing.Point(549, 628);
            this.cbHD.Name = "cbHD";
            this.cbHD.Size = new System.Drawing.Size(138, 24);
            this.cbHD.TabIndex = 26;
            this.cbHD.DropDown += new System.EventHandler(this.cbHD_DropDown);
            // 
            // lbCHU
            // 
            this.lbCHU.AutoSize = true;
            this.lbCHU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCHU.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbCHU.Location = new System.Drawing.Point(12, 361);
            this.lbCHU.Name = "lbCHU";
            this.lbCHU.Size = new System.Drawing.Size(117, 24);
            this.lbCHU.TabIndex = 28;
            this.lbCHU.Text = "Bằng chữ : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(8, 617);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(181, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "* Double click to delete";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(37, 118);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 24);
            this.label18.TabIndex = 31;
            this.label18.Text = "Tour";
            // 
            // tbTim
            // 
            this.tbTim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTim.Location = new System.Drawing.Point(107, 116);
            this.tbTim.Name = "tbTim";
            this.tbTim.Size = new System.Drawing.Size(256, 27);
            this.tbTim.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(381, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 30);
            this.button1.TabIndex = 33;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnTimT_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox4.Controls.Add(this.tbTim);
            this.groupBox4.Controls.Add(this.btnShow);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1071, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(501, 172);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách Tour du lịch";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SkyBlue;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(173, 49);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(142, 39);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show Tour";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dtgDulieu
            // 
            this.dtgDulieu.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dtgDulieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgDulieu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgDulieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDulieu.Location = new System.Drawing.Point(1071, 229);
            this.dtgDulieu.Name = "dtgDulieu";
            this.dtgDulieu.RowHeadersWidth = 51;
            this.dtgDulieu.RowTemplate.Height = 24;
            this.dtgDulieu.Size = new System.Drawing.Size(774, 386);
            this.dtgDulieu.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.payment;
            this.pictureBox1.Location = new System.Drawing.Point(1578, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 214);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1857, 664);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgDulieu);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbCHU);
            this.Controls.Add(this.cbHD);
            this.Controls.Add(this.tbTong);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtgHD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Invoice";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.Form_Invoice_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHD)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDulieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTT;
        private System.Windows.Forms.TextBox tbDG;
        private System.Windows.Forms.TextBox tbTour;
        private System.Windows.Forms.TextBox tbSl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dtgHD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbTong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMahd;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.DateTimePicker tbNB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbHD;
        private System.Windows.Forms.Label lbCHU;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.ComboBox cbMakh;
        private System.Windows.Forms.ComboBox cbMaT;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbTim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgDulieu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbGG;
    }
}