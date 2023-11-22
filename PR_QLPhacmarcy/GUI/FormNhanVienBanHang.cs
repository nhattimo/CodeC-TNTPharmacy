using GUI.US_;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormNhanVienBanHang : Form
    {
        Guna2GradientTileButton[] btnArray;
        UserControl[] controlArray;
       
        public FormNhanVienBanHang()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void FormNhanVienBanHang_Load(object sender, EventArgs e)
        {
            btnTasbalShop.PerformClick();
        }


        /*UCManagement(uC_QL_Thuoc1);
        BtnTasbalClickManagement(btnMedicine);*/

        #region Các Function

        void UCManagement(UserControl uC)
        {
            controlArray = new UserControl[] {uC_NVBH_CuaHang1,uC_NVBH_Order1 };
            Management.UCArrayVisible(controlArray, uC);
        }
        void BtnTasbalClickManagement(Guna2GradientTileButton btn)
        {
            btnArray = new Guna2GradientTileButton[] { btnTasbalShop, btnTasbalOrder, btnTasbalCustomer };
            Management.BtnTasbalClick(btnArray, Color.Transparent, btn, Color.DarkGray);
            btn.BringToFront();

        }

        #endregion

        private void btnTasbalShop_Click(object sender, EventArgs e)
        {
            UCManagement(uC_NVBH_CuaHang1);
            BtnTasbalClickManagement(btnTasbalShop);
        }

        private void btnTasbalOrder_Click(object sender, EventArgs e)
        {
            UCManagement(uC_NVBH_Order1);
            BtnTasbalClickManagement(btnTasbalOrder);
        }
    }
}
