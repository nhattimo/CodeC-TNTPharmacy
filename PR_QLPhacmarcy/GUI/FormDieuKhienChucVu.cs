using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDieuKhienChucVu : Form
    {
        public FormDieuKhienChucVu()
        {
            InitializeComponent();
        }

        private void FormDieuKhienChucVu_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Management.SetIDAccount(5);
            FormKhachHang formKhachHang = new FormKhachHang();
            formKhachHang.ShowDialog();
            this.Hide();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap(1);
            formDangNhap.ShowDialog();
            this.Hide();
        }
    }
}
