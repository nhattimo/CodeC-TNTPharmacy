using BLL;
using DTO;
using GUI.US_;
using System;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GUI.US_Interface.From_CRUD
{
    public partial class Form_NVBH_Bill : Form
    {
        private readonly EmployeesBusinessLogic _Employees = new EmployeesBusinessLogic();
        private readonly UsersBusinessLogic _Users = new UsersBusinessLogic();
        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();

        Users obj = new Users();
        double total;
        int SLTong;
        string Point;
        public Form_NVBH_Bill()
        {
            InitializeComponent();
        }

        public Form_NVBH_Bill(double total, int sl )
        {
            InitializeComponent();
            this.total = total;
            this.SLTong = sl;
            Point = "";
        }

        private void Form_NVBH_Bill_Load(object sender, System.EventArgs e)
        {
            txtDateNow.Text = DateTime.Now.ToString();
            txtIDOrder.Text = "";
            var obj = _Employees.GetObjectById(Management.GetIDAccount());
            txtSalesAgent.Text = obj.ID + " " + obj.Name;

            PanelInfoCustomer.Visible = false;
            guna2Panel3.Visible = false;
            CustomGradientPanel.Visible = false;
            flowLayoutPanelCustomer.Visible = false;

            RadioButtoNoAccount.Checked = true;

            errorCustomer.Visible = false;

            ShowOrder();
        }

        private void RadioButtonHaveAccount_CheckedChanged(object sender, EventArgs e)
        {
            CustomGradientPanel.Visible = true;
            PanelCustomer.Visible = false;
            guna2Panel3.Visible = false;
        }

        private void RadioButtoNoAccount_CheckedChanged(object sender, EventArgs e)
        {
            CustomGradientPanel.Visible = false;
            PanelCustomer.Visible = true;
            flowLayoutPanelCustomer.Visible = false;
        }
       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // nếu có tài khoản thì show người dùng ra 
            if (string.IsNullOrEmpty(txtIDCustomer.Text))
            {
                errorCustomer.Visible = true;
            }
            else 
            {
                errorCustomer.Visible = false;

                obj = _Users.GetObjectById(int.Parse(txtIDCustomer.Text));
                if (obj == null)
                {
                    obj = _Users.GetObjectByPhone(txtIDCustomer.Text);
                }

                if (obj != null)
                {
                    PanelInfoCustomer.Visible = true;
                    flowLayoutPanelCustomer.Visible=true;
                    txtNameCustomer.Text = obj.Name;
                    txtPhoneCustomer.Text = obj.Phone;
                    txtScores.Text = obj.Point;
                    Management.AddItemsUC(flowLayoutPanelCustomer, obj);
                }
                else
                {
                    MessageBox.Show("Không có khách hàng");
                }
            }

            
            
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPaymentAndPrinting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán và in hóa đơn thành công");
            Management.ResestIDItemChooseProducts();
            if (RadioButtonHaveAccount.Checked)
            {
                
                obj.Point = (int.Parse(obj.Point) + int.Parse(Point)) + "";
                _Users.Update(obj.ID, obj);
            }
            this.Close();
        }

        private void DataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void ShowOrder()
        {
            float cost = 0 ;
            double priceDiscount = 0;
            double price = 0;
            DataGridViewProducts.Rows.Clear();
            DataGridViewProducts.ColumnCount = 5;
            DataGridViewProducts.Columns[0].Name = "Tên sản phẩm";
            DataGridViewProducts.Columns[1].Name = "Số lượng";
            DataGridViewProducts.Columns[2].Name = "Đơn giá";
            DataGridViewProducts.Columns[3].Name = "Giá giảm";
            DataGridViewProducts.Columns[4].Name = "Tổng giá";
            
            foreach (var item in Management.GetIDItemChooseProducts())
            {
                int sl = item[1];
                Products obj = _Product.GetObjectById(item[0]);
                string[] row = { obj.Name, sl + "", obj.Price + ".000 VND", (obj.Price - (Math.Round(obj.Price - ((obj.Price / 100) * obj.Discount), 0))) * sl + ".000 VND" , Math.Round((obj.Price - (obj.Price / 100) * obj.Discount), 0) * sl + ".000 VND" };
                DataGridViewProducts.Rows.Add(row);

                cost += obj.Price * sl;
                priceDiscount += (obj.Price - Math.Round(obj.Price - (obj.Price / 100 * obj.Discount), 0)) * sl;
                price += ((Math.Round(obj.Price - ((obj.Price / 100) * obj.Discount), 0))) * sl  ;
                
            }

            // tổng tiền giá bán
            txtTotal.Text = total + ".000";

            // Tổng tiền giá gốc
            txtCost.Text = cost  + ".000 VND";

            // tổng tiền giảm
            txtPriceDiscount.Text = "- " + priceDiscount + ".000 VND";

            // tổng số lượng mua
            txtQuantity.Text = SLTong + "";

            // tổng tiền cần trả
            txtPrice.Text = price + ".000 VND";

            // tổng tiền cần trả
            txtTotal.Text = price + ".000";

            Point = Math.Round((price / 3 * SLTong + 1), 0) + "";
            MessageBox.Show(Point);
        }

        private void btnChose_Click(object sender, EventArgs e)
        {

            txtNameCoustumer.Text = txtNameInput.Text;
            guna2Panel3.Visible = true;
        }
    }
}
