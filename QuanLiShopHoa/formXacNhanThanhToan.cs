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
    public partial class formXacNhanThanhToan : Form
    {
        private Account loginAccount;
        private Bill currentBill;
        private float totalPrice;
        public formXacNhanThanhToan(Account acc, Bill bill, float totalPrice)
        {
            InitializeComponent();

            this.loginAccount = acc;
            this.currentBill = bill;
            this.totalPrice = totalPrice;

            LoadBill();
        }

        void LoadBill()
        {
            lbNVThanhToan.Text = loginAccount.HoTen;
            lbMaHoaDon.Text = currentBill.MaSo.ToString();
            CultureInfo culture = new CultureInfo("vi-Vn");
            lbTongTien.Text = totalPrice.ToString("c", culture);
        }

        void MakePayment(int maSo, float tongTien, string tenKH, string soDienThoaiKH, string nVThanhToan, string ghiChu)
        {            
            if(BillDAO.Instance.MakePayment(maSo, tongTien, tenKH, soDienThoaiKH, nVThanhToan, ghiChu))
            {
                MessageBox.Show("Thanh toán thành công!");
                this.Close();                
            }
            else
            {
                MessageBox.Show("Thanh toán không thành công!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            int maSo = currentBill.MaSo;
            float tongTien = totalPrice;
            string tenKH = txbTenKH.Text;
            string soDienThoaiKH = txbSoDienThoaiKH.Text;
            string nVThanhToan = lbNVThanhToan.Text;
            string ghiChu = txbGhiChu.Text;

            MakePayment(maSo, tongTien, tenKH, soDienThoaiKH, nVThanhToan, ghiChu);
        }
    }
}
