using BLL;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_QL_Info : UserControl
    {
        private readonly EmployeesBusinessLogic _Employee = new EmployeesBusinessLogic();
        private readonly RolesBusinessLogic _Role = new RolesBusinessLogic();
        public UC_QL_Info()
        {
            InitializeComponent();
        }

        private void UC_QL_Info_Load(object sender, System.EventArgs e)
        {
            Management.LoadInfoEmployee(picAnh, txtName, txtDateOfBirth, txtSex,txtPhone, txtEmail, txtAddress,txtCCCD, txtStartedDay, txtRole);
        } 
    }
}
