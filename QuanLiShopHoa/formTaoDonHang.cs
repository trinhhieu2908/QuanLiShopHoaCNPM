﻿using QuanLiShopHoa.DAO;
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
    public partial class formTaoDonHang : Form
    {
        public Account loginAccount;
        public Bill currentBill;
        public float totalPrice;
        public float totalPriceDe;
        BindingSource ProductList = new BindingSource();
        public formTaoDonHang()
        {
            InitializeComponent();

            dtgvProduct.DataSource = ProductList;

            LoadListProduct();
            LoadUncheckedBill();
            lbSPDangChon.DataBindings.Clear();
            AddProductBinding();
        }

        #region method
        List<Product> SearchProductName(string name)
        {
            List<Product> listProduct = ProductDAO.Instance.SearchProductByName(name);

            return listProduct;
        }

        void LoadListProduct()
        {
            dtgvProduct.DataSource = ProductDAO.Instance.GetListProduct();
        }

        void LoadUncheckedBill()
        {
            List<Bill> uncheckedBillList = BillDAO.Instance.GetUncheckedBillList();

            foreach (Bill item in uncheckedBillList)
            {
                Button btn = new Button() { Width = 60, Height = 60 };
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
            totalPrice = tongTien;
            totalPriceDe = tongTien;
            CultureInfo culture = new CultureInfo("vi-Vn");
            txbTongTien.Text = tongTien.ToString("c", culture);
        }

        void AddProductBinding()
        {
            lbSPDangChon.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "maSo", true, DataSourceUpdateMode.Never));            
        }

        #endregion

        #region events
        private void formXacNhanThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {

            flpHoaDonChuaThanhToan.Controls.Clear();
            currentBill.MaSo = -1;
            LoadUncheckedBill();

        }

        private void btnBotSP_Click(object sender, EventArgs e)
        {
            Bill uncheckedBill = listViewSP.Tag as Bill;

            int maSanPham = Convert.ToInt32(lbSPDangChon.Text);
            int soLuong = (int)numericUpDownBotSP.Value;

            if (uncheckedBill == null)
            {

            }
            else
            {
                int maHoaDon = BillDAO.Instance.GetUncheckedBillByMaSo(uncheckedBill.MaSo);
                if (BillInfoDAO.Instance.DecreaseBillInfo(maHoaDon, maSanPham, soLuong))
                {

                }
                else
                {
                    MessageBox.Show("Số lượng bớt phải nhỏ hơn hoặc bằng số lượng trong hóa đơn!");
                }
                ShowUncheckedBill(uncheckedBill.MaSo);
                LoadListProduct();
                lbSPDangChon.DataBindings.Clear();
                AddProductBinding();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int discount = Convert.ToInt32(comboBox1.SelectedItem);
            if (discount == 0)
            {
                totalPrice = totalPriceDe;
            }
            totalPrice = totalPrice - (totalPrice * discount) / 100;

            CultureInfo culture = new CultureInfo("vi-Vn");
            txbTongTien.Text = totalPrice.ToString("c", culture);
        }

        private void iconTimSanPham_Click(object sender, EventArgs e)
        {
            dtgvProduct.DataSource = SearchProductName(txbTimSanPham.Text);
            lbSPDangChon.DataBindings.Clear();
            AddProductBinding();
        }

        private void txbTimSanPham_TextChanged(object sender, EventArgs e)
        {
            if (txbTimSanPham.Text == "")
            {
                LoadListProduct();
                lbSPDangChon.DataBindings.Clear();
                AddProductBinding();
            }
            else
            {
                dtgvProduct.DataSource = SearchProductName(txbTimSanPham.Text);
                lbSPDangChon.DataBindings.Clear();
                AddProductBinding();
            }

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            Bill uncheckedBill = listViewSP.Tag as Bill;

            if (uncheckedBill == null)
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn!");
            }
            else
            {
                currentBill = uncheckedBill;
                if (totalPrice == 0)
                {
                    MessageBox.Show("Không được phép thanh toán hóa đơn rỗng!");
                }
                else
                {
                    formXacNhanThanhToan f = new formXacNhanThanhToan(loginAccount, currentBill, totalPrice);
                    f.FormClosing += new FormClosingEventHandler(this.formXacNhanThanhToan_FormClosing);
                    f.ShowDialog();
                }

            }

        }

        private void txbTimSanPham_DoubleClick(object sender, EventArgs e)
        {
            txbTimSanPham.Clear();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            int uncheckedBillmaSo = ((sender as Button).Tag as Bill).MaSo;
            listViewSP.Tag = (sender as Button).Tag;
            ShowUncheckedBill(uncheckedBillmaSo);
        }

        private void btnHoaDonMoi_Click(object sender, EventArgs e)
        {
            BillDAO.Instance.InsertBill();
            flpHoaDonChuaThanhToan.Controls.Clear();
            LoadUncheckedBill();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            Bill uncheckedBill = listViewSP.Tag as Bill;

            int maSanPham = Convert.ToInt32(lbSPDangChon.Text);
            int soLuong = (int)numericUpDownThemSP.Value;

            if (uncheckedBill == null)
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn!");
            }
            else
            {
                try
                {
                    int maHoaDon = BillDAO.Instance.GetUncheckedBillByMaSo(uncheckedBill.MaSo);
                    if (BillInfoDAO.Instance.InsertBillInfo(maHoaDon, maSanPham, soLuong))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Số lượng sản phẩm trong kho còn lại không đủ");
                    }
                    ShowUncheckedBill(uncheckedBill.MaSo);
                    LoadListProduct();
                    lbSPDangChon.DataBindings.Clear();
                    AddProductBinding();
                }
                catch
                {
                    MessageBox.Show("Vui lòng chọn 1 hóa đơn!");
                }              
            }           
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
