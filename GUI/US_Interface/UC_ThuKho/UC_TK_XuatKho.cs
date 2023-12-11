using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.US_
{
    public partial class UC_TK_XuatKho : UserControl
    {

        private readonly ProductBusinessLogic _Product = new ProductBusinessLogic();
        private readonly WareHousingBusinessLogic _WareHousing = new WareHousingBusinessLogic();
        private readonly WareHousingDetailsBusinessLogic _WareHousingDetails = new WareHousingDetailsBusinessLogic();

        List<Products> _ListObjProduct;
        List<WareHousing> _ListObjWareHousing;
        List<WareHousingDetails> _ListObjWareHousingDetails;

        Products _ObjProduct;
        WareHousing _ObjWareHousing;
        WareHousingDetails _ObjWareHousingDetails;

        Label[] _laberError;
        bool _trangThai;

        int idNhapKHo;
        string namesp;

        public UC_TK_XuatKho()
        {
            InitializeComponent();
            _laberError = new Label[] { errorCost, errorDescribe, errorIDProduct };
            Management.ErrorHide(_laberError);
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _ObjProduct = _Product.GetObjectById(int.Parse(txtIDProduct.Text));
            _ObjWareHousingDetails = _WareHousingDetails.GetObjectById(idNhapKHo);

            if (string.IsNullOrEmpty(txtIDProduct.Text) || _ObjWareHousingDetails == null)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu");
            }
            else
            {
                if (_ObjProduct.Name == namesp)
                {
                    if (int.Parse(txtQuantity.Value.ToString()) > _ObjWareHousingDetails.Quantity)
                    {
                        MessageBox.Show("Số lượng vượt quá mức cho phép");
                    }
                    else
                    {
                        _ObjProduct.Quantity += int.Parse(txtQuantity.Value.ToString());
                        _ObjProduct.Price = float.Parse(txtCost.Text);

                        _ObjWareHousingDetails.Quantity -= int.Parse(txtQuantity.Value.ToString());

                        MessageBox.Show("Xuất kho thành công");
                        _Product.Update(_ObjProduct.ID, _ObjProduct);
                        _WareHousingDetails.Update(_ObjWareHousingDetails.ID, _ObjWareHousingDetails);
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đúng sản phẩm ở kho cùng với sản phẩm muốn xuất");
                }
            }
  
        }
        private void LoadData()
        {
            _ListObjProduct = _Product.GetAllObject();
            _ListObjWareHousing = _WareHousing.GetAllObject();
            _ListObjWareHousingDetails = _WareHousingDetails.GetAllObject();
            guna2DataGridView1.Rows.Clear();
            guna2DataGridView1.ColumnCount = 4;
            guna2DataGridView1.Columns[0].Name = "ID";
            guna2DataGridView1.Columns[1].Name = "Tên sản phẩm";
            guna2DataGridView1.Columns[2].Name = "Số lượng trên sàn";
            guna2DataGridView1.Columns[3].Name = "Đơn giá";
            foreach (var item in _ListObjProduct)
            {
                string[] row = { item.ID + "", item.Name + "", item.Quantity + "", item.Price + "" };
                guna2DataGridView1.Rows.Add(row);
            }

            _ListObjProduct = _Product.GetAllObject();
            guna2DataGridView2.Rows.Clear();
            guna2DataGridView2.ColumnCount = 6;
            guna2DataGridView2.Columns[0].Name = "Ngày nhập";
            guna2DataGridView2.Columns[1].Name = "Số lượng";
            guna2DataGridView2.Columns[2].Name = "Tên sản phẩm";
            guna2DataGridView2.Columns[3].Name = "giá nhập";
            guna2DataGridView2.Columns[4].Name = "Tổng tiền";
            guna2DataGridView2.Columns[5].Name = "ID";

            foreach (var item in _ListObjWareHousing)
            {
                foreach (var item1 in _ListObjWareHousingDetails)
                {
                    if (item.ID == item1.IDWareHousing)
                    {
                        _ObjProduct = _Product.GetObjectById(item1.IDPruduct);
                        string[] row = { item.ImportedDate + "", item1.Quantity + "", _ObjProduct.Name + "", item1.ImportedPrice + ".000 VND", item1.ImportedPrice * item1.Quantity + ".000 VND" ,item1.ID + ""};
                        guna2DataGridView2.Rows.Add(row);
                    }
                }
            }
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                guna2DataGridView2.CurrentRow.Selected = true;
                guna2DataGridView2.ReadOnly = true;
                if (guna2DataGridView2.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    /*btnUpdate.Visible = false;
                    btnDelete.Visible = false;*/
                }
                else
                {

                    idNhapKHo = int.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString());
                    namesp = guna2DataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
            }
            catch (Exception)
            {
                /*btnUpdate.Visible = false;
                btnDelete.Visible = false;*/
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                guna2DataGridView1.CurrentRow.Selected = true;
                guna2DataGridView1.ReadOnly = true;
                if (guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value == null)
                {
                   /* btnUpdate.Visible = false;
                    btnDelete.Visible = false;*/
                }
                else
                {
                    txtIDProduct.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtCost.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
                int sl = 0;
                foreach (var item in _ListObjWareHousingDetails)
                {
                    if (item.IDPruduct == int.Parse(txtIDProduct.Text))
                    {
                        sl += item.Quantity;
                    }
                }
                flowLayoutPanel2.Controls.Clear();
                UserControl7 userControl7 = new UserControl7(int.Parse(txtIDProduct.Text), sl);
                flowLayoutPanel2.Controls.Add(userControl7);
            }
            catch (Exception)
            {
                /*btnUpdate.Visible = false;
                btnDelete.Visible = false;*/
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
