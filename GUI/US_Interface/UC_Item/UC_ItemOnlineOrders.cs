using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC_ItemOnlineOrders : UserControl
    {

        /*
         * Đang chờ xác nhận
         * Đang chuẩn bị hàng
        Đang chờ vận chuyển nhận hàng
        Đang giao hàng
        Đã nhận được hàng
        Hoàn trả
        Hủy đơn 
        Không nhận hàng
        */

        List<string> statust = new List<string>() { "Đang chờ xác nhận", "Đang chuẩn bị hàng", "Đang chờ vận chuyển nhận hàng", "Đang giao hàng"};
        string[] _dataComboBox;
        public UC_ItemOnlineOrders()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            btnAccept.Text = "Nhận đơn";
            btnComplete.Visible = false;
            LoadDataComboBoxStatust();

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
        private void LoadDataComboBoxStatust()
        {
            _dataComboBox = new string[statust.Count];
            for (int i = 0; i < statust.Count; i++)
            {
                _dataComboBox[i] = statust[i];
            }


            // Gán mảng dữ liệu cho ComboBox
            txtStatus.Items.Clear();
            if (_dataComboBox.Length > 0)
            {
                txtStatus.Items.AddRange(_dataComboBox);
            }

        }


    }
}
