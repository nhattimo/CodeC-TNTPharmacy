namespace GUI.US_
{
    partial class UserControl7
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
            this.txtTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PictureBoxProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtIDProduct = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNameProduct = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtTitle.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTitle.Location = new System.Drawing.Point(263, 130);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(161, 29);
            this.txtTitle.TabIndex = 163;
            this.txtTitle.Text = "Số lượng tồn kho";
            this.txtTitle.UseWaitCursor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantity.Font = new System.Drawing.Font("Noto Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtQuantity.Location = new System.Drawing.Point(466, 120);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(18, 39);
            this.txtQuantity.TabIndex = 162;
            this.txtQuantity.Text = "1";
            this.txtQuantity.UseWaitCursor = true;
            // 
            // PictureBoxProduct
            // 
            this.PictureBoxProduct.ImageRotate = 0F;
            this.PictureBoxProduct.Location = new System.Drawing.Point(15, 18);
            this.PictureBoxProduct.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxProduct.Name = "PictureBoxProduct";
            this.PictureBoxProduct.Size = new System.Drawing.Size(233, 227);
            this.PictureBoxProduct.TabIndex = 164;
            this.PictureBoxProduct.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(263, 220);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(26, 25);
            this.guna2HtmlLabel1.TabIndex = 166;
            this.guna2HtmlLabel1.Text = "ID:";
            this.guna2HtmlLabel1.UseWaitCursor = true;
            // 
            // txtIDProduct
            // 
            this.txtIDProduct.BackColor = System.Drawing.Color.Transparent;
            this.txtIDProduct.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIDProduct.Location = new System.Drawing.Point(321, 216);
            this.txtIDProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDProduct.Name = "txtIDProduct";
            this.txtIDProduct.Size = new System.Drawing.Size(14, 29);
            this.txtIDProduct.TabIndex = 165;
            this.txtIDProduct.Text = "1";
            this.txtIDProduct.UseWaitCursor = true;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.BackColor = System.Drawing.Color.Transparent;
            this.txtNameProduct.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNameProduct.Location = new System.Drawing.Point(263, 18);
            this.txtNameProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(134, 29);
            this.txtNameProduct.TabIndex = 168;
            this.txtNameProduct.Text = "Tên sản phẩm";
            this.txtNameProduct.UseWaitCursor = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UserControl7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtIDProduct);
            this.Controls.Add(this.PictureBoxProduct);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtQuantity);
            this.Name = "UserControl7";
            this.Size = new System.Drawing.Size(580, 263);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel txtTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtQuantity;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtIDProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtNameProduct;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
