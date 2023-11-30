using BLL;
using DTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_ItemChooseProducts : UserControl
    {
        public readonly ProductBusinessLogic _ProductBusinesLogiccs = new ProductBusinessLogic();
        private int ID { get; set; }
        decimal Sl { get; set; }
        public UC_ItemChooseProducts(int IDProduct, int sl)
        {
            InitializeComponent();
            ID = IDProduct;
            txtNumericUpDown1.UpButton();
            txtNumericUpDown1.Value = sl;
            Sl = txtNumericUpDown1.Value;
            Products obj = _ProductBusinesLogiccs.GetObjectById(ID);
            txtNameProduct.Text = obj.Name;
            txtCost.Text = (obj.Price * int.Parse(Sl.ToString())) + ".000 VND";
            txtPriceDiscount.Text = "- " + (obj.Price - (Math.Round(obj.Price - ((obj.Price / 100) * obj.Discount), 0))) * int.Parse(Sl.ToString()) + ".000 VND";
            txtPrice.Text = ((Math.Round(obj.Price - ((obj.Price / 100) * obj.Discount), 0))) * int.Parse(Sl.ToString()) + ".000 VND";
            if (File.Exists(obj.Image)) // Kiểm tra xem tệp hình ảnh có tồn tại hay không
            {
                try
                {
                    PictureBoxProduct.Image = Image.FromFile(obj.Image);
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

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            Management.SetIDItemChooseProducts(ID, int.Parse(Sl.ToString()), false, 1);
            this.Hide();
            this.Controls.Remove(this);
        }

        private void txtNumericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            if (Sl != txtNumericUpDown1.Value)
            {
                Sl = txtNumericUpDown1.Value;
                Products obj = _ProductBusinesLogiccs.GetObjectById(ID);
                txtCost.Text = (obj.Price * int.Parse(Sl.ToString())) + ".000 VND";
                txtPriceDiscount.Text = (obj.Price - (Math.Round(obj.Price - ((obj.Price / 100) * obj.Discount), 0))) * int.Parse(Sl.ToString()) + ".000 VND";
                txtPrice.Text = ((Math.Round(obj.Price - ((obj.Price / 100) * obj.Discount), 0))) * int.Parse(Sl.ToString()) + ".000 VND";
                Management.SetIDItemChooseProducts(ID, int.Parse(Sl.ToString()), true, 1);
            }
        }
    }
}
