namespace GUI
{
    partial class FormKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCart = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnMedicines = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSetting = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton7 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.uC_KH_Thuoc1 = new GUI.US_.UC_KH_Thuoc();
            this.uC_KH_Cart1 = new GUI.US_.UC_KH_Cart();
            this.guna2Panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.Controls.Add(this.btnCart);
            this.guna2Panel1.Controls.Add(this.btnSetting);
            this.guna2Panel1.Controls.Add(this.btnMedicines);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(101, 1080);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Transparent;
            this.btnCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCart.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCart.FillColor = System.Drawing.Color.Transparent;
            this.btnCart.FillColor2 = System.Drawing.Color.Transparent;
            this.btnCart.FocusedColor = System.Drawing.Color.IndianRed;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCart.ForeColor = System.Drawing.Color.Black;
            this.btnCart.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.ImageSize = new System.Drawing.Size(45, 45);
            this.btnCart.Location = new System.Drawing.Point(3, 305);
            this.btnCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(96, 135);
            this.btnCart.TabIndex = 2;
            this.btnCart.Text = "Giỏ hàng";
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnMedicines
            // 
            this.btnMedicines.BackColor = System.Drawing.Color.Transparent;
            this.btnMedicines.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMedicines.BackgroundImage")));
            this.btnMedicines.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicines.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicines.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedicines.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedicines.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedicines.FillColor = System.Drawing.Color.Transparent;
            this.btnMedicines.FillColor2 = System.Drawing.Color.Transparent;
            this.btnMedicines.FocusedColor = System.Drawing.Color.IndianRed;
            this.btnMedicines.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMedicines.ForeColor = System.Drawing.Color.Black;
            this.btnMedicines.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnMedicines.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicines.Image")));
            this.btnMedicines.ImageSize = new System.Drawing.Size(45, 45);
            this.btnMedicines.Location = new System.Drawing.Point(3, 167);
            this.btnMedicines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMedicines.Name = "btnMedicines";
            this.btnMedicines.Size = new System.Drawing.Size(96, 135);
            this.btnMedicines.TabIndex = 1;
            this.btnMedicines.Text = "Thuốc";
            this.btnMedicines.Click += new System.EventHandler(this.btnMedicines_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.CustomIconSize = 15F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1864, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(44, 37);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.CustomIconSize = 15F;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1764, 0);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(44, 37);
            this.guna2ControlBox2.TabIndex = 2;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.CustomIconSize = 15F;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1814, 0);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(44, 37);
            this.guna2ControlBox3.TabIndex = 3;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2GradientButton3);
            this.guna2ShadowPanel1.Controls.Add(this.guna2GradientTileButton7);
            this.guna2ShadowPanel1.Controls.Add(this.btnSearch);
            this.guna2ShadowPanel1.Controls.Add(this.txtSearch);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.CadetBlue;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(127, 39);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.ShadowShift = 2;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1765, 97);
            this.guna2ShadowPanel1.TabIndex = 4;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderColor = System.Drawing.Color.BurlyWood;
            this.guna2GradientButton3.BorderRadius = 10;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton3.Image")));
            this.guna2GradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2GradientButton3.Location = new System.Drawing.Point(1481, 14);
            this.guna2GradientButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(271, 68);
            this.guna2GradientButton3.TabIndex = 12;
            this.guna2GradientButton3.Text = "Nguyễn Văn A";
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetting.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetting.FillColor = System.Drawing.Color.Transparent;
            this.btnSetting.FillColor2 = System.Drawing.Color.Transparent;
            this.btnSetting.FocusedColor = System.Drawing.Color.IndianRed;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSetting.ForeColor = System.Drawing.Color.Black;
            this.btnSetting.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageSize = new System.Drawing.Size(60, 60);
            this.btnSetting.Location = new System.Drawing.Point(20, 963);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(61, 53);
            this.btnSetting.TabIndex = 11;
            // 
            // guna2GradientTileButton7
            // 
            this.guna2GradientTileButton7.Checked = true;
            this.guna2GradientTileButton7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton7.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2GradientTileButton7.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2GradientTileButton7.Font = new System.Drawing.Font("Segoe UI Semibold", 20.2F, System.Drawing.FontStyle.Bold);
            this.guna2GradientTileButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2GradientTileButton7.Location = new System.Drawing.Point(20, 5);
            this.guna2GradientTileButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientTileButton7.Name = "guna2GradientTileButton7";
            this.guna2GradientTileButton7.Size = new System.Drawing.Size(339, 86);
            this.guna2GradientTileButton7.TabIndex = 9;
            this.guna2GradientTileButton7.Text = "Logo";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.FillColor2 = System.Drawing.Color.Transparent;
            this.btnSearch.FocusedColor = System.Drawing.Color.IndianRed;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.HoverState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSearch.Location = new System.Drawing.Point(1061, 22);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 53);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseTransparentBackground = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(644, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Tìm kiếm sản phẩm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(477, 53);
            this.txtSearch.TabIndex = 0;
            // 
            // uC_KH_Thuoc1
            // 
            this.uC_KH_Thuoc1.Location = new System.Drawing.Point(127, 158);
            this.uC_KH_Thuoc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_KH_Thuoc1.Name = "uC_KH_Thuoc1";
            this.uC_KH_Thuoc1.Size = new System.Drawing.Size(1765, 895);
            this.uC_KH_Thuoc1.TabIndex = 7;
            // 
            // uC_KH_Cart1
            // 
            this.uC_KH_Cart1.Location = new System.Drawing.Point(127, 158);
            this.uC_KH_Cart1.Name = "uC_KH_Cart1";
            this.uC_KH_Cart1.Size = new System.Drawing.Size(1765, 895);
            this.uC_KH_Cart1.TabIndex = 8;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.uC_KH_Cart1);
            this.Controls.Add(this.uC_KH_Thuoc1);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormKhachHang";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnMedicines;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnCart;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnSearch;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton7;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnSetting;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private US_.UC_KH_Thuoc uC_KH_Thuoc1;
        private US_.UC_KH_Cart uC_KH_Cart1;
    }
}