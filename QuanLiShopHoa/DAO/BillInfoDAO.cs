using QuanLiShopHoa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiShopHoa.DAO
{
    public class BillInfoDAO
    {

        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { instance = value; }
        }

        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo(int maHoaDon)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BillInfo where maHoaDon = " + maHoaDon);

            foreach(DataRow item in data.Rows)
            {
                BillInfo billInfo = new BillInfo(item);
                listBillInfo.Add(billInfo);
            }

            return listBillInfo;
        }

        public void InsertBillInfo(int maHoaDon, int maSanPham, int soLuong)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @maHoaDon , @maSanPham , @soLuong", new object[] { maHoaDon, maSanPham, soLuong });
        }
    }
}
