using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC_ItemOnlineOrders : UserControl
    {

        /*
         * Đang chuẩn bị hàng
        Đang chờ vận chuyển nhận hàng
        Đang giao hàng
        Đã nhận được hàng
        Hoàn trả
        Hủy đơn 
        Không nhận hàng
        */
        public UC_ItemOnlineOrders()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            btnAccept.Text = "Nhận đơn";
            btnComplete.Visible = false;
        }


        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text == "Đã nhận được hàng")
                btnComplete.Visible = true;
            else
                btnComplete.Visible = false;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            btnAccept.Text = "Đã nhận đơn";
            btnAccept.Checked = false; 
            btnAccept.Enabled = false;
        }

        
    }
}
