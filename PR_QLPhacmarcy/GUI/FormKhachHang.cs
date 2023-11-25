using GUI.US_;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class FormKhachHang : Form
    {
        private static UC_QL_Thuoc _instance;
        private static readonly object _lock = new object();

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
            controlArray = new UserControl[] { uC_KH_Thuoc1,uC_KH_Cart1 };
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
            btnLogOut.Visible = true;
            //UCManagement(uC_Info_Customer1);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Management.LogOut(this);
        }

        public static UC_QL_Thuoc Instance
        {
            get
            {
                // Kiểm tra xem thể hiện đã được tạo chưa
                if (_instance == null)
                {
                    // Sử dụng khóa để đảm bảo chỉ có một luồng có thể tạo thể hiện
                    lock (_lock)
                    {
                        // Kiểm tra lại sau khi có khóa để đảm bảo không tạo thêm thể hiện
                        if (_instance == null)
                        {
                            _instance = new UC_QL_Thuoc();
                        }
                    }
                }
                return _instance;
            }
        }


    }
}
