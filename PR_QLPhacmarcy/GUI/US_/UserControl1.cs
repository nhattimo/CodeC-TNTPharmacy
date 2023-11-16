using System;
using System.Drawing;
using System.Management;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UserControl1 : UserControl
    {
        private int ID {  get; set; }
        private float Price { get; set; }
        private string NameProduct { get; set; }
        private string Image { get; set; }

        public UserControl1()
        {
            InitializeComponent();
        }
        public UserControl1( int id, float prive, string nameProduct, string image)
        {
            txtID.Text = id + "";
            txtPriceDiscount.Text = prive + "";
            txtNameProduct.Text = nameProduct;
            
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            //btnDetail.Visible = false;
            txtNameProduct.Text = "Tên sản phẩm";
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
        public void AddGT(string aa)
        {
            txtPriceDiscount.Text = aa;
        }

        

        private void PictureBoxProduct_Click(object sender, EventArgs e)
        {
            
        }
    }
}
