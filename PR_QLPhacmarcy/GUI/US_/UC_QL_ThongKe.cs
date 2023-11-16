using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using UserControl = System.Windows.Forms.UserControl;

namespace GUI.US_
{
    public partial class UC_QL_ThongKe : UserControl
    {
        public UC_QL_ThongKe()
        {
            InitializeComponent();
        }

        Guna2GradientButton[] btnArray;
        UserControl[] controlArray;

        private void UC_QL_ThongKe_Load(object sender, EventArgs e)
        {
            btnSelling.PerformClick();
        }
        


        #region Các Function

        void UCManagement(UserControl uC)
        {
            controlArray = new UserControl[] { uC_QL_TK_BanChay1, uC_QL_TK_DoanhThu1, uC_QL_TK_DoanhSo1 };
            Management.UCArrayVisible(controlArray, uC);
        }
        void BtnTasbalClickManagement(Guna2GradientButton btn)
        {
            btnArray = new Guna2GradientButton[] { btnSelling, btnRevenue, btnSales }; //  btn bán chạy, btn doanh thu, btn doanh số
            Management.BtnTasbalClick(btnArray, Color.Transparent, btn, Color.DarkGray);
            btn.BringToFront();
        }

        #endregion

        // btn bán chạy
        private void btnSelling_Click(object sender, EventArgs e)
        {
            UCManagement(uC_QL_TK_BanChay1);
            BtnTasbalClickManagement(btnSelling);
        }

        // btn doanh thu
        private void btnRevenue_Click(object sender, EventArgs e)
        {
            UCManagement(uC_QL_TK_DoanhThu1);
            BtnTasbalClickManagement(btnRevenue);
        }

        // btn doanh số
        private void btnSales_Click(object sender, EventArgs e)
        {
            UCManagement(uC_QL_TK_DoanhSo1);
            BtnTasbalClickManagement(btnSales);
        }







        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
