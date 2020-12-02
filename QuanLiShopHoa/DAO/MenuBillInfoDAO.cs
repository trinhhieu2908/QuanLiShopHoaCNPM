using QuanLiShopHoa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiShopHoa.DAO
{
    public class MenuBillInfoDAO
    {
        private static MenuBillInfoDAO instance;

        public static MenuBillInfoDAO Instance
        {
            get { if (instance == null) instance = new MenuBillInfoDAO(); return MenuBillInfoDAO.instance; }
            private set { instance = value; }
        }

        private MenuBillInfoDAO() { }

        public List<MenuBillInfo> GetListMenuByBill(int maSo)
        {
            List<MenuBillInfo> listMenu = new List<MenuBillInfo>();

            string query = "select p.maSo, p.tenSanPham, bi.soLuong, p.donGia, p.donGia*bi.soLuong as [thanhTien] from BillInfo as bi, Bill as b, Product as p where bi.maHoaDon = b.maSo and bi.maSanPham = p.maSo and b.maSo = " + maSo;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                MenuBillInfo menu = new MenuBillInfo(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }

    }
}
