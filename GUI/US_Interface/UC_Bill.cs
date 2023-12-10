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
    public partial class UC_Bill : UserControl
    {
        public UC_Bill()
        {
            InitializeComponent();
        }

        private void UC_Bill_Load(object sender, EventArgs e)
        {

        }

        // btn Thanh toán và in bill
        private void btnPaymentAndPrinting_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        // btn hủy
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
