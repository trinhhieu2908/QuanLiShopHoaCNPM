using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiShopHoa.DTO
{
    public class BillInfo
    {

        public BillInfo(int maSo, int maHoaDon, int maSanPham, int soLuong)
        {
            this.MaSo = maSo;
            this.MaHoaDon = maHoaDon;
            this.MaSanPham = maSanPham;
            this.SoLuong = soLuong;
        }

        public BillInfo(DataRow row)
        {
            this.MaSo = (int)row["maSo"];
            this.MaHoaDon = (int)row["maHoaDon"];
            this.MaSanPham = (int)row["maSanPham"];
            this.SoLuong = (int)row["soLuong"];
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

        private int maHoaDon;
        public int MaHoaDon
        {
            get
            {
                return maHoaDon;
            }

            set
            {
                maHoaDon = value;
            }
        }

        private int maSanPham;
        public int MaSanPham
        {
            get
            {
                return maSanPham;
            }

            set
            {
                maSanPham = value;
            }
        }

        private int soLuong;
        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        
    }
}
