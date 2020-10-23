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
            string x = " select * from dbo.Account where tenDangNhap = N'";
            string y = "' and MatKhau = N'";
            string z = "'";
            string query = x + tenDangNhap + y + matKhau + z;

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
    }
}
