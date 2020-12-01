using QuanLiShopHoa.DAO;
using QuanLiShopHoa.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiShopHoa
{
    public partial class formQuanLiKho : Form
    {

        BindingSource ProductList = new BindingSource();
        public formQuanLiKho()
        {
            InitializeComponent();

            dtgvProduct.DataSource = ProductList;

            LoadListProduct();
            ClearBinding();
            AddProductBinding();
        }

        #region method
        void LoadListProduct()
        {
            ProductList.DataSource = ProductDAO.Instance.GetListProduct();
        }

        void AddProductBinding()
        {
            lbSPDangChon.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "maSo", true, DataSourceUpdateMode.Never));
            txbTenSanPham.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "tenSanPham", true, DataSourceUpdateMode.Never));
            txbDonGia.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "donGia", true, DataSourceUpdateMode.Never));
            txbSoLuong.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "soLuong", true, DataSourceUpdateMode.Never));
            txbLoaiSanPham.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "loaiSanPham", true, DataSourceUpdateMode.Never));
            txbMua.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "mua", true, DataSourceUpdateMode.Never));
        }

        void ClearBinding()
        {
            lbSPDangChon.DataBindings.Clear();
            txbTenSanPham.DataBindings.Clear();
            txbDonGia.DataBindings.Clear();
            txbSoLuong.DataBindings.Clear();
            txbLoaiSanPham.DataBindings.Clear();
            txbMua.DataBindings.Clear();
        }

        void AddProduct(string tenSanPham, float donGia, string loaiSanPham, string mua)
        {
            if (ProductDAO.Instance.InsertProduct(tenSanPham, donGia, loaiSanPham, mua))
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại!");
            }
            LoadListProduct();
        }

        void UpdateProduct(int maSo, string tenSanPham, float donGia, string loaiSanPham, string mua)
        {
            if (ProductDAO.Instance.UpdateProduct(maSo, tenSanPham, donGia, loaiSanPham, mua))
            {
                MessageBox.Show("Cập nhật sản phẩm thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật sản phẩm thất bại!");
            }
            LoadListProduct();
        }

        List<Product> SearchProductName(string name)
        {
            List<Product> listProduct = ProductDAO.Instance.SearchProductByName(name);

            return listProduct;
        }        

        #endregion

        #region events
        private void btnNhap_Click(object sender, EventArgs e)
        {
            int maSanPham = Convert.ToInt32(lbSPDangChon.Text);
            int soLuong = (int)numericUpDownNhapXuat.Value;
            string ghiChu = txbGhiChu.Text;

            ProductDAO.Instance.ImportProduct(maSanPham, soLuong, ghiChu);
            MessageBox.Show("Nhập hàng thành công!");

            LoadListProduct();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            int maSanPham = Convert.ToInt32(lbSPDangChon.Text);
            int soLuong = (int)numericUpDownNhapXuat.Value;
            string ghiChu = txbGhiChu.Text;

            if (ProductDAO.Instance.ExportProduct(maSanPham, soLuong, ghiChu))
            {
                MessageBox.Show("Xuất hàng thành công!");
                LoadListProduct();
            }
            else
            {
                MessageBox.Show("Không được xuất số lượng hàng lớn hơn số lượng sản phẩm!");
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            string tenSanPham = txbTenSanPham.Text;
            float donGia = Convert.ToInt32(txbDonGia.Text);
            string loaiSanPham = txbLoaiSanPham.Text;
            string mua = txbMua.Text;
            try
            {
                AddProduct(tenSanPham, donGia, loaiSanPham, mua);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại");
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            int maSo = Convert.ToInt32(lbSPDangChon.Text);
            string tenSanPham = txbTenSanPham.Text;
            float donGia = Convert.ToInt32(txbDonGia.Text);
            string loaiSanPham = txbLoaiSanPham.Text;
            string mua = txbMua.Text;
            try
            {
                UpdateProduct(maSo, tenSanPham, donGia, loaiSanPham, mua);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra");
            }

        }

        private void iconTimSanPham_Click(object sender, EventArgs e)
        {
            dtgvProduct.DataSource = SearchProductName(txbTimSanPham.Text);
            ClearBinding();
            AddProductBinding();
        }

        private void txbTimSanPham_TextChanged(object sender, EventArgs e)
        {
            if (txbTimSanPham.Text == "")
            {
                LoadListProduct();
                ClearBinding();
                AddProductBinding();
            }
            else
            {
                dtgvProduct.DataSource = SearchProductName(txbTimSanPham.Text);
                ClearBinding();
                AddProductBinding();
            }
        }

        private void txbTimSanPham_DoubleClick(object sender, EventArgs e)
        {
            txbTimSanPham.Clear();
        }

        #endregion

        #region design
        private void btnThemSP_MouseHover(object sender, EventArgs e)
        {
            btnThemSP.Image = Properties.Resources.buttonThemNV;
        }

        private void btnThemSP_MouseLeave(object sender, EventArgs e)
        {
            btnThemSP.Image = Properties.Resources.buttonThemNVhover;
        }

        private void btnSuaSP_MouseHover(object sender, EventArgs e)
        {
            btnSuaSP.Image = Properties.Resources.buttonSuaNV;
        }

        private void btnSuaSP_MouseLeave(object sender, EventArgs e)
        {
            btnSuaSP.Image = Properties.Resources.buttonSuaNVhover;
        }

        private void btnXoaSP_MouseHover(object sender, EventArgs e)
        {
            btnXoaSP.Image = Properties.Resources.buttonXoaNV;
        }

        private void btnXoaSP_MouseLeave(object sender, EventArgs e)
        {
            btnXoaSP.Image = Properties.Resources.buttonXoaNVhover;
        }

        private void btnTTNX_MouseHover(object sender, EventArgs e)
        {
            btnTTNX.Image = Properties.Resources.buttonThongTinNhapXuathover;
        }

        private void btnTTNX_MouseLeave(object sender, EventArgs e)
        {
            btnTTNX.Image = Properties.Resources.buttonThongTinNhapXuat;
        }

        private void btnNhap_MouseHover(object sender, EventArgs e)
        {
            btnNhap.Image = Properties.Resources.buttonNhaphover;
        }

        private void btnNhap_MouseLeave(object sender, EventArgs e)
        {
            btnNhap.Image = Properties.Resources.buttonNhap;
        }

        private void btnXuat_MouseHover(object sender, EventArgs e)
        {
            btnXuat.Image = Properties.Resources.buttonXuathover;
        }

        private void btnXuat_MouseLeave(object sender, EventArgs e)
        {
            btnXuat.Image = Properties.Resources.buttonXuat;
        }

        private void txbTenSanPham_DoubleClick(object sender, EventArgs e)
        {
            txbTenSanPham.Clear();
        }

        private void txbDonGia_DoubleClick(object sender, EventArgs e)
        {
            txbDonGia.Clear();
        }

        private void txbSoLuong_DoubleClick(object sender, EventArgs e)
        {
            txbSoLuong.Clear();
        }

        private void txbLoaiSanPham_DoubleClick(object sender, EventArgs e)
        {
            txbLoaiSanPham.Clear();
        }

        private void txbMua_DoubleClick(object sender, EventArgs e)
        {
            txbMua.Clear();
        }

        #endregion

        private void btnTTNX_Click(object sender, EventArgs e)
        {
            formThongTinNhapXuat f = new formThongTinNhapXuat();
            f.ShowDialog();
        }
    }
}
