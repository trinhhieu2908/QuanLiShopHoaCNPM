using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiShopHoa.DTO
{
    public class Import
    {
        public Import(int maSo, int maSanPham, int soLuong, DateTime? ngayNhap, string ghiChu)
        {
            this.MaSo = maSo;
            this.MaSanPham = maSanPham;
            this.SoLuong = soLuong;
            this.NgayNhap = ngayNhap;
            this.GhiChu = ghiChu;
        }

        public Import(DataRow row)
        {
            this.MaSo = (int)row["maSo"];
            this.MaSanPham = (int)row["maSanPham"];
            this.SoLuong = (int)row["soLuong"];
            this.NgayNhap = (DateTime?)row["ngayNhap"];            
            this.GhiChu = row["ghiChu"].ToString();
        }

        private int maSo;
        public int MaSo
        {
            get { return maSo; }
            set { maSo = value; }
        }

        private int maSanPham;
        public int MaSanPham
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }

        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private DateTime? ngayNhap;
        public DateTime? NgayNhap
        {
            get
            {
                return ngayNhap;
            }

            set
            {
                ngayNhap = value;
            }
        }

        private string ghiChu;
        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }
    }
}
