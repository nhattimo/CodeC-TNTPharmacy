using Guna.UI2.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_KH_Cart : UserControl
    {
        public UC_KH_Cart()
        {
            InitializeComponent();
        }

        private void UC_KH_Cart_Load(object sender, EventArgs e)
        {
            PanelScrollHelper panelScrollHelper  = new PanelScrollHelper(flowLayoutPanel, VScrollBar);
            uC_KH_OrderInformation1.Visible = false;
        }

        private void btnShoppingOnline_Click(object sender, EventArgs e)
        {
            uC_KH_OrderInformation1.Visible = true;
        }

        
    }
}
