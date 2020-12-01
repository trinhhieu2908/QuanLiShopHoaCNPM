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
    public partial class formQuanLiDoanhThu : Form
    {
        public formQuanLiDoanhThu()
        {
            InitializeComponent();


            dateTimeFrom.Value = DateTime.Now;
            dateTimeTo.Value = DateTime.Now;
            LoadListCheckedBill(dateTimeFrom.Value, dateTimeTo.Value);
        }

        void LoadListCheckedBill(DateTime DayFrom, DateTime DayTo)
        {
            dtgvHD.DataSource = BillDAO.Instance.GetCheckedBillListFromTo(DayFrom, DayTo);
        }

        void CaculateDoanhThu()
        {
            List<Bill> checkedBillList = BillDAO.Instance.GetCheckedBillListFromTo(dateTimeFrom.Value, dateTimeTo.Value);
            float doanhThu = 0;
            foreach (Bill item in checkedBillList)
            {                
                doanhThu += item.TongTien;                
            }
            CultureInfo culture = new CultureInfo("vi-Vn");
            txbDoanhThu.Text = doanhThu.ToString("c", culture);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadListCheckedBill(dateTimeFrom.Value, dateTimeTo.Value);
            CaculateDoanhThu();
        }
    }
}
