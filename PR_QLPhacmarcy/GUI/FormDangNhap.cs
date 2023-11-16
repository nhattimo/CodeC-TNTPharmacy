using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
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
    }
}
