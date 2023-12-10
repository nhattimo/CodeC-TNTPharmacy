using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI.US_Interface.From_CRUD
{
    public partial class Form_QL_NhanVien_CRUD : Form
    {

        public readonly EmployeesBusinessLogic _EmployeesBusinesLogiccs = new EmployeesBusinessLogic();
        public readonly AccountBusinesLogiccs _AccountBusinesLogiccs = new AccountBusinesLogiccs();
        public readonly RolesBusinessLogic _RolesBusinesLogiccs = new RolesBusinessLogic();

        List<Employees> _listObjEmployees;
        List<Account> _listObjAccount;
        List<Roles> _listObjRoles;
        Employees _objEmployees;
        Account _objAccount;
        Roles _objRoles;

        int _ID_Account;
        int _ID_RoleChoose;
        Label[] _laberError;
        string[] _dataComboBox;
        bool _trangThai;
        public Form_QL_NhanVien_CRUD()
        {
            
            InitializeComponent();
            _listObjEmployees = _EmployeesBusinesLogiccs.GetAllObject();
            _listObjAccount = _AccountBusinesLogiccs.GetAllObject();
            _listObjRoles = _RolesBusinesLogiccs.GetAllObject();

            if (Management.GetIDEmployess() > 0)
            {
                if(_objEmployees != null)
                {
                    _objEmployees = _EmployeesBusinesLogiccs.GetObjectById(Management.GetIDEmployess());
                    _objAccount = _AccountBusinesLogiccs.GetObjectById(_objEmployees.IDTK);
                    _objRoles = _RolesBusinesLogiccs.GetObjectById(_objAccount.Role);
                    _ID_RoleChoose = _objRoles.ID;
                }
            }
            _laberError = new Label[] { errorNameAccount, errorPassword, errorName, errorDateOfBirth, errorSex, errorEmail, errorCCCD, errorStartDay, errorAddress, errorRole, errorSalary, errorPhone};
            Management.ErrorHide(_laberError);
            _trangThai = false;

        }
        
        private void Form_QL_NhanVien_CRUD_Load(object sender, EventArgs e)
        {
            LoadDataComboBoxRoleTxt();
            LoadInfoOfIteam();
        }
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            // check ko để trống
            Management.Check(txtNameAccount, errorNameAccount);
            Management.Check(txtPassword, errorPassword);
            Management.Check(txtName, errorName);
            Management.Check(txtDateOfBirth, errorDateOfBirth);
            Management.Check(txtEmail, errorEmail);
            Management.Check(txtCCCD, errorCCCD);
            Management.Check(txtStartedDay, errorStartDay);
            Management.Check(txtAddress, errorAddress);
            Management.Check(ComboBoxRoleTxt, errorRole);
            Management.Check(txtSalary, errorSalary);
            Management.Check(radioButtonMale,radioButtonFemale, errorSex);

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
            // kiểm tra sử lý dữ liệu
            // ...

            // add 
            
            foreach (var item in _listObjAccount)
            {
                if(item.AccountName == txtNameAccount.Text)
                {
                    _trangThai = false;
                    MessageBox.Show("Tài khoản đã tồn tại");
                    break;
                }
            }
            
            if (_trangThai)
            {
                // tạo tài khoản
                Account account = new Account(txtNameAccount.Text, txtPassword.Text, _ID_RoleChoose);
                _AccountBusinesLogiccs.Add(account);

                _objEmployees = new Employees();
                _objEmployees.Name = txtName.Text;                               // Tên 
                _objEmployees.Sex = "Nam";                                      // Giới tính
                _objEmployees.DateOfBirth = DateTime.Parse(txtDateOfBirth.Text.ToString());  // Ngày sinh
                _objEmployees.Phone = txtPhone.Text;                             // SĐT
                _objEmployees.Address = txtAddress.Text;                           // Địa chỉ
                _objEmployees.Email = txtEmail.Text;
                _objEmployees.Image = Management.SaveImage(PicAnh, txtPhone.Text);// Đường dẫn ảnh
                MessageBox.Show(_objEmployees.Image);
                _objEmployees.Salary = float.Parse(txtSalary.Text);                             // Lương
                _objEmployees.StartedDay = DateTime.Parse(txtStartedDay.Text.ToString());// Ngày vào làm
                _objEmployees.CCCD = txtCCCD.Text;                              // Căn cước công dân
                _objEmployees.IDTK = account.ID ;                              // Căn cước công dân
                                                                                // 
                if (radioButtonFemale.Checked == true)
                    _objEmployees.Sex = "Nữ";
                // 
                _EmployeesBusinesLogiccs.Add(_objEmployees);

                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }

        public void LoadInfoOfIteam()
        {

            _objEmployees = _EmployeesBusinesLogiccs.GetObjectById(Management.GetIDEmployess());
            if(_objEmployees != null)
            {
                _objAccount = _AccountBusinesLogiccs.GetObjectById(_objEmployees.IDTK);
                if (_objEmployees != null)
                {
                    txtNameAccount.Text = "";
                    txtPassword.Text = "";
                    txtName.Text = _objEmployees.Name;
                    if (_objEmployees.Sex == "Nam" || _objEmployees.Sex == "nam")
                        radioButtonMale.Checked = true;
                    else
                        radioButtonFemale.Checked = true;
                    txtDateOfBirth.Value = _objEmployees.DateOfBirth;
                    txtPhone.Text = _objEmployees.Phone;
                    txtEmail.Text = _objEmployees.Email;
                    txtCCCD.Text = _objEmployees.CCCD;
                    txtStartedDay.Value = _objEmployees.StartedDay;
                    txtAddress.Text = _objEmployees.Address;
                    txtSalary.Text = _objEmployees.Salary + "";
                    foreach (var item in _listObjRoles)
                    {
                        if (item.ID == _objAccount.Role)
                        {
                            ComboBoxRoleTxt.Text = item.Name;
                            break;
                        }
                    }
                    _ID_Account = _objEmployees.IDTK;
                    foreach (var item in _listObjAccount)
                    {
                        if (item.ID == _ID_Account)
                        {
                            _ID_RoleChoose = item.Role;
                        }
                    }

                    try
                    {
                        PicAnh.Image = System.Drawing.Image.FromFile(_objEmployees.Image);
                    }
                    catch (Exception)
                    {
                        PicAnh.Image = null;
                    }

                }
            }  
        }

        private void LoadDataComboBoxRoleTxt()
        {
            _dataComboBox = new string[_listObjRoles.Count];
            for (int i = 0; i < _listObjRoles.Count; i++)
            {
                _dataComboBox[i] = _listObjRoles[i].Name;
            }


            // Gán mảng dữ liệu cho ComboBox
            ComboBoxRoleTxt.Items.Clear();
            if (_dataComboBox.Length > 0)
            {
                ComboBoxRoleTxt.Items.AddRange(_dataComboBox);
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNameAccount_Leave(object sender, EventArgs e)
        {
            Management.Check(txtNameAccount, errorNameAccount);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Management.Check(txtPassword, errorPassword);
        }

        private void ComboBoxRoleTxt_Leave(object sender, EventArgs e)
        {
            Management.Check(ComboBoxRoleTxt, errorRole);
        }

        private void ComboBoxRoleTxt_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (var item in _listObjRoles)
            {
                if (item.Name == ComboBoxRoleTxt.SelectedItem.ToString())
                {
                    _ID_RoleChoose = item.ID;
                    MessageBox.Show("ID role chọn = " + _ID_RoleChoose);
                    break;
                }
            }
            
        }

        private void PicAnh_Click(object sender, EventArgs e)
        {
            Management.SetImage(PicAnh, sender);
        }
    }
}
