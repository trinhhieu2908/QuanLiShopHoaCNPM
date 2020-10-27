using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiShopHoa.DTO
{
    public class MenuBillInfo
    {

        public MenuBillInfo(int maSanPham, string tenSanPham, int soLuong, float donGia, float thanhTien = 0)
        {
            this.MaSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.soLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
        }

        public MenuBillInfo(DataRow row)
        {
            this.MaSanPham = (int)row["maSo"];
            this.tenSanPham = row["tenSanPham"].ToString();
            this.soLuong = (int)row["soLuong"];
            this.DonGia = (float)Convert.ToDouble(row["donGia"].ToString());
            this.ThanhTien = (float)Convert.ToDouble(row["thanhTien"].ToString());
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

        private string tenSanPham;
        public string TenSanPham
        {
            get
            {
                return tenSanPham;
            }

            set
            {
                tenSanPham = value;
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

        private float donGia;
        public float DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        private float thanhTien;
        public float ThanhTien
        {
            get
            {
                return thanhTien;
            }

            set
            {
                thanhTien = value;
            }
        }

        
    }
}
