using System;
using System.Web.UI;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_KH_Thuoc : System.Windows.Forms.UserControl
    {
        public UC_KH_Thuoc()
        {
            InitializeComponent();
        }
        private void UC_KH_Thuoc_Load(object sender, EventArgs e)
        {
            //Management.AddItemsUC(flowLayoutPanelItemProducts, UCItemProduct);
            uC_KH_OrderInformation1.Visible = false;
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            if (Management.ISCustomer())
            {
                uC_KH_OrderInformation1.Visible = true;
            }else
            {
                FormLuaChonCuaKhachHang formLuaChonCuaKhachHang = new FormLuaChonCuaKhachHang();
                formLuaChonCuaKhachHang.Show();
                formLuaChonCuaKhachHang.SendToBack();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }
        
    }
}
