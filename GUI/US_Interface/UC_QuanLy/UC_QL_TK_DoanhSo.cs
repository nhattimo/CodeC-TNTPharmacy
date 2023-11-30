using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_QL_TK_DoanhSo : UserControl
    {
        Guna2GradientButton[] btnArray;
        public UC_QL_TK_DoanhSo()
        {
            InitializeComponent();
        }

        private void UC_QL_TK_DoanhSo_Load(object sender, EventArgs e)
        {

        }

        #region Các Function

        void BtnTasbalClickManagement(Guna2GradientButton btn)
        {
            btnArray = new Guna2GradientButton[] { btnHighSales, btnLowSales }; //  btn bán chạy, btn doanh thu, btn doanh số
            Management.BtnTasbalClick(btnArray, Color.Transparent, btn, Color.DarkGray);
            btn.BringToFront();
        }

        #endregion
        private void btnHighSales_Click(object sender, EventArgs e)
        {
            BtnTasbalClickManagement(btnHighSales);
            MessageBox.Show("xuất theo doanh số từ cao về thấp");

            // việc cần làm : xuất theo doanh số từ cao về thấp
        }

        private void btnLowSales_Click(object sender, EventArgs e)
        {
            BtnTasbalClickManagement(btnLowSales);
            MessageBox.Show("xuất theo doanh số từ thấp lên cao");

            // việc cần làm : xuất theo doanh số từ thấp lên cao
        }
    }
}
