using BLL;
using DTO;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UserControl7 : UserControl
    {
        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();

        Products _ObjProduct = new Products();
        public UserControl7(int IDProduct,int sl)
        {
            InitializeComponent();
            _ObjProduct = _Product.GetObjectById(IDProduct);
            txtIDProduct.Text = IDProduct.ToString();
            txtNameProduct.Text = _ObjProduct.Name;
            txtQuantity.Text = sl.ToString(); 
            txtTitle.Text = "Số lượng tồn kho";
            // kiểm tra ảnh
            if (File.Exists(_ObjProduct.Image)) // Kiểm tra xem tệp hình ảnh có tồn tại hay không
            {
                try
                {
                    PictureBoxProduct.Image = Image.FromFile(_ObjProduct.Image);
                }
                catch
                {
                    PictureBoxProduct.Image = null;
                }
            }
            else
            {
                // ảnh không tồn tại
                PictureBoxProduct.Image = null;
            }
        }




    }
}
