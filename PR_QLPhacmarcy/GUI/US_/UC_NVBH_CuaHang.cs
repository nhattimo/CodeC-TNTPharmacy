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
    public partial class UC_NVBH_CuaHang : UserControl
    {
        public UC_NVBH_CuaHang()
        {
            InitializeComponent();
        }

        private void UC_NVBH_CuaHang_Load(object sender, EventArgs e)
        {
            uC_Bill1.Visible = false;
        }



        // btn thanh toán
        private void btnPay_Click(object sender, EventArgs e)
        {
            uC_Bill1.Visible = true;

        }

        // btn tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
