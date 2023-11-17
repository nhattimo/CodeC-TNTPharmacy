namespace GUI.US_
{
    partial class UserControl1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtNameProduct = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtID = new System.Windows.Forms.Label();
            this.PictureBoxProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDetail = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtPriceDiscount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.txtNameProduct);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(-8, 271);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(260, 44);
            this.guna2CustomGradientPanel1.TabIndex = 7;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.BackColor = System.Drawing.Color.White;
            this.txtNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNameProduct.Location = new System.Drawing.Point(11, 9);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(129, 27);
            this.txtNameProduct.TabIndex = 8;
            this.txtNameProduct.Text = "Tên sản phẩm";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.ForeColor = System.Drawing.Color.Transparent;
            this.txtID.Location = new System.Drawing.Point(-202, 83);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(44, 16);
            this.txtID.TabIndex = 8;
            this.txtID.Text = "label1";
            // 
            // PictureBoxProduct
            // 
            this.PictureBoxProduct.ImageRotate = 0F;
            this.PictureBoxProduct.Location = new System.Drawing.Point(9, 8);
            this.PictureBoxProduct.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxProduct.Name = "PictureBoxProduct";
            this.PictureBoxProduct.Size = new System.Drawing.Size(233, 227);
            this.PictureBoxProduct.TabIndex = 10;
            this.PictureBoxProduct.TabStop = false;
            this.PictureBoxProduct.Click += new System.EventHandler(this.PictureBoxProduct_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetail.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDetail.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.btnDetail.ForeColor = System.Drawing.Color.Black;
            this.btnDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnDetail.Image")));
            this.btnDetail.Location = new System.Drawing.Point(154, 0);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(96, 35);
            this.btnDetail.TabIndex = 11;
            this.btnDetail.Text = "Chi tiết";
            // 
            // txtPriceDiscount
            // 
            this.txtPriceDiscount.BackColor = System.Drawing.Color.Transparent;
            this.txtPriceDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPriceDiscount.Location = new System.Drawing.Point(121, 238);
            this.txtPriceDiscount.Name = "txtPriceDiscount";
            this.txtPriceDiscount.Size = new System.Drawing.Size(121, 27);
            this.txtPriceDiscount.TabIndex = 12;
            this.txtPriceDiscount.Text = "300.000 VND";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPrice.Location = new System.Drawing.Point(9, 243);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(61, 22);
            this.txtPrice.TabIndex = 13;
            this.txtPrice.Text = "350.000 ";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPriceDiscount);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.PictureBoxProduct);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(252, 315);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Click += new System.EventHandler(this.UserControl1_Click);
            this.MouseLeave += new System.EventHandler(this.UserControl1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.UserControl1_MouseHover);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtNameProduct;
        private System.Windows.Forms.Label txtID;
        private Guna.UI2.WinForms.Guna2GradientButton btnDetail;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtPriceDiscount;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtPrice;
    }
}
