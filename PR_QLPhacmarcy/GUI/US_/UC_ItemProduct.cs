using BLL;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_ItemProduct : UserControl
    {
        public readonly AccountBusinesLogiccs _objectBusinesLogiccs = new AccountBusinesLogiccs();

        private int ID {  get; set; }
        private float Price { get; set; }
        private float PriceDiscount { get; set; }
        private string NameProduct { get; set; }
        private string ImagesString { get; set; }

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
            ImagesString = image;  
        }
        
        private void UserControl1_Load(object sender, EventArgs e)
        {
            //btnDetail.Visible = false;
            txtID.Text = ID + "";
            txtPrice.Text = Price + ".000";
            txtPriceDiscount.Text = PriceDiscount + ".000";
            txtNameProduct.Text = NameProduct;
            if (File.Exists(ImagesString)) // Kiểm tra xem tệp hình ảnh có tồn tại hay không
            {
                try
                {
                    Image image = Image.FromFile(ImagesString); // Tạo đối tượng hình ảnh từ đường dẫn

                    PictureBoxProduct.Image = image; // Gán hình ảnh cho PictureBox
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                /*MessageBox.Show("Tệp hình ảnh không tồn tại.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }

        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ID: " + ID);
        }

        private void PictureBoxProduct_Click(object sender, EventArgs e)
        {
            // nếu là vai trò quản lý
            if(_objectBusinesLogiccs.GetRole(Management.GetIDAccount()) == 1)
            {
                Management.SetIDProduct(ID);
                //MessageBox.Show("Chọn sản phẩm với ID = " + Management.GetIDProduct() + " với vai trò quản lý");
                UC_QL_Thuoc.Instance.AddThongTinSanPham( e);
            }else
               MessageBox.Show("Chọn sản phẩm với ID = " + ID + " với vai Khác");
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
