using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_Info_Employee : UserControl
    {
        public UC_Info_Employee()
        {
            InitializeComponent();
        }

        private void UC_QL_Info_Load(object sender, System.EventArgs e)
        {
            Management.LoadInfoEmployee(picAnh, txtName, txtDateOfBirth, txtSex,txtPhone, txtEmail, txtAddress,txtCCCD, txtStartedDay, txtRole);
        } 
    }
}
