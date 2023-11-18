﻿namespace GUI
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnChuaCoTK = new Guna.UI2.WinForms.Guna2Button();
            this.labelDNThatBai = new System.Windows.Forms.Label();
            this.btnDangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.labelSaiMk = new System.Windows.Forms.Label();
            this.labelSaiTK = new System.Windows.Forms.Label();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Info;
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel1.BorderRadius = 2;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.btnChuaCoTK);
            this.guna2Panel1.Controls.Add(this.labelDNThatBai);
            this.guna2Panel1.Controls.Add(this.btnDangNhap);
            this.guna2Panel1.Controls.Add(this.labelSaiMk);
            this.guna2Panel1.Controls.Add(this.labelSaiTK);
            this.guna2Panel1.Controls.Add(this.txtMatKhau);
            this.guna2Panel1.Controls.Add(this.txtTenTaiKhoan);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Location = new System.Drawing.Point(486, -6);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(648, 718);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnChuaCoTK
            // 
            this.btnChuaCoTK.BackColor = System.Drawing.Color.Transparent;
            this.btnChuaCoTK.BorderColor = System.Drawing.Color.Transparent;
            this.btnChuaCoTK.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnChuaCoTK.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnChuaCoTK.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnChuaCoTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChuaCoTK.FillColor = System.Drawing.Color.Transparent;
            this.btnChuaCoTK.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Underline);
            this.btnChuaCoTK.ForeColor = System.Drawing.Color.White;
            this.btnChuaCoTK.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnChuaCoTK.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.btnChuaCoTK.Location = new System.Drawing.Point(78, 415);
            this.btnChuaCoTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChuaCoTK.Name = "btnChuaCoTK";
            this.btnChuaCoTK.PressedColor = System.Drawing.Color.Transparent;
            this.btnChuaCoTK.Size = new System.Drawing.Size(272, 41);
            this.btnChuaCoTK.TabIndex = 22;
            this.btnChuaCoTK.Text = "Bạn chưa có tài khoản!";
            this.btnChuaCoTK.Click += new System.EventHandler(this.btnChuaCoTK_Click);
            // 
            // labelDNThatBai
            // 
            this.labelDNThatBai.AutoSize = true;
            this.labelDNThatBai.BackColor = System.Drawing.Color.Transparent;
            this.labelDNThatBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDNThatBai.ForeColor = System.Drawing.Color.Red;
            this.labelDNThatBai.Location = new System.Drawing.Point(255, 478);
            this.labelDNThatBai.Name = "labelDNThatBai";
            this.labelDNThatBai.Size = new System.Drawing.Size(130, 18);
            this.labelDNThatBai.TabIndex = 21;
            this.labelDNThatBai.Text = "Đăng nhập thất bại";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.BorderColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.BorderRadius = 10;
            this.btnDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangNhap.FillColor = System.Drawing.Color.Lime;
            this.btnDangNhap.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Black;
            this.btnDangNhap.Location = new System.Drawing.Point(346, 508);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.PressedColor = System.Drawing.Color.White;
            this.btnDangNhap.Size = new System.Drawing.Size(179, 46);
            this.btnDangNhap.TabIndex = 20;
            this.btnDangNhap.Text = "Đăng nhập";
            // 
            // labelSaiMk
            // 
            this.labelSaiMk.AutoSize = true;
            this.labelSaiMk.BackColor = System.Drawing.Color.Transparent;
            this.labelSaiMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelSaiMk.ForeColor = System.Drawing.Color.Red;
            this.labelSaiMk.Location = new System.Drawing.Point(143, 395);
            this.labelSaiMk.Name = "labelSaiMk";
            this.labelSaiMk.Size = new System.Drawing.Size(28, 18);
            this.labelSaiMk.TabIndex = 19;
            this.labelSaiMk.Text = "Lỗi";
            // 
            // labelSaiTK
            // 
            this.labelSaiTK.AutoSize = true;
            this.labelSaiTK.BackColor = System.Drawing.Color.Transparent;
            this.labelSaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelSaiTK.ForeColor = System.Drawing.Color.Red;
            this.labelSaiTK.Location = new System.Drawing.Point(143, 299);
            this.labelSaiTK.Name = "labelSaiTK";
            this.labelSaiTK.Size = new System.Drawing.Size(28, 18);
            this.labelSaiTK.TabIndex = 18;
            this.labelSaiTK.Text = "Lỗi";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txtMatKhau.BorderRadius = 10;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtMatKhau.IconLeft")));
            this.txtMatKhau.Location = new System.Drawing.Point(112, 340);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMatKhau.PlaceholderText = "Mật khẩu";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(413, 53);
            this.txtMatKhau.TabIndex = 17;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.txtTenTaiKhoan.BorderRadius = 10;
            this.txtTenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTaiKhoan.DefaultText = "";
            this.txtTenTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTaiKhoan.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTenTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTaiKhoan.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTenTaiKhoan.IconLeft")));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(112, 244);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.PasswordChar = '\0';
            this.txtTenTaiKhoan.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTenTaiKhoan.PlaceholderText = "Tên tài khoản";
            this.txtTenTaiKhoan.SelectedText = "";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(413, 53);
            this.txtTenTaiKhoan.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(150, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 73);
            this.label3.TabIndex = 15;
            this.label3.Text = "Đăng nhập";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.IndianRed;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.guna2ControlBox1.CustomIconSize = 15F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(573, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(44, 37);
            this.guna2ControlBox1.TabIndex = 23;
            this.guna2ControlBox1.UseWaitCursor = true;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label labelDNThatBai;
        private Guna.UI2.WinForms.Guna2Button btnDangNhap;
        private System.Windows.Forms.Label labelSaiMk;
        private System.Windows.Forms.Label labelSaiTK;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnChuaCoTK;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}