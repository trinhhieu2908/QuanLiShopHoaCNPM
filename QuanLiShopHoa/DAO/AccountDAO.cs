using QuanLiShopHoa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiShopHoa.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            string query = "USP_Login @tenDangNhap , @MatKhau";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {tenDangNhap, matKhau});

            return result.Rows.Count > 0;
        }

        public Account GetAccountByTenDangNhap(string tenDangNhap)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Account where tenDangNhap = '" + tenDangNhap + "'");

            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        public List<Account> GetListAccount()
        {
            List<Account> list = new List<Account>();

            string query = "select * from Account";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Account acc = new Account(item);
                list.Add(acc);
            }

            return list;
        }
    }
}
