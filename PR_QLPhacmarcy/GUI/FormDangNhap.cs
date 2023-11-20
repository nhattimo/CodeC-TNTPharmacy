using BLL;
using DTO;
using System;
using System.Web.ModelBinding;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDangNhap : Form
    {
        private readonly EmployeesBusinessLogic _Employees;
        private readonly UsersBusinessLogic _Users;
        Label[] _laberError;
        bool _trangThai = false;
        int vaiTro;
        public FormDangNhap(int CV)
        {
            InitializeComponent();
            _Employees = new EmployeesBusinessLogic();
            _Users = new UsersBusinessLogic();

            vaiTro = CV;
            // Add những txt lỗi vào mảng và dùng hàm ẩn đi
            _laberError = new Label[] { errorAccount, errorPassword, errorLoginFailed };
            Management.ErrorHide(_laberError);
        }

        // BTN
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            _trangThai = false;
            foreach (var item in _laberError)
            {
                if (item.Visible == true)
                {
                    _trangThai = false;
                    break;
                }
                else
                    _trangThai = true;
            }
            if (_trangThai == true)
            {
                MessageBox.Show("Đủ điều kiện kiểm tra tài khoản và mật khẩu");
                if (vaiTro == 0)
                {
                    // kiểm tra tài khoản và mk người dùng

                }
                else
                {
                    // kiểm tra tài khoản nhân viên
                }
            }
            else
            {
                MessageBox.Show("chưa đủ điều kiện kiểm tra tài khoản và mật khẩu");
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDieuKhienChucVu formDieuKhienChucVu = new FormDieuKhienChucVu();
            formDieuKhienChucVu.ShowDialog();
            
        }

        private void btnChuaCoTK_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangKy formDangKy = new FormDangKy();   
            formDangKy.ShowDialog();    
        }



        // TXT
        private void txtTenTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (Management.isNull(txtTenTaiKhoan))
            {
                Management.Errorshow(errorAccount, "Không để trống");
            }
            else
                Management.ErrorHide(errorAccount);
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (Management.isNull(txtMatKhau))
            {
                Management.Errorshow(errorPassword, "Không để trống");
            }
            else
                Management.ErrorHide(errorPassword);
        }
    }
}
