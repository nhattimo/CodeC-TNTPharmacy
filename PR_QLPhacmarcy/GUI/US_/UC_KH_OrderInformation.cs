using System;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_KH_OrderInformation : UserControl
    {
        public UC_KH_OrderInformation()
        {
            InitializeComponent();
            //AddItemProducts();
        }

        private void UC_KH_OrderInformation_Load(object sender, EventArgs e)
        {
            PushCustomerInformation();
            RadioButtonFastShipping.Checked = true;
            RadioButtonDirectPayment.Checked = true;
            // đẩy thông tin item sản phẩm
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
            txtNameCustomer.Text = "tên người khách hành";
            txtPhone.Text = "Số điện thoại khách hành";
            txtAddress.Text = "Địa chỉ";

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

        void AddItemProducts(FlowLayoutPanel flowLayoutPanel, System.Windows.Forms.UserControl[] uC)
        {
            Management.AddItemsUC(flowLayoutPanel, uC);
        }
        #endregion

       
    }
}
