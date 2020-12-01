using QuanLiShopHoa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiShopHoa.DAO
{
    public class BillDAO
    {

        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { instance = value; }
        }

        private BillDAO() { }

        public List<Bill> GetUncheckedBillList()
        {
            List<Bill> uncheckedBillList = new List<Bill>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetUnchekedBillList");

            foreach (DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);
                uncheckedBillList.Add(bill);
            }

            return uncheckedBillList;
        }        

        public int GetUncheckedBillByMaSo(int maSo)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Bill where maSo = " + maSo + " and trangThai = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.MaSo;
            }
            return -1;
        }

        public List<Bill> GetCheckedBillListInDay(DateTime Day)
        {
            List<Bill> checkedBillList = new List<Bill>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetChekedBillListInDay @day", new object[] { Day });

            foreach (DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);
                checkedBillList.Add(bill);
            }

            return checkedBillList;
        }

        public List<Bill> GetCheckedBillListFromTo(DateTime DayFrom, DateTime DayTo)
        {
            List<Bill> checkedBillList = new List<Bill>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetChekedBillListFromDay @dayfrom , @dayto", new object[] { DayFrom, DayTo });

            foreach (DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);
                checkedBillList.Add(bill);
            }

            return checkedBillList;
        }



        public List<Bill> SearchCheckedBillByMaSo(int maSo)
        {
            List<Bill> list = new List<Bill>();

            string query = string.Format("select * from Bill where maSo like '%{0}%' and trangThai = 1 " , maSo);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Bill Bill = new Bill(item);
                list.Add(Bill);
            }

            return list;            
        }

        public void InsertBill()
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill");
        }

        public int getMaxMaHoaDon()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(maSo) from Bill");
            }
            catch
            {
                return 1;
            }
        }

        public bool MakePayment(int maSo, float tongTien, string tenKH, string soDienThoaiKH, string nVThanhToan, string ghiChu)
        {
            string query = string.Format("update Bill set tongTien = {0}, tenKH = N'{1}', soDienThoaiKH = '{2}', ngayThanhToan = getdate(), nvThanhToan = N'{3}', ghiChu = N'{4}', trangThai = 1 where maSo = {5}", tongTien, tenKH, soDienThoaiKH, nVThanhToan, ghiChu, maSo);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
