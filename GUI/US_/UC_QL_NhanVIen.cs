using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_QL_NhanVIen : UserControl
    {
        public readonly EmployeesBusinessLogic _EmployeesBusinesLogiccs = new EmployeesBusinessLogic();
        public readonly AccountBusinesLogiccs _AccountBusinesLogiccs = new AccountBusinesLogiccs();

        Label[] _laberError;
        bool _trangThai;
        public UC_QL_NhanVIen()
        {
            InitializeComponent();
            _laberError = new Label[] { errorNameAccount, errorPassword, errorName, errorDateOfBirth, errorSex, errorEmail, errorCCCD, errorStartDay, errorAddress };
            _trangThai = false;
            Management.ErrorHide(_laberError);
        }

        private void UC_QL_NhanVIen_Load(object sender, EventArgs e)
        {
            List<Employees> obj = _EmployeesBusinesLogiccs.GetAllObject();
            Management.AddItemsUC(flowLayoutPanelEmployee, obj);
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

        //
        public void LoadInfoOfIteam()
        {
            Employees obj = _EmployeesBusinesLogiccs.GetObjectById(Management.GetIDEmployess());
            Account account = _AccountBusinesLogiccs.GetObjectById(Management.GetIDEmployess());
            txtNameAccount.Text = account.AccountName;
            txtPassword.Text = account.Password;
            txtName.Text = obj.Name;
            if (obj.Sex == "Nam" || obj.Sex == "nam")
                radioButtonMale.Checked = true;
            else
                radioButtonMale.Checked = false;
            txtDateOfBirth.Value = obj.DateOfBirth;
            txtEmail.Text = obj.Email;
            txtCCCD.Text = obj.CCCD;
            txtStartedDay.Value = obj.StartedDay;
            txtAddress.Text = obj.Address;

            try
            {
                PicAnh.Image = System.Drawing.Image.FromFile(obj.Image);
            }
            catch (Exception)
            {
                PicAnh.Image = null;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadInfoOfIteam();
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


        
    }
}
