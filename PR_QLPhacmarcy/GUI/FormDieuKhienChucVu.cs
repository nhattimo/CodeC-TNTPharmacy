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
            // khi bắt dầu chạy chương trình sẽ kiểm tra tài khoản ở trong máy và tự động đăng nhập nếu chưa đăng xuất
            string filePath = "data";
            // nếu file tồn tại
            if (File.Exists(filePath))
            {
                // nếu mã khác 0 thì tự động đăng nhập (Có nghĩa tài khoản đang tồn taij trên máy)
                if (Management.GetIDAccount() != 0)
                {
                    // kiểm tra ID tài khoản và tự động đăng nhập vào đúng vai trò của tài khoản đó
                    Management.LogginForm(this, Management.GetIDAccount());
                    this.Close();
                }
                else
                    // ngược lại nếu mã == 0 thì tài khoản trên máy đã đăng xuất và ko tự động load vai trò
                    this.Show();
            }
        }


        // btn chọn vào giao diện khách hàng
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FormKhachHang formKhachHang; 
            //nếu tài khoản đang tồn tại trên máy là vai trò khách hàng thì sử dụng đc all chức năng
            if (Management.ISCustomer()) {
                formKhachHang = new FormKhachHang(true);
            }
            else{
                // ngược lại thì khi dùng các chức năng phải bắt buộc đăng nhập
                formKhachHang = new FormKhachHang(false);
            }
            this.Hide();
            formKhachHang.ShowDialog();
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
