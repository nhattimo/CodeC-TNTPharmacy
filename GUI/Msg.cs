using BLL;
using DTO;
using GUI.US_;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class Msg : Form
    {
        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();
        private readonly SuppliersBusinessLogic _Suppliers = new SuppliersBusinessLogic();
        public Msg()
        {
            InitializeComponent();
        }
        public Msg(int ID)
        {
            InitializeComponent();
            AddInfoProduct();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void AddInfoProduct()
        {
            Products obj = _Product.GetObjectById(Management.GetIDProduct());
            Suppliers suppliers = _Suppliers.GetObjectById(obj.SupplierId);
            txtSupplier.Text = suppliers.Name;
            txtProductName.Text = "Nhaatj timo";
            txtPrice.Text = (Math.Round(obj.Price - ((obj.Price / 100) * obj.Discount), 0)) + ".000 VND";
            txtCost.Text = obj.Price + ".000 VND";
            txtDiscount.Text = obj.Discount + " %";
            txtProductionDate.Text = obj.ProductionDate + "";
            txtExpiryDate.Text = obj.ExpiryDate + "";
            txtDescribe.Text = obj.Description;
            try
            {
                picAnh.Image = System.Drawing.Image.FromFile(obj.Image);
            }
            catch (Exception)
            {

            }
        }

        private void Msg_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(590, 250);
        }
    }
}
