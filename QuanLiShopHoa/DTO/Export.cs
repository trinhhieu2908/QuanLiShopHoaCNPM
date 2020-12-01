using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiShopHoa.DTO
{
    public class Export
    {
        public Export(int maSo, int maSanPham, int soLuong, DateTime? ngayXuat, string ghiChu)
        {
            this.MaSo = maSo;
            this.MaSanPham = maSanPham;
            this.SoLuong = soLuong;
            this.NgayXuat = ngayXuat;
            this.GhiChu = ghiChu;
        }

        public Export(DataRow row)
        {
            this.MaSo = (int)row["maSo"];
            this.MaSanPham = (int)row["maSanPham"];
            this.SoLuong = (int)row["soLuong"];
            this.NgayXuat = (DateTime?)row["ngayXuat"];
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

        private DateTime? ngayXuat;
        public DateTime? NgayXuat
        {
            get
            {
                return ngayXuat;
            }

            set
            {
                ngayXuat = value;
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
