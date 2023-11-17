using System;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_KH_Thuoc : UserControl
    {
        public UC_KH_Thuoc()
        {
            InitializeComponent();
        }
        private void UC_KH_Thuoc_Load(object sender, EventArgs e)
        {
            uC_KH_OrderInformation1.Visible = false;
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            uC_KH_OrderInformation1.Visible = true;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }
    }
}
