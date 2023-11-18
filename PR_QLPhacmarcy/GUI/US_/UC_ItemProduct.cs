using System;
using System.Windows.Forms;

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
            PriceDiscount = priveDiscount;
            NameProduct = nameProduct;
            
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            //btnDetail.Visible = false;
            txtID.Text = ID + "";
            txtPrice.Text = Price + ".000";
            txtPriceDiscount.Text = PriceDiscount + ".000";
            txtNameProduct.Text = NameProduct;

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
