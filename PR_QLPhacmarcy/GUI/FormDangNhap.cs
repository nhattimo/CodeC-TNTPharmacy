using BLL;
using GUI.US_;
using System;
using System.Windows.Forms;


namespace GUI
{
    public partial class FormDangNhap : Form
    {
        private readonly EmployeesBusinessLogic _Employees;
        private readonly UsersBusinessLogic _Users;
        private readonly AccountBusinesLogiccs _Account;

        Label[] _laberError;
        bool _trangThai = false;
        int _luaChon;
        public FormDangNhap()
        {
        }

        public FormDangNhap(int CV)
        {
            InitializeComponent();
            _Employees = new EmployeesBusinessLogic();
            _Users = new UsersBusinessLogic();
            _Account = new AccountBusinesLogiccs();
            _luaChon = CV;
            // Add những txt lỗi vào mảng và dùng hàm ẩn đi
            _laberError = new Label[] { errorAccount, errorPassword, errorLoginFailed };
            Management.ErrorHide(_laberError);
        }

        // BTN
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // kiểm tra null của từng TXT
            if(Management.ISNull(txtTenTaiKhoan) && Management.ISNull(txtMatKhau)){
                Management.Errorshow(errorAccount, "Không để trống");
                Management.Errorshow(errorPassword, "Không để trống");
                _trangThai = false;
            }
            else if (Management.ISNull(txtTenTaiKhoan))
            {
                Management.Errorshow(errorAccount, "Không để trống");
                _trangThai = false;
            }
            else if (Management.ISNull(txtMatKhau))
            {
                Management.Errorshow(errorPassword, "Không để trống");
                _trangThai = false;
            }
            else
            {
                _trangThai = true;
                Management.ErrorHide(errorAccount);
                Management.ErrorHide(errorPassword);
            }

            if (_trangThai == true)
            {
                if (_luaChon == 0)
                {
                    // kiểm tra tài khoản và mk người dùng
                }
                else
                {
                    // kiểm tra tài khoản và mk nhân viên
                    if (_Account.Exists(txtTenTaiKhoan.Text)) // kiểm tra tên tài khoản
                    {
                        if (_Account.IsLoggin(txtTenTaiKhoan.Text, txtMatKhau.Text)) // kiểm tra tên tài khoản và mật khẩu
                        {
                            LogginForm(txtTenTaiKhoan.Text);
                        }
                        else
                            Management.Errorshow(errorPassword, "Mật khẩu không đúng");
                    }
                    else
                        Management.Errorshow(errorAccount, "Tài khoản không tồn tại");
                }
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
            if (Management.ISNull(txtTenTaiKhoan))
            {
                Management.Errorshow(errorAccount, "Không để trống");
            }
            else
                Management.ErrorHide(errorAccount);
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (Management.ISNull(txtMatKhau))
            {
                Management.Errorshow(errorPassword, "Không để trống");
            }
            else
                Management.ErrorHide(errorPassword);
        }

        private void LogginForm (string accountName){
            int IDTK = _Account.GetID(accountName); // Lấy ID Tài khoản người dùng
            switch (_Account.GetRole(accountName)) // Lấy ID Role
            {
                // Quản Lý
                case 1:
                    Management.SetIDAccount(IDTK);
                    FormQuanLy formQuanLy = new FormQuanLy();
                    formQuanLy.ShowDialog();
                    this.Hide();
                    break;

                // Nhân Viên Bán Hàng
                case 2:
                    Management.SetIDAccount(IDTK);
                    FormNhanVienBanHang formNhanVienBanHang = new FormNhanVienBanHang();
                    formNhanVienBanHang.ShowDialog();
                    this.Hide();
                    break;

                // Nhân Viên Thủ Kho
                case 3:
                    Management.SetIDAccount(IDTK);
                    FormThuKho formThuKho = new FormThuKho();
                    formThuKho.ShowDialog();
                    this.Hide();
                    break;
                // Nhân Viên Kế Toán

                case 4:
                    Management.SetIDAccount(IDTK);
                    break;

                // Khách hàng
                case 5:
                    Management.SetIDAccount(IDTK);
                    FormKhachHang formKhachHang = new FormKhachHang();
                    formKhachHang.ShowDialog();
                    this.Hide();
                    break;

                default:
                        
                    break;
            }
        }

        private void guna2Button1_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.PasswordChar = '\0';
        }

        private void guna2Button1_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }
    }
}
