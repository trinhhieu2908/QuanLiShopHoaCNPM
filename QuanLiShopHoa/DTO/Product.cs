using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiShopHoa.DTO
{
    public class Product
    {

        public Product(int maSo, string tenSanPham, float donGia, int soLuong, string loaiSanPham, string mua)
        {
            this.MaSo = maSo;
            this.TenSanPham = tenSanPham;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.LoaiSanPham = loaiSanPham;
            this.Mua = mua;
        }

        public Product(DataRow row)
        {
            this.MaSo = (int)row["maSo"];
            this.TenSanPham = row["tenSanPham"].ToString();
            this.DonGia = (float)Convert.ToDouble(row["donGia"].ToString());
            this.SoLuong = (int)row["soLuong"];
            this.LoaiSanPham = row["loaiSanPham"].ToString();
            this.Mua = row["mua"].ToString();
        }

        private int maSo;  
        public int MaSo {
            get { return maSo; }
            set { maSo = value; }
        }        

        private string tenSanPham;
        public string TenSanPham {
            get { return tenSanPham; }
            set { tenSanPham = value; }
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

        private string loaiSanPham;
        public string LoaiSanPham
        {
            get
            {
                return loaiSanPham;
            }

            set
            {
                loaiSanPham = value;
            }
        }

        private string mua;
        public string Mua
        {
            get
            {
                return mua;
            }

            set
            {
                mua = value;
            }
        }
    }
}
