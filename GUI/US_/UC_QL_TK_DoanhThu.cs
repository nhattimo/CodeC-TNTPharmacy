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
    public partial class UC_QL_TK_DoanhThu : UserControl
    {
        Guna2GradientButton[] btnArray;
        public UC_QL_TK_DoanhThu()
        {
            InitializeComponent();
        }

        private void UC_QL_TK_DoanhThu_Load(object sender, EventArgs e)
        {

        }

        #region Các Function

        void BtnTasbalClickManagement(Guna2GradientButton btn)
        {
            btnArray = new Guna2GradientButton[] { btnHighRevenue, btnLowRevenue}; //  btn bán chạy, btn doanh thu, btn doanh số
            Management.BtnTasbalClick(btnArray, Color.Transparent, btn, Color.DarkGray);
            btn.BringToFront();
        }

        #endregion

        // btn doanh thu cao
        private void btnHighRevenue_Click(object sender, EventArgs e)
        {
            BtnTasbalClickManagement(btnHighRevenue);
            MessageBox.Show("xuất theo doanh thu từ cao về thấp");


            // việc cần làm : xuất theo doanh thu từ cao về thấp
        }

        // btn doanh thu thấp
        private void btnLowRevenue_Click(object sender, EventArgs e)
        {
            BtnTasbalClickManagement(btnLowRevenue);
            MessageBox.Show("xuất theo doanh thu từ thấp lên cao");
            // việc cần làm : xuất theo doanh thu từ thấp lên cao
        }
    }
}
