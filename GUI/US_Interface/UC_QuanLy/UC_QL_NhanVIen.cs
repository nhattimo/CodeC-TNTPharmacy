using BLL;
using DTO;
using GUI.US_Interface.From_CRUD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_QL_NhanVIen : UserControl
    {
        public readonly EmployeesBusinessLogic _EmployeesBusinesLogiccs = new EmployeesBusinessLogic();
        public readonly AccountBusinesLogiccs _AccountBusinesLogiccs = new AccountBusinesLogiccs();
        public readonly RolesBusinessLogic _RolesBusinesLogiccs = new RolesBusinessLogic();
 

        List<Employees> _listObjEmployees;
        List<Account> _listObjAccount;
        List<Roles> _listObjRoles;
        Employees _objEmployees;
        Account _objAccount;

        int _ID_RoleSearch;
        int _ID_Account;
        int _ID_RoleChoose ;
        Label[] _laberError;
        string[] _dataComboBox;
        bool _trangThai;
        public UC_QL_NhanVIen()
        {
            InitializeComponent();
            _listObjEmployees = _EmployeesBusinesLogiccs.GetAllObject();
            _listObjAccount = _AccountBusinesLogiccs.GetAllObject();
            _listObjRoles = _RolesBusinesLogiccs.GetAllObject();
            _laberError = new Label[] { errorNameAccount, errorPassword, errorName, errorDateOfBirth, errorSex, errorEmail, errorCCCD, errorStartDay, errorAddress, errorRole, errorSalary, errorPhone };
            Management.ErrorHide(_laberError);
            _trangThai = false;
            Management.ErrorHide(_laberError);
            LoadDataComboBoxRoleTxt();
            LoadDataComboBoxRoleChoose();
            LoadDataEmployees();
            ComboBoxRoleChoose.Text = "Tất cả";
        }

        private void UC_QL_NhanVIen_Load(object sender, EventArgs e)
        {
            Management.ScrollBarFlowLayoutPanel(flowLayoutPanelEmployee, VScrollBar);
            RunContinuousFunction();
        }

        public async Task RunContinuousFunction()
        {
            int IDEmployess = Management.GetIDEmployess();
            while (true)
            {
                if (this.Visible)
                {
                    if (Management.GetIDEmployess() != IDEmployess)
                    {
                        LoadInfoOfIteam();
                        IDEmployess = Management.GetIDEmployess();
                    }
                }
                await Task.Delay(100);
            }
        }

        public void LoadInfoOfIteam()
        {

            _objEmployees = _EmployeesBusinesLogiccs.GetObjectById(Management.GetIDEmployess());
            _objAccount = _AccountBusinesLogiccs.GetObjectById(_objEmployees.IDTK);
            txtNameAccount.Text = _objAccount.AccountName;
            txtPassword.Text = _objAccount.Password;
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

            try
            {
                PicAnh.Image = Image.FromFile(_objEmployees.Image);
            }
            catch (Exception)
            {
                PicAnh.Image = null;
            }


            foreach (var item in _listObjRoles)
            {
                if(item.ID == _objAccount.Role)
                {
                    ComboBoxRoleTxt.Text = item.Name;
                    break;
                }
            }
            _ID_Account = _objEmployees.IDTK;
            foreach (var item in _listObjAccount)
            {
                if (item.ID == _ID_Account) {
                    _ID_RoleChoose = item.Role;
                }
            }

            
        }
        
        private void LoadDataEmployees()
        {
            _listObjEmployees = _EmployeesBusinesLogiccs.GetAllObject();
            _listObjAccount = _AccountBusinesLogiccs.GetAllObject();
            flowLayoutPanelEmployee.Controls.Clear();
            // Load tất cả 
            if (ComboBoxRoleChoose.Text == "Tất cả")
            {
                // Hiển thị danh nhân viên trên giao diện
                Management.AddItemsUC(flowLayoutPanelEmployee, _listObjEmployees);
            } // load theo _ID_RoleSearch
            else
            {
                List<int> listIDAccount = new List<int>();
                foreach (var item in _listObjAccount)
                {
                    if( item.Role == _ID_RoleSearch)
                    {
                        listIDAccount.Add(item.ID);
                    }
                }

                List<Employees> listIteamEmployees = new List<Employees>();
                foreach (var item in _listObjEmployees)
                {
                    foreach (var itemID in listIDAccount)
                    {
                        if (item.IDTK == itemID)
                        {
                            listIteamEmployees.Add(item);
                            break;
                        }
                    }
                }
                
                Management.AddItemsUC(flowLayoutPanelEmployee, listIteamEmployees);
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

        private void LoadDataComboBoxRoleChoose()
        {
            _dataComboBox = new string[_listObjRoles.Count];
            for (int i = 0; i < _listObjRoles.Count; i++)
            {
                _dataComboBox[i] = _listObjRoles[i].Name;
            }


            // Gán mảng dữ liệu cho ComboBox
            ComboBoxRoleChoose.Items.Clear();
            ComboBoxRoleChoose.Items.Add("Tất cả");
            if (_dataComboBox.Length > 0)
            {
                ComboBoxRoleChoose.Items.AddRange(_dataComboBox);
            }
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_QL_NhanVien_CRUD form_QL_NhanVien_CRUD = new Form_QL_NhanVien_CRUD();
            form_QL_NhanVien_CRUD.ShowDialog();           
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_objEmployees == null)
            {
                MessageBox.Show("hãy chọn nhân viên muốn sửa");
            }
            else
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
                if (_trangThai)
                {
                    _objEmployees = _EmployeesBusinesLogiccs.GetObjectById(Management.GetIDEmployess());
                    if (_objEmployees == null)
                    {
                        MessageBox.Show("nhân viên không tồn tại");
                    }
                    else
                    {
                        _objEmployees.Name = txtName.Text;                               // Tên 
                        _objEmployees.Sex = "Nam";                                      // Giới tính
                        _objEmployees.DateOfBirth = DateTime.Parse(txtDateOfBirth.Text.ToString());  // Ngày sinh
                        _objEmployees.Phone = txtPhone.Text;                             // SĐT
                        _objEmployees.Address = txtAddress.Text;                           // Địa chỉ
                        _objEmployees.Email = txtEmail.Text;                              // Email
                        _objEmployees.Image = Management.SaveImage(PicAnh, txtPhone.Text);
                        _objEmployees.Salary = float.Parse(txtSalary.Text);                             // Lương
                        _objEmployees.StartedDay = DateTime.Parse(txtStartedDay.Text.ToString());// Ngày vào làm
                        _objEmployees.CCCD = txtCCCD.Text;                              // Căn cước công dân   
                        if (radioButtonFemale.Checked == true)
                            _objEmployees.Sex = "Nữ";
                        // 
                        _EmployeesBusinesLogiccs.Update(_objEmployees.ID, _objEmployees);
                        MessageBox.Show(_objEmployees.ID + "");
                        MessageBox.Show("Sửa thành công");
                        LoadDataEmployees();
                    }

                }
                else
                {
                    MessageBox.Show("Kiểm tra lại thông tin");
                }
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(_objEmployees == null)
                {
                    MessageBox.Show("hãy chọn nhân viên muốn xóa");
                }
                else
                {
                    _EmployeesBusinesLogiccs.Delete(_objEmployees.ID);
                    _AccountBusinesLogiccs.Delete(_objEmployees.IDTK);
                    LoadDataEmployees();

                    MessageBox.Show("Xóa thành công");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mã đã không tồn tại");
            }
            
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn nút Tìm kiếm
            if (string.IsNullOrEmpty(txtSearch.Text) != true)
            {
                List<Employees> _iteamListObjProducts = FindProductsByKey(txtSearch.Text);
                Management.AddItemsUC(flowLayoutPanelEmployee, _iteamListObjProducts);
            }
            else
            {
                LoadDataEmployees();
            }
        }


        // txt
        private void txtNameAccount_Leave(object sender, EventArgs e)
        {
            Management.Check(txtNameAccount, errorNameAccount);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Management.Check(txtPassword, errorPassword);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            Management.Check(txtName, errorName);
        }

        private void txtDateOfBirth_Leave(object sender, EventArgs e)
        {
            Management.Check(txtDateOfBirth, errorDateOfBirth);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Management.Check(txtEmail, errorEmail);
        }

        private void txtCCCD_Leave(object sender, EventArgs e)
        {
            Management.Check(txtCCCD, errorCCCD);
        }

        private void txtStartedDay_Leave(object sender, EventArgs e)
        {
            Management.Check(txtStartedDay, errorStartDay);
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            Management.Check(txtAddress, errorAddress);
        }

        private void ComboBoxRoleTxt_Leave(object sender, EventArgs e)
        {
            Management.Check(ComboBoxRoleTxt, errorRole);
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            Management.Check(txtSalary, errorSalary);
        }

        private void ComboBoxRoleChoose_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (var item in _listObjRoles)
            {
                if (item.Name == ComboBoxRoleChoose.Text)
                {
                    _ID_RoleSearch = item.ID;
                    Console.WriteLine(_ID_RoleSearch);
                    break;
                }
            }
            LoadDataEmployees();
        }

        private void ComboBoxRoleTxt_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (var item in _listObjRoles)
            {
                if (item.Name == ComboBoxRoleTxt.Text)
                {
                    _ID_RoleChoose = item.ID;
                    break;
                }
            }
        }

        private List<Employees> FindProductsByKey(string key)
        {
            List<Employees> foundEmployees = new List<Employees>();

            if (ComboBoxRoleChoose.Text == "Tất cả")
            {

                foreach (var item in _listObjEmployees)
                {
                    // Kiểm tra xem tên sản phẩm có chứa từ khóa hay không (không phân biệt chữ hoa/chữ thường)
                    if (item.Name.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        foundEmployees.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in _listObjEmployees)
                {
                    // Kiểm tra xem tên sản phẩm có chứa từ khóa hay không (không phân biệt chữ hoa/chữ thường)
                    if (item.Name.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Account account = _AccountBusinesLogiccs.GetObjectById(item.IDTK);
                        if (account.Role == _ID_RoleSearch)
                            foundEmployees.Add(item);
                    }
                }
            }
            return foundEmployees;
        }

        private void PicAnh_Click_1(object sender, EventArgs e)
        {
            Management.SetImage(PicAnh, sender);
        }
    }
}
