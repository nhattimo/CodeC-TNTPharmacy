namespace GUI.US_
{
    partial class UC_NVBH_CuaHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NVBH_CuaHang));
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanelOrderProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQuantity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ltxtTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientTileButton6 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.flowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.uC_Bill1 = new GUI.US_.UC_Bill();
            this.VScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2Panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel2.BorderRadius = 1;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.VScrollBar);
            this.guna2Panel2.Controls.Add(this.flowLayoutPanelOrderProduct);
            this.guna2Panel2.Controls.Add(this.panel1);
            this.guna2Panel2.Controls.Add(this.guna2GradientTileButton6);
            this.guna2Panel2.Location = new System.Drawing.Point(1152, 2);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(609, 889);
            this.guna2Panel2.TabIndex = 15;
            // 
            // flowLayoutPanelOrderProduct
            // 
            this.flowLayoutPanelOrderProduct.Location = new System.Drawing.Point(19, 101);
            this.flowLayoutPanelOrderProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelOrderProduct.Name = "flowLayoutPanelOrderProduct";
            this.flowLayoutPanelOrderProduct.Size = new System.Drawing.Size(573, 540);
            this.flowLayoutPanelOrderProduct.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ltxtTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Location = new System.Drawing.Point(19, 666);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 220);
            this.panel1.TabIndex = 11;
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoSize = true;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(497, 27);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(27, 29);
            this.txtQuantity.TabIndex = 12;
            this.txtQuantity.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(29, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "SL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(477, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = " VND";
            // 
            // ltxtTotal
            // 
            this.ltxtTotal.AutoSize = true;
            this.ltxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ltxtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ltxtTotal.Location = new System.Drawing.Point(367, 73);
            this.ltxtTotal.Name = "ltxtTotal";
            this.ltxtTotal.Size = new System.Drawing.Size(104, 29);
            this.ltxtTotal.TabIndex = 8;
            this.ltxtTotal.Text = "500.000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(29, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tổng tiền";
            // 
            // btnPay
            // 
            this.btnPay.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnPay.BorderRadius = 10;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPay.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPay.Location = new System.Drawing.Point(293, 137);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(256, 68);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // guna2GradientTileButton6
            // 
            this.guna2GradientTileButton6.Checked = true;
            this.guna2GradientTileButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton6.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.2F, System.Drawing.FontStyle.Bold);
            this.guna2GradientTileButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2GradientTileButton6.Location = new System.Drawing.Point(5, 9);
            this.guna2GradientTileButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientTileButton6.Name = "guna2GradientTileButton6";
            this.guna2GradientTileButton6.Size = new System.Drawing.Size(601, 86);
            this.guna2GradientTileButton6.TabIndex = 10;
            this.guna2GradientTileButton6.Text = "Bán hàng";
            this.guna2GradientTileButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // flowLayoutPanelProducts
            // 
            this.flowLayoutPanelProducts.Location = new System.Drawing.Point(29, 73);
            this.flowLayoutPanelProducts.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            this.flowLayoutPanelProducts.Size = new System.Drawing.Size(1101, 816);
            this.flowLayoutPanelProducts.TabIndex = 14;
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
            this.btnSearch.Location = new System.Drawing.Point(1069, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 53);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseTransparentBackground = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(709, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Tìm kiếm sản phẩm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(421, 54);
            this.txtSearch.TabIndex = 12;
            // 
            // uC_Bill1
            // 
            this.uC_Bill1.Location = new System.Drawing.Point(266, 11);
            this.uC_Bill1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Bill1.Name = "uC_Bill1";
            this.uC_Bill1.Size = new System.Drawing.Size(1339, 880);
            this.uC_Bill1.TabIndex = 16;
            // 
            // VScrollBar
            // 
            this.VScrollBar.InUpdate = false;
            this.VScrollBar.LargeChange = 10;
            this.VScrollBar.Location = new System.Drawing.Point(599, 101);
            this.VScrollBar.Margin = new System.Windows.Forms.Padding(4);
            this.VScrollBar.Name = "VScrollBar";
            this.VScrollBar.ScrollbarSize = 6;
            this.VScrollBar.Size = new System.Drawing.Size(6, 540);
            this.VScrollBar.TabIndex = 27;
            this.VScrollBar.UseWaitCursor = true;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1139, 73);
            this.guna2VScrollBar1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 6;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(6, 815);
            this.guna2VScrollBar1.TabIndex = 28;
            this.guna2VScrollBar1.UseWaitCursor = true;
            // 
            // UC_NVBH_CuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uC_Bill1);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.flowLayoutPanelProducts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_NVBH_CuaHang";
            this.Size = new System.Drawing.Size(1765, 895);
            this.Load += new System.EventHandler(this.UC_NVBH_CuaHang_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrderProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ltxtTotal;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnPay;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProducts;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private UC_ItemChooseProducts userControl21;
        private UC_ItemChooseProducts userControl22;
        private UC_Bill uC_Bill1;
        private Guna.UI2.WinForms.Guna2VScrollBar VScrollBar;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
    }
}
