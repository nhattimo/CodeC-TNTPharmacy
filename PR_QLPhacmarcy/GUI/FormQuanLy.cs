using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using UserControl = System.Windows.Forms.UserControl;

namespace GUI
{
    public partial class FormQuanLy : Form
    {

        Guna2GradientTileButton[] btnArray;
        UserControl[] controlArray;

        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            btnMedicine.PerformClick();
           
        }



        #region Các Function

        void UCManagement(UserControl uC)
        {
            controlArray = new UserControl[] { uC_QL_Thuoc1, uC_QL_NhanVIen1, uC_QL_KhachHang1, uC_QL_NguonCung1, uC_QL_ThongKe1};
            Management.UCArrayVisible(controlArray, uC);
        }
        void BtnTasbalClickManagement(Guna2GradientTileButton btn)
        {
            btnArray = new Guna2GradientTileButton[] { btnMedicine, btnSalesAgent, btnCustomer, btnSupplier, btnStatistical };
            Management.BtnTasbalClick(btnArray, Color.Transparent, btn, Color.DarkGray);
            btn.BringToFront();

        }

        #endregion



        #region
        // btn dược phẩm
        private void btnMedicine_Click(object sender, EventArgs e)
        {
            UCManagement(uC_QL_Thuoc1);
            BtnTasbalClickManagement(btnMedicine);
        }


        // btn nhân viên bán hàng
        private void btnSalesAgent_Click(object sender, EventArgs e)
        {
            UCManagement(uC_QL_NhanVIen1);
            BtnTasbalClickManagement(btnSalesAgent);
        }

        // btn khách hàng
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            UCManagement(uC_QL_KhachHang1);
            BtnTasbalClickManagement(btnCustomer);
        }

        // btn nguồn cung
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            UCManagement(uC_QL_NguonCung1);
            BtnTasbalClickManagement(btnSupplier);
        }

        // btn thống kê
        private void btnStatistical_Click(object sender, EventArgs e)
        {
            UCManagement(uC_QL_ThongKe1);
            BtnTasbalClickManagement(btnStatistical);
        }
        #endregion

        private void uC_QL_ThongKe1_Load(object sender, EventArgs e)
        {

        }
    }
}
