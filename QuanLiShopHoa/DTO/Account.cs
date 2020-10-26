using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiShopHoa.DTO
{
    public class Account
    {

        public Account(string tenDangNhap, string hoTen, DateTime? ngaySinh, string soDienThoai, string diaChi, int loaiTaiKhoan, string matKhau = null)
        {
            this.TenDangNhap = tenDangNhap;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.SoDienThoai = soDienThoai;
            this.DiaChi = DiaChi;
            this.LoaiTaiKhoan = loaiTaiKhoan;
            this.MatKhau = matKhau;
        }

        public Account(DataRow row)
        {
            this.TenDangNhap = row["tenDangNhap"].ToString();
            this.HoTen = row["hoTen"].ToString();
            this.NgaySinh = (DateTime?)row["ngaySinh"];
            this.SoDienThoai = row["soDienThoai"].ToString();
            this.DiaChi = row["diaChi"].ToString();
            this.LoaiTaiKhoan = (int)row["loaiTaiKhoan"];
            this.MatKhau = row["matKhau"].ToString();
        }


        private string tenDangNhap; 
        public string TenDangNhap {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }

        private string matKhau;
        public string MatKhau {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private string hoTen;
        public string HoTen {
            get { return hoTen; }
            set { hoTen = value; }
        }

        private DateTime? ngaySinh;
        public DateTime? NgaySinh {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }        

        private string soDienThoai;
        public string SoDienThoai {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }        

        private string diaChi;
        public string DiaChi {
            get { return diaChi; }
            set { diaChi = value; }
        }        

        private int loaiTaiKhoan;
        public int LoaiTaiKhoan {
            get { return loaiTaiKhoan; }
            set { loaiTaiKhoan = value; }
        }
    }
}
