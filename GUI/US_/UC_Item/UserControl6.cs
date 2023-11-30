using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UserControl6 : UserControl
    {
        int InventoryNumber { get; set; }
        string Title { get; set; }
        public UserControl6()
        {
            InitializeComponent();
        }
        public UserControl6(int inventoryNumber, string title)
        {
            InitializeComponent();
            InventoryNumber = inventoryNumber;
            Title = title;
        }
        private void UserControl6_Load(object sender, EventArgs e)
        {
            txtQuantity.Text = InventoryNumber + "";
            txtTitle.Text = Title;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }
    }
}
