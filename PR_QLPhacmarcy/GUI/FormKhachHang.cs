using GUI.US_;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormKhachHang : Form
    {
        int _IDTK;
        Guna2GradientTileButton[] btnArray;
        UserControl[] controlArray;

        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            btnMedicines.PerformClick();
        }

        #region Các Function

        void UCManagement(UserControl uC)
        {
            controlArray = new UserControl[] { uC_KH_Thuoc1,uC_KH_Cart1 };
            Management.UCArrayVisible(controlArray, uC);
        }
        void BtnTasbalClickManagement(Guna2GradientTileButton btn)
        {
            btnArray = new Guna2GradientTileButton[] { btnMedicines, btnCart };
            Management.BtnTasbalClick(btnArray, Color.Transparent, btn, Color.DarkGray);
            btn.BringToFront();

        }

        #endregion

        // btn Tasbal
        private void btnMedicines_Click(object sender, EventArgs e)
        {
            UCManagement(uC_KH_Thuoc1);
            BtnTasbalClickManagement(btnMedicines);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            UCManagement(uC_KH_Cart1);
            BtnTasbalClickManagement(btnCart);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Management.SetIDAccount(0);
            Application.Exit();
        }
    }
}
