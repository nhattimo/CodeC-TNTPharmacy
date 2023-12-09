using BLL;
using DTO;
using Guna.UI2.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_KH_OrderInformation : UserControl
    {
        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();
        private readonly UsersBusinessLogic _Users = new UsersBusinessLogic();
        
        double total = 0;
        int sl = 0;

        Users _ObjUsers;


        public UC_KH_OrderInformation()
        {
            InitializeComponent();
            _ObjUsers = _Users.GetObjectByIdtk(Management.GetIDAccount());
            //AddItemProducts();
        }

        private void UC_KH_OrderInformation_Load(object sender, EventArgs e)
        {
            PanelScrollHelper panelScrollHelper = new PanelScrollHelper(flowLayoutPanelIteamProduct, VScrollBar);
            PushCustomerInformation();
            
            RadioButtonFastShipping.Checked = true;
            RadioButtonDirectPayment.Checked = true;

            RunContinuousFunction();
            // đẩy thông tin item sản phẩm
        }


        async Task RunContinuousFunction()
        {
            int ItemLeng = Management.GetIDItemChooseProducts().Count;
            while (true)
            {
                if (Management.GetIDItemChooseProducts() == null)
                {
                    flowLayoutPanelIteamProduct.Controls.Clear();
                    //panelPay.Visible = false;
                }
                else
                {
                    if (this.Visible != false)
                    {
                        // điều kiện btn pay
                        if (ItemLeng > 0)
                        {
                            /*if (panelPay.Visible != true)
                                panelPay.Visible = true;*/
                        }
                        else
                        {
                            /*if (panelPay.Visible != false)
                                panelPay.Visible = false;*/
                        }

                        // nếu độ dài thay đổi có nghĩa là có sự thay đổi 
                        if (Management.GetIDItemChooseProducts().Count > ItemLeng || Management.GetIDItemChooseProducts().Count < ItemLeng)
                        {
                            ItemLeng = Management.GetIDItemChooseProducts().Count;
                            LoadItemChooseProducts();
                            // tính tiền tổng sản phẩm đã chọn
                            LoadPanlePay();
                        }
                        else
                        {
                            LoadPanlePay();
                        }
                        /*else if(Management.GetIDItemChooseProducts().Count < leng)
                        {
                            leng = Management.GetIDItemChooseProducts().Count;
                            Console.WriteLine("Giảm 1" + "Số lượng hiện tại: " + leng);
                        }*/
                    }

                }
                await Task.Delay(100);
            }
        }
        private void LoadPanlePay()
        {
            total = 0;
            sl = 0;
            foreach (var item in Management.GetIDItemChooseProducts())
            {
                var obj = _Product.GetObjectById(item[0]);
                sl += item[1];
                total += (Math.Round(obj.Price - ((obj.Price / 100) * obj.Discount), 0)) * item[1];
            }
            txtQuantity.Text = sl + "";
            txtTotal.Text = total + ".000";

        }


        #region Event

        // btn đặt hàng
        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            // phương thức vận chuyển
            if (RadioButtonFastShipping.Checked == true)
            {
                // add vào database table SalesOrder
                AddSalesOrderInformation(date, "Trạng thái", 1, 1.1f, 1, 1);

            }
            else
            {
                // add vào database table SalesOrder
                AddSalesOrderInformation(date, "Trạng thái", 1, 1.1f, 1, 1);
            }

            // phương thức thanh toán
            if (RadioButtonDirectPayment.Checked == true)
            {
                // add vào database table PayMent
                AddPayMentInformation(1, 1, 1);

            }
            else
            {

                // add vào database table PayMent
                AddPayMentInformation(1, 1, 1);
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            // làm mới dữ liệu
        }
        #endregion
        




        #region Function

        // đẩy thông tin khách hàng
        void PushCustomerInformation()
        {
            txtNameCustomer.Text = _ObjUsers.Name;
            txtPhone.Text = _ObjUsers.Phone;
            txtAddress.Text = _ObjUsers.Address;

        }
        // Add dữ liệu thông tin thanh toán
        void AddPayMentInformation(int MethodId, int CustomerId, float TotalPrice)
        {
            // add vào database table PayMent
            // MethodId = 
            // CustomerId = 
            // TotalPrice = 
        }
        // Add dữ liệu thông tin đơn hàng online
        void AddSalesOrderInformation(DateTime dateTime, string status, int shippingID, float totalAmount, int paymentID, int customerID)
        {
            // add vào database table SalesOrder
            // OrderDate = 
            // Status = 
            // ShippingId =
            // TotalAmount = 
            // PaymentId = 
            // CustomerId = 
        }
        private void LoadItemChooseProducts()
        {
            List<UC_ItemChooseProducts> listObj = new List<UC_ItemChooseProducts> { };
            foreach (var item in Management.GetIDItemChooseProducts())
            {
                UC_ItemChooseProducts itemUC = new UC_ItemChooseProducts(item[0], item[1]);
                listObj.Add(itemUC);
            }
            flowLayoutPanelIteamProduct.Controls.Clear();
            Management.AddItemsUC(flowLayoutPanelIteamProduct, listObj);
        }
        #endregion


    }
}
