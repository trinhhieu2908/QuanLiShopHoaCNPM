using QuanLiShopHoa.DAO;
using QuanLiShopHoa.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiShopHoa
{
    public partial class formQuanLiDonHang : Form
    {
        public Account loginAccount;
        public formQuanLiDonHang(Account acc)
        {
            InitializeComponent();

            this.loginAccount = acc;

            ChangeAccount(acc.LoaiTaiKhoan);

            dateTimeHoaDon.Value = DateTime.Now;
            LoadListCheckedBill(dateTimeHoaDon.Value);
            ClearBinding();
            AddCheckedBillBinding();
        }

        void ChangeAccount(int loaiTaiKhoan)
        {
            if (loaiTaiKhoan == 0 || loaiTaiKhoan == 1)
            {
                btnXoa.Enabled = true;
            }            
            else
            {
                btnXoa.Enabled = false;
            }            
        }

        void LoadListCheckedBill(DateTime Day)
        {
            dtgvCheckedBill.DataSource = BillDAO.Instance.GetCheckedBillListInDay(Day);
        }

        void ShowCheckedBill(int maSo)
        {
            listViewSP.Items.Clear();
            List<MenuBillInfo> listBillInfo = MenuBillInfoDAO.Instance.GetListMenuByBill(maSo);
            float tongTien = 0;
            foreach (MenuBillInfo item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.MaSanPham.ToString());
                lsvItem.SubItems.Add(item.TenSanPham.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.DonGia.ToString());
                lsvItem.SubItems.Add(item.ThanhTien.ToString());
                tongTien += item.ThanhTien;
                listViewSP.Items.Add(lsvItem);
            }            
            
        }

        void AddCheckedBillBinding()
        {
            lbHDDangChon.DataBindings.Add(new Binding("Text", dtgvCheckedBill.DataSource, "maSo", true, DataSourceUpdateMode.Never));
            txbTongTien.DataBindings.Add(new Binding("Text", dtgvCheckedBill.DataSource, "tongTien", true, DataSourceUpdateMode.Never, "","#,0.00"));
        }

        void ClearBinding()
        {
            lbHDDangChon.DataBindings.Clear();
            txbTongTien.DataBindings.Clear();
        }        

        private void dateTimeHoaDon_ValueChanged(object sender, EventArgs e)
        {
            LoadListCheckedBill(dateTimeHoaDon.Value);
            ClearBinding();
            AddCheckedBillBinding();
        }

        private void lbHDDangChon_TextChanged(object sender, EventArgs e)
        {
            ShowCheckedBill(Convert.ToInt32(lbHDDangChon.Text));
        }

        List<Bill> SearchProductName(int maSo)
        {
            List<Bill> listBill = BillDAO.Instance.SearchCheckedBillByMaSo(maSo);

            return listBill;
        }

        private void iconTimDonHang_Click(object sender, EventArgs e)
        {
            dtgvCheckedBill.DataSource = SearchProductName(Convert.ToInt32(txbTimDonHang.Text));
            ClearBinding();
            AddCheckedBillBinding();
        }

        private void txbTimDonHang_TextChanged(object sender, EventArgs e)
        {
            if (txbTimDonHang.Text == "")
            {
                LoadListCheckedBill(dateTimeHoaDon.Value);
                ClearBinding();
                AddCheckedBillBinding();
            }
            else
            {
                dtgvCheckedBill.DataSource = SearchProductName(Convert.ToInt32(txbTimDonHang.Text));
                ClearBinding();
                AddCheckedBillBinding();
            }
        }

        private void txbTimDonHang_Click(object sender, EventArgs e)
        {
            txbTimDonHang.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maSo = Convert.ToInt32(lbHDDangChon.Text);
            string message = "Xác nhận xóa hóa đơn";
            string title = "Confirm Delete";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                DeleteBill(maSo);
            }
            else
            {
                //Do nothing
            }
            
        }

        void DeleteBill(int maSo)
        {
            List<BillInfo> listBillInfo = BillInfoDAO.Instance.GetListBillInfo(maSo);

            foreach (BillInfo item in listBillInfo)
            {
                BillInfoDAO.Instance.DeleteBillInfo(item.MaHoaDon, item.MaSanPham, item.SoLuong);
            }

            if (BillInfoDAO.Instance.DeleteBill(maSo))
            {
                MessageBox.Show("Xóa hóa đơn thành công!");
            }
            else
            {
                MessageBox.Show("Xóa hóa đơn thất bại!");
            }
            LoadListCheckedBill(dateTimeHoaDon.Value);
        }
    }
}
