
namespace WindowsFormsApp1
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIV = new System.Windows.Forms.Button();
            this.btnRP = new System.Windows.Forms.Button();
            this.btnNV = new System.Windows.Forms.Button();
            this.btnBK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(1114, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quản lý hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(329, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quản lý Tour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(30, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quản lý nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCS);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnIV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnNV);
            this.panel1.Controls.Add(this.btnBK);
            this.panel1.ForeColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(11, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 332);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(554, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quản lý khách hàng";
            // 
            // btnCS
            // 
            this.btnCS.BackColor = System.Drawing.Color.White;
            this.btnCS.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.invoice1;
            this.btnCS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCS.ForeColor = System.Drawing.Color.Black;
            this.btnCS.Image = global::WindowsFormsApp1.Properties.Resources.traveller;
            this.btnCS.Location = new System.Drawing.Point(579, 36);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(203, 205);
            this.btnCS.TabIndex = 8;
            this.btnCS.UseVisualStyleBackColor = false;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(849, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thống kê, báo cáo";
            // 
            // btnIV
            // 
            this.btnIV.BackColor = System.Drawing.Color.White;
            this.btnIV.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.invoice1;
            this.btnIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIV.ForeColor = System.Drawing.Color.Black;
            this.btnIV.Location = new System.Drawing.Point(1120, 36);
            this.btnIV.Name = "btnIV";
            this.btnIV.Size = new System.Drawing.Size(203, 205);
            this.btnIV.TabIndex = 6;
            this.btnIV.UseVisualStyleBackColor = false;
            this.btnIV.Click += new System.EventHandler(this.btnIV_Click);
            // 
            // btnRP
            // 
            this.btnRP.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.báo_cáo;
            this.btnRP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRP.ForeColor = System.Drawing.Color.Black;
            this.btnRP.Location = new System.Drawing.Point(854, 36);
            this.btnRP.Name = "btnRP";
            this.btnRP.Size = new System.Drawing.Size(203, 205);
            this.btnRP.TabIndex = 0;
            this.btnRP.UseVisualStyleBackColor = true;
            this.btnRP.Click += new System.EventHandler(this.btnRP_Click);
            // 
            // btnNV
            // 
            this.btnNV.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.employee;
            this.btnNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNV.ForeColor = System.Drawing.Color.Black;
            this.btnNV.Location = new System.Drawing.Point(35, 36);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(210, 205);
            this.btnNV.TabIndex = 2;
            this.btnNV.UseVisualStyleBackColor = true;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // btnBK
            // 
            this.btnBK.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.booking;
            this.btnBK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBK.ForeColor = System.Drawing.Color.Black;
            this.btnBK.Location = new System.Drawing.Point(309, 36);
            this.btnBK.Name = "btnBK";
            this.btnBK.Size = new System.Drawing.Size(203, 205);
            this.btnBK.TabIndex = 1;
            this.btnBK.UseVisualStyleBackColor = true;
            this.btnBK.Click += new System.EventHandler(this.btnBK_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(469, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hệ thống quản lý Tour du lịch iViVu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.thoátToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnExit});
            this.thoátToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.thoátToolStripMenuItem.Text = "&Hệ thống";
            // 
            // mnExit
            // 
            this.mnExit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(116, 26);
            this.mnExit.Text = "&Exit";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1383, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.tải_xuống;
            this.pictureBox1.Location = new System.Drawing.Point(246, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1383, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "Hệ thống quản lý ";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBK;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIV;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCS;
    }
}

