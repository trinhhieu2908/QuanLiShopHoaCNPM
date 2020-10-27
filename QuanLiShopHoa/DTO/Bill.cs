using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiShopHoa.DTO
{
    public class Bill
    {  
        
        public Bill(int maSo, float tongTien, string tenKH, string soDienThoaiKH, DateTime? ngayThanhToan, string nVThanhToan, string ghiChu, int trangThai)
        {
            this.MaSo = maSo;
            this.TongTien = tongTien;
            this.TenKH = tenKH;
            this.SoDienThoaiKH = soDienThoaiKH;
            this.NgayThanhToan = ngayThanhToan;
            this.NVThanhToan = nVThanhToan;
            this.GhiChu = ghiChu;
            this.TrangThai = trangThai;
        }

        public Bill(DataRow row)
        {
            this.MaSo = (int)row["maSo"];
            this.TongTien = (float)Convert.ToDouble(row["tongTien"].ToString()); ;
            this.TenKH = row["tenKH"].ToString(); ;
            this.SoDienThoaiKH = row["soDienThoaiKH"].ToString(); ;
            this.NgayThanhToan = (DateTime?)row["ngayThanhToan"];
            this.NVThanhToan = row["nVThanhToan"].ToString(); ;
            this.GhiChu = row["ghiChu"].ToString(); ;
            this.TrangThai = (int)row["trangThai"];
        }

        private int maSo;

        public int MaSo
        {
            get
            {
                return maSo;
            }

            set
            {
                maSo = value;
            }
        }

        private float tongTien;
        public float TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }

        private string tenKH;
        public string TenKH
        {
            get
            {
                return tenKH;
            }

            set
            {
                tenKH = value;
            }
        }

        private string soDienThoaiKH;
        public string SoDienThoaiKH
        {
            get
            {
                return soDienThoaiKH;
            }

            set
            {
                soDienThoaiKH = value;
            }
        }

        private DateTime? ngayThanhToan;
        public DateTime? NgayThanhToan
        {
            get
            {
                return ngayThanhToan;
            }

            set
            {
                ngayThanhToan = value;
            }
        }

        private string nVThanhToan;
        public string NVThanhToan
        {
            get
            {
                return nVThanhToan;
            }

            set
            {
                nVThanhToan = value;
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

        private int trangThai;
        public int TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }        
    }
}
