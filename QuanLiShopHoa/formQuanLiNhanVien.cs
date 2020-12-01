using QuanLiShopHoa.DAO;
using QuanLiShopHoa.DTO;
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
        public Account loginAccount;
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
        #endregion

        #region events

        private void btnXoaNV_Click(object sender, EventArgs e)
        {            
            string tenDangNhap = txbTenDangNhap.Text;

            DeleteAccount(tenDangNhap);
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txbTenDangNhap.Text;
            string matKhau = txbMatKhau.Text;
            string hoTen = txbHoTen.Text;
            DateTime? ngaySinh = dateTimeNgaySinh.Value;
            string soDienThoai = txbSoDienThoai.Text;
            string diaChi = txbDiaChi.Text;
            int loaiTaiKhoan = (int)numericUpDownLoaiTaiKhoan.Value;

            if ((int)numericUpDownLoaiTaiKhoan.Value == 0)
            {
                MessageBox.Show("Không được sửa thành tài khoản dạng Admin");
            }
            else
            {
                try
                {
                    UpdateAccount(tenDangNhap, matKhau, hoTen, ngaySinh, soDienThoai, diaChi, loaiTaiKhoan);
                }
                catch
                {
                    MessageBox.Show("Vui lòng kiểm tra lại kiểu ngày sinh");
                }
                
            }

            
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txbTenDangNhap.Text;
            string matKhau = txbMatKhau.Text;
            string hoTen = txbHoTen.Text;
            DateTime? ngaySinh = dateTimeNgaySinh.Value;
            string soDienThoai = txbSoDienThoai.Text;
            string diaChi = txbDiaChi.Text;
            int loaiTaiKhoan = (int)numericUpDownLoaiTaiKhoan.Value;

            if ((int)numericUpDownLoaiTaiKhoan.Value == 0)
            {
                MessageBox.Show("Không được thêm tài khoản dạng Admin");
            }
            else
            {
                try
                {
                    AddAccount(tenDangNhap, matKhau, hoTen, ngaySinh, soDienThoai, diaChi, loaiTaiKhoan);
                }
                catch
                {
                    MessageBox.Show("Vui lòng kiểm tra lại kiểu ngày sinh");
                }
                
            }

            
        }

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
        
        void DeleteAccount(string tenDangNhap)
        {
            if (loginAccount.TenDangNhap.Equals(tenDangNhap))
            {
                MessageBox.Show("Không thể xóa chính mình!");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(tenDangNhap))
            {
                MessageBox.Show("Xóa nhân viên thành công!");
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại!");
            }
            LoadListAccount();
        }

        void UpdateAccount(string tenDangNhap, string matKhau, string hoTen, DateTime? ngaySinh, string soDienThoai, string diaChi, int loaiTaiKhoan)
        {
            if(AccountDAO.Instance.UpdateAccount(tenDangNhap, matKhau, hoTen, ngaySinh, soDienThoai, diaChi, loaiTaiKhoan))
            {
                MessageBox.Show("Cập nhật nhân viên thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên thất bại!");
            }
            LoadListAccount();
        }

        void AddAccount(string tenDangNhap, string matKhau, string hoTen, DateTime? ngaySinh, string soDienThoai, string diaChi, int loaiTaiKhoan)
        {            
            if(AccountDAO.Instance.InsertAccount(tenDangNhap, matKhau, hoTen, ngaySinh, soDienThoai, diaChi, loaiTaiKhoan))
            {
                MessageBox.Show("Thêm nhân viên thành công!");
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại vui lòng kiểm tra tên đăng nhập có trùng hay không!");
            }
            LoadListAccount();
        }

        void LoadListAccount()
        {
            AccountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void AddAccountBinding()
        {
            txbTenDangNhap.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "tenDangNhap", true, DataSourceUpdateMode.Never));
            txbMatKhau.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "matKhau", true, DataSourceUpdateMode.Never));
            txbHoTen.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "hoTen", true, DataSourceUpdateMode.Never));
            dateTimeNgaySinh.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "ngaySinh", true, DataSourceUpdateMode.Never));
            txbSoDienThoai.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "soDienThoai", true, DataSourceUpdateMode.Never));
            txbDiaChi.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "diaChi", true, DataSourceUpdateMode.Never));
            numericUpDownLoaiTaiKhoan.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "loaiTaiKhoan", true, DataSourceUpdateMode.Never));
        }
        #endregion

        
    }
}
