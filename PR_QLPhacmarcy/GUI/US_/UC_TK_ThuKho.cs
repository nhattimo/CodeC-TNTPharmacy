using System;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_TK_ThuKho : UserControl
    {
        public UC_TK_ThuKho()
        {
            InitializeComponent();
        }

        private void UC_TK_ThuKho_Load(object sender, EventArgs e)
        {

            UserControl6[] control = { new UserControl6(18, "Hế lô ae"), new UserControl6(18, "Hế lô ae"), new UserControl6(18, "Hế lô ae") }; ;
            Management.AddItemsUC(flowLayoutPanelItem, control);
            
        }
    }
}
