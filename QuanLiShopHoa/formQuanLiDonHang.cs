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
        public formQuanLiDonHang()
        {
            InitializeComponent();

            dateTimeHoaDon.Value = DateTime.Now;
            LoadListCheckedBill(dateTimeHoaDon.Value);
            lbHDDangChon.DataBindings.Clear();
            txbTongTien.DataBindings.Clear();
            AddCheckedBillBinding();
        }

        void LoadListCheckedBill(DateTime Day)
        {
            dtgvCheckedBill.DataSource = BillDAO.Instance.GetCheckedBillListInDay(Day);
        }

        void ShowCheckedBill(int maSo)
        {
            listViewSP.Items.Clear();
            List<MenuBillInfo> listBillInfo = MenuBillInfoDAO.Instance.GetListMenuByUncheckedBill(maSo);
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

        private void btnXem_Click(object sender, EventArgs e)
        {
            ShowCheckedBill(Convert.ToInt32(lbHDDangChon.Text));
        }

        private void dateTimeHoaDon_ValueChanged(object sender, EventArgs e)
        {
            LoadListCheckedBill(dateTimeHoaDon.Value);
            lbHDDangChon.DataBindings.Clear();
            txbTongTien.DataBindings.Clear();
            AddCheckedBillBinding();
        }

        private void lbHDDangChon_TextChanged(object sender, EventArgs e)
        {
            ShowCheckedBill(Convert.ToInt32(lbHDDangChon.Text));
        }
    }
}
