using System;
using System.IO;
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
            string filePath = "data";

            // nếu file tồn tại
            if (File.Exists(filePath))
            {
                // nếu mã khác 0 thì tự động đăng nhập
                if (Management.GetIDAccount() != 0)
                {
                    Management.LogginForm(this, Management.GetIDAccount());
                    this.Close();
                }
                else
                    this.Show();
            }
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

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
