using GUI.US_;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace GUI
{
    public partial class FormKhachHang : Form
    {
        bool accountStatus;
        Guna2GradientTileButton[] btnArray;
        UserControl[] controlArray;

        public FormKhachHang(bool Status)
        {
            
            InitializeComponent();
            // Kiểm tra giá trị của Status trước khi gán cho accountStatus
            if (Status)
            {
                accountStatus = Status;
                if (accountStatus)
                {
                    MessageBox.Show(accountStatus + "");
                }else
                    MessageBox.Show(accountStatus + "");
            }
        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            if (accountStatus)
            {
                btnInfo.Text = Management.GetNameCustomerAccount();
            }
            else
            {
                btnInfo.Visible = false;
                btnCart.Visible = false;
            }
            btnMedicines.PerformClick();

        }

        #region Các Function

        void UCManagement(UserControl uC)
        {
            controlArray = new UserControl[] { uC_KH_Thuoc1, uC_KH_Cart1, uC_Info_Customer1 };
            Management.UCArrayVisible(controlArray, uC);
        }
        void BtnTasbalClickManagement(Guna2GradientTileButton btn)
        {
            btnLogOut.Visible = false;
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
            Application.Exit();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            UCManagement(uC_Info_Customer1);
            btnLogOut.Visible = true;
        }



        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Management.LogOut(this);
        }
    }
}
