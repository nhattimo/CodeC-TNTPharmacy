using System;
using System.Web.UI;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_KH_Thuoc : System.Windows.Forms.UserControl
    {

        UC_ItemProduct[] UCItemProduct = { new UC_ItemProduct(1, 200, 150, "Thuốc trĩ", "ED"),         
                                            new UC_ItemProduct(2, 200, 150, "Thuốc trĩ", "ED"),
                                            new UC_ItemProduct(3, 200, 150, "Thuốc trĩ", "ED"), 
                                            new UC_ItemProduct(4, 200, 150, "Thuốc trĩ", "ED"), 
                                            new UC_ItemProduct(5, 200, 150, "Thuốc trĩ", "ED"), 
                                            new UC_ItemProduct(6, 200, 150, "Thuốc trĩ", "ED"),
                                            new UC_ItemProduct(7, 22200, 150, "Thuốc trĩ", "ED")};
        public UC_KH_Thuoc()
        {
            InitializeComponent();
        }
        private void UC_KH_Thuoc_Load(object sender, EventArgs e)
        {
            Management.AddItemsUC(flowLayoutPanelItemProducts, UCItemProduct);
            uC_KH_OrderInformation1.Visible = false;
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            uC_KH_OrderInformation1.Visible = true;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }
        void a()
        {
            
        }
    }
}
