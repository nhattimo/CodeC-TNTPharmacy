using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class FormDangKy : Form
    {
        private readonly UsersBusinessLogic _User = new UsersBusinessLogic();

        public readonly AccountBusinesLogiccs _AccountBusinesLogiccs = new AccountBusinesLogiccs();

        List<Account> _ListObjAcounts;
        List<Users> _ListObjUsere;

        Users _ObjUsere;

        Label[] _laberError;
        bool _trangThai;


        public FormDangKy()
        {
            InitializeComponent();
            _laberError = new Label[] { LabelSaiTK, LabelSaiEmail, LabelSaiEmail, LabelSaiCCCD, LabelSaiHoTen, LabelSaiNgaySinh, LabelSaiSDT, LabelSaiGT , LabelSaiDiaChi };
            Management.ErrorHide(_laberError);
            _ListObjAcounts = _AccountBusinesLogiccs.GetAllObject();

        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            Management.Check(txtNameAccount, LabelSaiTK);
            Management.Check(txtEmail, LabelSaiEmail);
            Management.Check(txtPassword, LabelSaiMK);
            Management.Check(txtCCCD, LabelSaiCCCD);
            Management.Check(txtName, LabelSaiHoTen);
            Management.Check(txtDateOfBirth, LabelSaiNgaySinh);

            Management.Check(radioButtonNam, radioButtonNam, LabelSaiSDT);
            Management.Check(txtAddress, LabelSaiDiaChi);

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

            //
            //
            if (_trangThai)
            {
                foreach (var item in _ListObjAcounts)
                {
                    if (item.AccountName == txtNameAccount.Text)
                    {
                        _trangThai = false;
                        MessageBox.Show("Tài khoản đã được sửa dụng, bạn hãy nhập tên tài khoản khác");
                        break;
                    }
                }
                if (_trangThai)
                {
                    // tạo tài khoản
                    Account account = new Account(txtNameAccount.Text, txtPassword.Text, 5);
                    _AccountBusinesLogiccs.Add(account);

                    _ObjUsere = new Users();

                    _ObjUsere.Name = txtName.Text;                               // Tên 
                    _ObjUsere.Sex = "Nam";                                      // Giới tính
                    _ObjUsere.DateOfBirth = DateTime.Parse(txtDateOfBirth.Text.ToString());  // Ngày sinh
                    _ObjUsere.Phone = txtPhone.Text;                             // SĐT
                    _ObjUsere.Address = txtAddress.Text;                           // Địa chỉ
                    _ObjUsere.Email = txtEmail.Text;                              // Email
                    _ObjUsere.Image = null;
                    MessageBox.Show(_ObjUsere.Image);
                    _ObjUsere.Point = "0";
                    _ObjUsere.IDTK = account.ID;
                    if (radioButtonNam.Checked == true)
                        _ObjUsere.Sex = "Nữ";
                    // 
                    _User.Add(_ObjUsere);
                    MessageBox.Show("Sửa thành công");
                    Management.SetIDCustomer(0);
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.ShowDialog();

        }
    }
}
