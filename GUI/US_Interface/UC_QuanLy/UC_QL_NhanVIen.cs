using BLL;
using DTO;
using System;
using System.Collections.Generic;
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

        Label[] _laberError;
        string[] _dataComboBox;
        bool _trangThai;
        public UC_QL_NhanVIen()
        {
            InitializeComponent();
            _listObjEmployees = _EmployeesBusinesLogiccs.GetAllObject();
            _listObjAccount = _AccountBusinesLogiccs.GetAllObject();
            _listObjRoles = _RolesBusinesLogiccs.GetAllObject();
            _laberError = new Label[] { errorNameAccount, errorPassword, errorName, errorDateOfBirth, errorSex, errorEmail, errorCCCD, errorStartDay, errorAddress, errorRole };
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
        }

        public async Task RunContinuousFunction()
        {
            int IDProduct = Management.GetIDEmployess();
            while (true)
            {
                if (this.Visible != false)
                {
                    if (Management.GetIDEmployess() != IDProduct)
                    {
                        Console.WriteLine("Đã thay đổi");
                        LoadInfoOfIteam();
                        IDProduct = Management.GetIDProduct();
                    }
                }
                await Task.Delay(100);
            }
        }

        public void LoadInfoOfIteam()
        {
            _objEmployees = _EmployeesBusinesLogiccs.GetObjectById(Management.GetIDEmployess());
            _objAccount = _AccountBusinesLogiccs.GetObjectById(Management.GetIDEmployess());
            txtNameAccount.Text = _objAccount.AccountName;
            txtPassword.Text = _objAccount.Password;
            txtName.Text = _objEmployees.Name;
            if (_objEmployees.Sex == "Nam" || _objEmployees.Sex == "nam")
                radioButtonMale.Checked = true;
            else
                radioButtonMale.Checked = false;
            txtDateOfBirth.Value = _objEmployees.DateOfBirth;
            txtEmail.Text = _objEmployees.Email;
            txtCCCD.Text = _objEmployees.CCCD;
            txtStartedDay.Value = _objEmployees.StartedDay;
            txtAddress.Text = _objEmployees.Address;
            foreach (var item in _listObjRoles)
            {
                if(item.ID == _objAccount.Role)
                {
                    ComboBoxRoleTxt.Text = item.Name;
                    break;
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
        private void LoadDataEmployees()
        {
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
            // check ko để trống
            Management.Check(txtNameAccount,errorNameAccount);
            Management.Check(txtPassword, errorPassword);
            Management.Check(txtName, errorName);
            Management.Check(txtDateOfBirth, errorDateOfBirth);
            Management.Check(txtEmail, errorEmail);
            Management.Check(txtCCCD, errorCCCD);
            Management.Check(txtStartedDay, errorStartDay);
            Management.Check(txtAddress, errorAddress);

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
            if (_trangThai)
            {
                MessageBox.Show("Add thành công");
            }
            else
            {
                MessageBox.Show("Add thất bại");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

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
            /*foreach (var item in _ListObjCategorys)
            {
                if (item.Name == ComboBoxCategoryTxt.Text)
                {
                    _ID_Category = item.ID;
                    Console.WriteLine(_ID_Category + " " + item.Name);
                    break;
                }
            }*/
        }
    }
}
