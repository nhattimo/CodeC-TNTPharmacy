namespace GUI.US_
{
    partial class UC_ItemChooseProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ItemChooseProducts));
            this.txtNumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNameProduct = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnDeleteItem = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.txtCost = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPriceDiscount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PictureBoxProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumericUpDown1
            // 
            this.txtNumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.txtNumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumericUpDown1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtNumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNumericUpDown1.Location = new System.Drawing.Point(396, 14);
            this.txtNumericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumericUpDown1.Name = "txtNumericUpDown1";
            this.txtNumericUpDown1.Size = new System.Drawing.Size(150, 42);
            this.txtNumericUpDown1.TabIndex = 0;
            this.txtNumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.CadetBlue;
            this.txtNumericUpDown1.ValueChanged += new System.EventHandler(this.txtNumericUpDown1_ValueChanged_1);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPrice.Location = new System.Drawing.Point(396, 136);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 27);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.Text = "300.000 VND";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.BackColor = System.Drawing.Color.Transparent;
            this.txtNameProduct.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNameProduct.Location = new System.Drawing.Point(68, 14);
            this.txtNameProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(150, 33);
            this.txtNameProduct.TabIndex = 7;
            this.txtNameProduct.Text = "Tên sản phẩm";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteItem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteItem.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteItem.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDeleteItem.FocusedColor = System.Drawing.Color.IndianRed;
            this.btnDeleteItem.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnDeleteItem.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteItem.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnDeleteItem.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteItem.HoverState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteItem.Image")));
            this.btnDeleteItem.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDeleteItem.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(62, 191);
            this.btnDeleteItem.TabIndex = 9;
            this.btnDeleteItem.UseTransparentBackground = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.Transparent;
            this.txtCost.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCost.Location = new System.Drawing.Point(396, 78);
            this.txtCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(105, 25);
            this.txtCost.TabIndex = 13;
            this.txtCost.Text = "300.000 VND";
            // 
            // txtPriceDiscount
            // 
            this.txtPriceDiscount.BackColor = System.Drawing.Color.Transparent;
            this.txtPriceDiscount.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPriceDiscount.Location = new System.Drawing.Point(396, 107);
            this.txtPriceDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPriceDiscount.Name = "txtPriceDiscount";
            this.txtPriceDiscount.Size = new System.Drawing.Size(101, 25);
            this.txtPriceDiscount.TabIndex = 14;
            this.txtPriceDiscount.Text = "-20.000 VND";
            // 
            // PictureBoxProduct
            // 
            this.PictureBoxProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.PictureBoxProduct.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxProduct.ErrorImage")));
            this.PictureBoxProduct.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxProduct.Image")));
            this.PictureBoxProduct.ImageLocation = "";
            this.PictureBoxProduct.ImageRotate = 0F;
            this.PictureBoxProduct.Location = new System.Drawing.Point(68, 49);
            this.PictureBoxProduct.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxProduct.Name = "PictureBoxProduct";
            this.PictureBoxProduct.Size = new System.Drawing.Size(120, 128);
            this.PictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxProduct.TabIndex = 15;
            this.PictureBoxProduct.TabStop = false;
            // 
            // UC_ItemChooseProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.PictureBoxProduct);
            this.Controls.Add(this.txtPriceDiscount);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNumericUpDown1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_ItemChooseProducts";
            this.Size = new System.Drawing.Size(563, 191);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown txtNumericUpDown1;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtNameProduct;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnDeleteItem;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtCost;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtPriceDiscount;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxProduct;
    }
}
