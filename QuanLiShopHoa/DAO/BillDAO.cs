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
    }
}
