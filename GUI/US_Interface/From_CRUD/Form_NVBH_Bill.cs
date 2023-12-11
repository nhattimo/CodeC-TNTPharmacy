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
        private readonly BillOfflineDetailBusinessLogic _BillOfflineDetail = new BillOfflineDetailBusinessLogic();
        private readonly BillOfflineBusinessLogic _BillOffline = new BillOfflineBusinessLogic();



        Users obj = new Users();
        BillOffline _ObjBillOffline;
        BillOfflineDetail _ObjBillOfflineDetail;
        Employees _ObjEmployees;
        Products _ObjProducts;

        float _Total;
        int _SLTong;
        string Point;

        public Form_NVBH_Bill()
        {
            InitializeComponent();
        }

        public Form_NVBH_Bill(float total, int sl )
        {
            InitializeComponent();
            _ObjEmployees = _Employees.GetObjectByIdtk(Management.GetIDAccount());
            this._Total = total;
            this._SLTong = sl;
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
            Management.ResestIDItemChooseProducts();
            this.Close();
        }

        private void btnPaymentAndPrinting_Click(object sender, EventArgs e)
        {
            //
            DateTime time = DateTime.Now;
            _ObjBillOffline =  new BillOffline();
            _ObjBillOffline.CreatedDate = time;
            _ObjBillOffline.TotalAmount = (int)_Total;
            _ObjBillOffline.CreatedBy = _ObjEmployees.ID;
            _ObjBillOffline.IDCustomer = null;
            //

            // nếu có tài khoản thì add tích điểm cho khác hàng
            if (RadioButtonHaveAccount.Checked)
            {
                _ObjBillOffline.IDCustomer = obj.ID;
                obj.Point = (int.Parse(obj.Point) + int.Parse(Point)) + "";
                _Users.Update(obj.ID, obj);
            }
            _BillOffline.AddBillOffline(_ObjBillOffline);

            foreach (var item in Management.GetIDItemChooseProducts())
            {
                _ObjProducts = _Product.GetObjectById(item[0]);
                _ObjBillOfflineDetail = new BillOfflineDetail();
                _ObjBillOfflineDetail.Quantity = item[1]; // số lượng
                _ObjBillOfflineDetail.SoldPrice = (float)(Math.Round(_ObjProducts.Price - ((_ObjProducts.Price / 100) * _ObjProducts.Discount), 0)); // giá bán
                _ObjBillOfflineDetail.TotalAmount = (int)(Math.Round(_ObjProducts.Price - ((_ObjProducts.Price / 100) * _ObjProducts.Discount), 0)) * item[1]; // tồng giá bán
                _ObjBillOfflineDetail.IDPruduct = _ObjProducts.ID; // id sản phẩm
                _ObjBillOfflineDetail.IDBill = _ObjBillOffline.ID;  // 
                _BillOfflineDetail.Add(_ObjBillOfflineDetail);
            }

            MessageBox.Show("Thanh toán và in hóa đơn thành công");
            Management.ResestIDItemChooseProducts();
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
            txtTotal.Text = _Total + ".000";

            // Tổng tiền giá gốc
            txtCost.Text = cost  + ".000 VND";

            // tổng tiền giảm
            txtPriceDiscount.Text = "- " + priceDiscount + ".000 VND";

            // tổng số lượng mua
            txtQuantity.Text = _SLTong + "";

            // tổng tiền cần trả
            txtPrice.Text = price + ".000 VND";

            // tổng tiền cần trả
            txtTotal.Text = price + ".000";

            Point = Math.Round((price / 3 * _SLTong + 1), 0) + "";
            MessageBox.Show(Point);
        }

        private void btnChose_Click(object sender, EventArgs e)
        {

            txtNameCoustumer.Text = txtNameInput.Text;
            guna2Panel3.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
