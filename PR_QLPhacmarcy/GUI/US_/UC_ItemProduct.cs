using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace GUI.US_
{
    public partial class UC_ItemProduct : UserControl
    {
        private int ID {  get; set; }
        private float Price { get; set; }
        private float PriceDiscount { get; set; }
        private string NameProduct { get; set; }
        private string Image { get; set; }

        public UC_ItemProduct()
        {
            InitializeComponent();
        }
        public UC_ItemProduct( int id, float prive, float priveDiscount, string nameProduct, string image)
        {
            InitializeComponent();
            ID = id;
            Price = prive;
            // nếu có phần trăm giảm giá
            if(priveDiscount != 0)
            {
                // thì giảm giá sản phẩm
                PriceDiscount = (float)Math.Round(prive - ((prive / 100) * priveDiscount), 0) ;
                txtPercent.Text = priveDiscount + "";
                IconPercent.Visible = true;
                this.BackColor = Color.Red;
                txtPrice.ForeColor = Color.White;
                txtPriceDiscount.ForeColor = Color.White;
                guna2HtmlLabel1.ForeColor = Color.White;
            }
            else
            {
                // ẩn giá trị tiền thực và giá giảm = giá gốc
                PriceDiscount = prive;
                txtPrice.Visible = false;
                txtPercent.Text =  "";
                IconPercent.Visible = false;
            }
            NameProduct = nameProduct;
            //Image = image;
            
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            //btnDetail.Visible = false;
            txtID.Text = ID + "";
            txtPrice.Text = Price + ".000";
            txtPriceDiscount.Text = PriceDiscount + ".000";
            txtNameProduct.Text = NameProduct;
  
            PictureBoxProduct.ImageLocation = @"E:\CodeC-TNTPharmacy\PR_QLPhacmarcy\Icon\thuoc-chua-benh-tri-tottri.jpg E:\CodeC - TNTPharmacy\PR_QLPhacmarcy\Icon\thuoc - chua - benh - tri - tottri.jpg";
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ID: " + ID);
        }

        private void PictureBoxProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn sản phẩm với ID = " + ID);
        }
        private void UserControl1_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("TRhanh");*/
        }

        private void UserControl1_MouseHover(object sender, EventArgs e)
        {
            /*if(btnDetail.Visible == false)
                btnDetail.Visible = true;*/
        }

        private void UserControl1_MouseLeave(object sender, EventArgs e)
        {
            /*if (btnDetail.Visible == true)
                btnDetail.Visible = false;*/
        }

       

        
    }
}
