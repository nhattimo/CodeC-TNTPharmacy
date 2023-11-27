using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.ShowDialog();

        }
    }
}
