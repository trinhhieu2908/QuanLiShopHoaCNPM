using Microsoft.SqlServer.Server;
using QuanLiShopHoa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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

            string query = "select * from Account where loaiTaiKhoan != 0";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Account acc = new Account(item);
                list.Add(acc);
            }

            return list;
        }

        public int Check(string userName)
        {
            string check = string.Format("SELECT * FROM dbo.Account WHERE tenDangNhap = N'{0}'", userName);
            var test = DataProvider.Instance.ExecuteScalar(check);
            if (test == null)
                return 1;
            else
                return 0;
        }
        public bool InsertAccount(string tenDangNhap, string matKhau, string hoTen, DateTime? ngaySinh, string soDienThoai, string diaChi, int loaiTaiKhoan)
        {
            
            string query = string.Format("insert into Account values ( N'{0}' , N'{1}' , N'{2}' , '{3}' , '{4}' , N'{5}' , {6})", tenDangNhap, matKhau, hoTen, ngaySinh, soDienThoai, diaChi, loaiTaiKhoan);
            if(Check(tenDangNhap) == 1)
            {
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            else
            {
                return false;
            }           
        }

        public bool UpdateAccount(string tenDangNhap, string matKhau, string hoTen, DateTime? ngaySinh, string soDienThoai, string diaChi, int loaiTaiKhoan)
        {
            string query = string.Format("update Account set matKhau = N'{0}', hoTen = N'{1}', ngaySinh = '{2}', soDienThoai = '{3}', diaChi = N'{4}', loaiTaiKhoan = N'{5}' where tenDangNhap = N'{6}'", matKhau, hoTen, ngaySinh, soDienThoai, diaChi, loaiTaiKhoan, tenDangNhap);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string tenDangNhap)
        {
            string query = string.Format("delete Account where tenDangNhap = N'{0}'", tenDangNhap);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
