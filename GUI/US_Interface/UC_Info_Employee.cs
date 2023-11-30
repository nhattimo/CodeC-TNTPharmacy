using BLL;
using DTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_Info_Employee : UserControl
    {
        private static readonly EmployeesBusinessLogic _Employee = new EmployeesBusinessLogic();
        private static readonly RolesBusinessLogic _Role = new RolesBusinessLogic();
        public UC_Info_Employee()
        {
            InitializeComponent();
        }

        private void UC_QL_Info_Load(object sender, EventArgs e)
        {
            LoadInfoEmployee();
        }

        private int GetIDAccount()
        {
            int a = 0;
            string filePath = "data";

            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        a = br.ReadInt32();
                    }
                }
            }
            return a;
        }
        public bool ISCustomer()
        {
            if (GetIDAccount() == 0 || _Employee.GetObjectById(GetIDAccount()) == null)
                return false;
            return true;
        }
        private void LoadInfoEmployee()
        {
            if (ISCustomer())
            {
                Employees obj = _Employee.GetObjectById(Management.GetIDAccount());
                Roles rl = _Role.GetObjectById(Management.GetIDAccount());
                txtName.Text = obj.Name;
                txtDateOfBirth.Text = obj.DateOfBirth + "";
                txtSex.Text = obj.Sex;
                txtPhone.Text = obj.Phone;
                txtEmail.Text = obj.Email;
                txtAddress.Text = obj.Address;
                txtCCCD.Text = obj.CCCD;
                txtStartedDay.Text = obj.StartedDay + "";
                txtRole.Text = rl.Name;
                // kiểm tra ảnh
                if (File.Exists(obj.Image)) // Kiểm tra xem tệp hình ảnh có tồn tại hay không
                {
                    try
                    {
                        picAnh.Image = Image.FromFile(obj.Image) ;
                    }
                    catch
                    {
                        picAnh.Image = null;
                    }
                }
                else
                {
                    // ảnh không tồn tại
                    picAnh.Image = null;
                }
            }
        }
    }
}
