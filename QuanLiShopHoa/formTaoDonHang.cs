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
    public partial class formTaoDonHang : Form
    {
        public formTaoDonHang()
        {
            InitializeComponent();

            LoadListProduct();
            LoadUncheckedBill();
        }

        #region method
        void LoadListProduct()
        {
            dtgvProduct.DataSource = ProductDAO.Instance.GetListProduct();
        }

        void LoadUncheckedBill()
        {
            List<Bill> uncheckedBillList = BillDAO.Instance.GetUncheckedBillList();

            foreach (Bill item in uncheckedBillList)
            {
                Button btn = new Button() {Width = 60, Height = 60 };
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.FromArgb(247, 153, 232);
                btn.Text = item.MaSo.ToString();

                btn.Click += btn_Click;
                btn.Tag = item;

                flpHoaDonChuaThanhToan.Controls.Add(btn);
            }
        }

        void ShowUncheckedBill(int maSo)
        {
            listViewSP.Items.Clear();
            List<MenuBillInfo> listBillInfo = MenuBillInfoDAO.Instance.GetListMenuByUncheckedBill(maSo);

            foreach(MenuBillInfo item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.MaSanPham.ToString());
                lsvItem.SubItems.Add(item.TenSanPham.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.DonGia.ToString());
                lsvItem.SubItems.Add(item.ThanhTien.ToString());

                listViewSP.Items.Add(lsvItem);
            }
        }

        #endregion


        #region events
        private void btn_Click(object sender, EventArgs e)
        {
            int uncheckedBillmaSo = ((sender as Button).Tag as Bill).MaSo;
            ShowUncheckedBill(uncheckedBillmaSo);
        }
        #endregion
        #region design        
        private void btnThanhToan_MouseHover(object sender, EventArgs e)
        {
            btnThanhToan.Image = Properties.Resources.buttonThanhToanhover;
        }

        private void btnThanhToan_MouseLeave(object sender, EventArgs e)
        {
            btnThanhToan.Image = Properties.Resources.buttonThanhToan;
        }
        #endregion
    }
}
