using Guna.UI2.WinForms;
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
    public partial class FormThuKho : Form
    {
        Guna2GradientTileButton[] btnArray;
        UserControl[] controlArray;

        public FormThuKho()
        {
            InitializeComponent();
        }
        #region Các Function

        void UCManagement(UserControl uC)
        {
            controlArray = new UserControl[] { uC_TK_ThuKho1,uC_TK_NhapKho1, uC_TK_XuatKho1 };
            Management.UCArrayVisible(controlArray, uC);
        }
        void BtnTasbalClickManagement(Guna2GradientTileButton btn)
        {
            btnArray = new Guna2GradientTileButton[] { btnTaskbarStocker, btnTaskbarEnterTtheWarehouse, btnTaskbarDischarge };
            Management.BtnTasbalClick(btnArray, Color.Transparent, btn, Color.DarkGray);
            btn.BringToFront();
        }
        #endregion
        
        private void FormThuKho_Load(object sender, EventArgs e)
        {
            btnTaskbarStocker.PerformClick();
        }

        private void btnTaskbarStocker_Click(object sender, EventArgs e)
        {
            UCManagement(uC_TK_ThuKho1);
            BtnTasbalClickManagement(btnTaskbarStocker);
        }

        private void btnTaskbarEnterTtheWarehouse_Click(object sender, EventArgs e)
        {
            UCManagement(uC_TK_NhapKho1);
            BtnTasbalClickManagement(btnTaskbarEnterTtheWarehouse);
        }

        private void btnTaskbarDischarge_Click(object sender, EventArgs e)
        {
            UCManagement(uC_TK_XuatKho1);
            BtnTasbalClickManagement(btnTaskbarDischarge);
        }
    }
}
