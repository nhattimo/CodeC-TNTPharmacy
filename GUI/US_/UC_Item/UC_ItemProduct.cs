using BLL;
using DTO;
using GUI.US_.From_CRUD;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_ItemProduct : UserControl
    {
        public readonly AccountBusinesLogiccs _objectBusinesLogiccs = new AccountBusinesLogiccs();
        public readonly ProductBusinessLogic _ProductBusinesLogiccs = new ProductBusinessLogic();
        private int ID {  get; set; }
        private float Price { get; set; }
        private float PriceDiscount { get; set; }
        private string NameProduct { get; set; }
        private string ImagesString { get; set; }

        public UC_ItemProduct()
        {
            InitializeComponent();
        }
        public UC_ItemProduct( int id)
        {
            
            InitializeComponent();
            Products obj = _ProductBusinesLogiccs.GetObjectById(id);
            ID = obj.ID;
            Price = obj.Price;
            NameProduct = obj.Name;
            // nếu có phần trăm giảm giá
            if (obj.Discount != 0)
            {
                // thì giảm giá sản phẩm
                PriceDiscount = (float)Math.Round(obj.Price - ((obj.Price / 100) * obj.Discount), 0) ;
                txtPercent.Text = obj.Discount + "";
                IconPercent.Visible = true; // icon % giảm giá
                
                // đổi màu khi đc giảm giá
                /*this.BackColor = Color.Red;
                txtPrice.ForeColor = Color.White;
                txtPriceDiscount.ForeColor = Color.White;
                guna2HtmlLabel1.ForeColor = Color.White;*/
            }
            else
            {
                // ẩn giá trị tiền thực và giá giảm = giá gốc
                PriceDiscount = obj.Price;
                txtPrice.Visible = false;
                txtPercent.Text =  "";
                IconPercent.Visible = false;
            }
            // kiểm tra ảnh
            if (File.Exists(obj.Image)) // Kiểm tra xem tệp hình ảnh có tồn tại hay không
            {
                try
                {
                    PictureBoxProduct.Image = Image.FromFile(obj.Image);
                    ImagesString = obj.Image;
                }
                catch 
                {
                    PictureBoxProduct.Image = null;
                }
            }
            else
            {
                // ảnh không tồn tại
                PictureBoxProduct.Image = null;
            } 
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
            Form_QL_Thuoc_CRUD form = new Form_QL_Thuoc_CRUD(ID);
            form.ShowDialog();
        }

        private void PictureBoxProduct_Click(object sender, EventArgs e)
        {
            // Nếu là vai trò quản lý
            if (_objectBusinesLogiccs.GetRole(Management.GetIDAccount()) == 1)
            {
                Management.SetIDProduct(ID);
            }
            else
            {
                MessageBox.Show("Chọn sản phẩm với ID = " + ID + " với vai Khác");
            }
        }
    }
}
