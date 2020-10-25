using QuanLiShopHoa.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiShopHoa
{
    public partial class formQuanLiNhanVien : Form
    {
        BindingSource AccountList = new BindingSource();
        public formQuanLiNhanVien()
        {
            InitializeComponent();

            dtgvAccount.DataSource = AccountList;

            LoadListAccount();
            AddAccountBinding();

            
        }

        #region design


        //Struct
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 61, 142);
            public static Color color2 = Color.FromArgb(99, 245, 91);
            public static Color color3 = Color.FromArgb(71, 201, 245);
            public static Color color4 = Color.FromArgb(255, 143, 94);
            public static Color color5 = Color.FromArgb(232, 245, 91);

        }
        #endregion


        #region events
        private void txbTenDangNhap_Click(object sender, EventArgs e)
        {
            //textbox
            txbTenDangNhap.ForeColor = RGBColors.color4;

            txbMatKhau.ForeColor = Color.White;
            txbHoTen.ForeColor = Color.White;
            txbSoDienThoai.ForeColor = Color.White;
            txbDiaChi.ForeColor = Color.White;

            //icon
            iconTenDangNhap.IconColor = RGBColors.color4;

            iconMatKhau.IconColor = Color.White;
            iconHoTen.IconColor = Color.White;
            iconSoDienThoai.IconColor = Color.White;
            iconDiaChi.IconColor = Color.White;

            //panel
            panelTenDangNhap.BackColor = RGBColors.color4;

            panelMatKhau.BackColor = Color.White;
            panelHoTen.BackColor = Color.White;
            panelSoDienThoai.BackColor = Color.White;
            panelDiaChi.BackColor = Color.White;
        }

        private void txbMatKhau_Click(object sender, EventArgs e)
        {
            //textbox
            txbMatKhau.ForeColor = RGBColors.color4;

            txbTenDangNhap.ForeColor = Color.White;
            txbHoTen.ForeColor = Color.White;
            txbSoDienThoai.ForeColor = Color.White;
            txbDiaChi.ForeColor = Color.White;

            //icon
            iconMatKhau.IconColor = RGBColors.color4;

            iconTenDangNhap.IconColor = Color.White;
            iconHoTen.IconColor = Color.White;
            iconSoDienThoai.IconColor = Color.White;
            iconDiaChi.IconColor = Color.White;

            //panel
            panelMatKhau.BackColor = RGBColors.color4;

            panelTenDangNhap.BackColor = Color.White;
            panelHoTen.BackColor = Color.White;
            panelSoDienThoai.BackColor = Color.White;
            panelDiaChi.BackColor = Color.White;
        }

        private void txbHoTen_Click(object sender, EventArgs e)
        {
            //textbox
            txbHoTen.ForeColor = RGBColors.color4;

            txbTenDangNhap.ForeColor = Color.White;
            txbMatKhau.ForeColor = Color.White;
            txbSoDienThoai.ForeColor = Color.White;
            txbDiaChi.ForeColor = Color.White;

            //icon
            iconHoTen.IconColor = RGBColors.color4;

            iconTenDangNhap.IconColor = Color.White;
            iconMatKhau.IconColor = Color.White;
            iconSoDienThoai.IconColor = Color.White;
            iconDiaChi.IconColor = Color.White;

            //panel
            panelHoTen.BackColor = RGBColors.color4;

            panelTenDangNhap.BackColor = Color.White;
            panelMatKhau.BackColor = Color.White;
            panelSoDienThoai.BackColor = Color.White;
            panelDiaChi.BackColor = Color.White;
        }

        private void dateTimeNgaySinh_DropDown(object sender, EventArgs e)
        {
            //textbox
            txbTenDangNhap.ForeColor = Color.White;

            txbMatKhau.ForeColor = Color.White;
            txbHoTen.ForeColor = Color.White;
            txbSoDienThoai.ForeColor = Color.White;
            txbDiaChi.ForeColor = Color.White;

            //icon
            iconTenDangNhap.IconColor = Color.White;

            iconMatKhau.IconColor = Color.White;
            iconHoTen.IconColor = Color.White;
            iconSoDienThoai.IconColor = Color.White;
            iconDiaChi.IconColor = Color.White;

            //panel
            panelTenDangNhap.BackColor = Color.White;

            panelMatKhau.BackColor = Color.White;
            panelHoTen.BackColor = Color.White;
            panelSoDienThoai.BackColor = Color.White;
            panelDiaChi.BackColor = Color.White;
        }

        private void txbSoDienThoai_Click(object sender, EventArgs e)
        {
            //textbox
            txbSoDienThoai.ForeColor = RGBColors.color4;

            txbTenDangNhap.ForeColor = Color.White;
            txbMatKhau.ForeColor = Color.White;
            txbHoTen.ForeColor = Color.White;
            txbDiaChi.ForeColor = Color.White;

            //icon
            iconSoDienThoai.IconColor = RGBColors.color4;

            iconTenDangNhap.IconColor = Color.White;
            iconMatKhau.IconColor = Color.White;
            iconHoTen.IconColor = Color.White;
            iconDiaChi.IconColor = Color.White;

            //panel
            panelSoDienThoai.BackColor = RGBColors.color4;

            panelTenDangNhap.BackColor = Color.White;
            panelMatKhau.BackColor = Color.White;
            panelHoTen.BackColor = Color.White;
            panelDiaChi.BackColor = Color.White;
        }

        private void txbDiaChi_Click(object sender, EventArgs e)
        {
            //textbox
            txbDiaChi.ForeColor = RGBColors.color4;

            txbTenDangNhap.ForeColor = Color.White;
            txbMatKhau.ForeColor = Color.White;
            txbHoTen.ForeColor = Color.White;
            txbSoDienThoai.ForeColor = Color.White;

            //icon
            iconDiaChi.IconColor = RGBColors.color4;

            iconTenDangNhap.IconColor = Color.White;
            iconMatKhau.IconColor = Color.White;
            iconHoTen.IconColor = Color.White;
            iconSoDienThoai.IconColor = Color.White;

            //panel
            panelDiaChi.BackColor = RGBColors.color4;

            panelTenDangNhap.BackColor = Color.White;
            panelMatKhau.BackColor = Color.White;
            panelHoTen.BackColor = Color.White;
            panelSoDienThoai.BackColor = Color.White;
        }

        private void txbTenDangNhap_DoubleClick(object sender, EventArgs e)
        {
            txbTenDangNhap.Clear();
        }

        private void txbMatKhau_DoubleClick(object sender, EventArgs e)
        {
            txbMatKhau.Clear();
        }

        private void txbHoTen_DoubleClick(object sender, EventArgs e)
        {
            txbHoTen.Clear();
        }

        private void txbSoDienThoai_DoubleClick(object sender, EventArgs e)
        {
            txbSoDienThoai.Clear();
        }

        private void txbDiaChi_DoubleClick(object sender, EventArgs e)
        {
            txbDiaChi.Clear();
        }
        #endregion

        #region method

        void LoadListAccount()
        {
            AccountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void AddAccountBinding()
        {
            txbTenDangNhap.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "tenDangNhap"));
            txbMatKhau.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "matKhau"));
            txbHoTen.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "hoTen"));
            dateTimeNgaySinh.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "ngaySinh"));
            txbSoDienThoai.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "soDienThoai"));
            txbDiaChi.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "diaChi"));
        }
        #endregion

        private void btnXoaNV_MouseHover(object sender, EventArgs e)
        {
            btnXoaNV.Image = Properties.Resources.buttonXoaNVhover;
        }

        private void btnXoaNV_MouseLeave(object sender, EventArgs e)
        {
            btnXoaNV.Image = Properties.Resources.buttonXoaNV;
        }

        private void btnSuaNV_MouseHover(object sender, EventArgs e)
        {
            btnSuaNV.Image = Properties.Resources.buttonSuaNVhover;
        }

        private void btnSuaNV_MouseLeave(object sender, EventArgs e)
        {
            btnSuaNV.Image = Properties.Resources.buttonSuaNV;
        }

        private void btnThemNV_MouseHover(object sender, EventArgs e)
        {
            btnThemNV.Image = Properties.Resources.buttonThemNVhover;
        }

        private void btnThemNV_MouseLeave(object sender, EventArgs e)
        {
            btnThemNV.Image = Properties.Resources.buttonThemNV;
        }
    }
}
