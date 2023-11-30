using GUI.US_;
using System;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormDangNhap());
            //Application.Run(new FormDangKy());
            //Application.Run(new FormQuanLy());
            //Application.Run(new FormThuKho());
            //Application.Run(new FormKhachHang());
            //Application.Run(new FormNhanVienBanHang());
            Application.Run(new FormDieuKhienChucVu());

            // demo master 1
            // demo master 1
            // demo master 12
        }
    }
}
