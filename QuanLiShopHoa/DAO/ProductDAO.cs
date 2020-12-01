using QuanLiShopHoa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiShopHoa.DAO
{
    public class ProductDAO
    {

        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { instance = value; }
        }

        private ProductDAO() { }

        public List<Product> GetListProduct()
        {
            List<Product> list = new List<Product>();

            string query = "select * from Product";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }

            return list;
        }

        public void ImportProduct(int maSanPham, int soLuong, string ghiChu)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_ImportProduct @maSanPham , @soLuong , @ghiChu", new object[] { maSanPham, soLuong, ghiChu });
        }

        public bool ExportProduct(int maSanPham, int soLuong, string ghiChu)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_ExportProduct @maSanPham , @soLuong , @ghiChu", new object[] { maSanPham, soLuong, ghiChu });

            return result > 0;
        }

        public bool InsertProduct(string tenSanPham, float donGia, string loaiSanPham, string mua)
        {

            string query = string.Format("insert into Product(tenSanPham,donGia,loaiSanPham,mua) values ( N'{0}' , {1} , N'{2}' , N'{3}')", tenSanPham, donGia, loaiSanPham, mua);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateProduct(int maSo, string tenSanPham, float donGia, string loaiSanPham, string mua)
        {

            string query = string.Format("update Product set tenSanPham = N'{0}', donGia = {1}, loaiSanPham = N'{2}', mua = N'{3}' where maSo = {4}", tenSanPham, donGia, loaiSanPham, mua, maSo);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<Product> SearchProductByName(string name)
        {
            List<Product> list = new List<Product>();

            string query = string.Format("select * from Product where tenSanPham like N'%{0}%'" , name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }

            return list;
        }

        public List<Import> SearchImportByMaSanPham(int maSanPham)
        {
            List<Import> list = new List<Import>();

            string query = string.Format("select * from Import where maSanPham = {0}" , maSanPham);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Import import = new Import(item);
                list.Add(import);
            }

            return list;
        }

        public List<Export> SearchExportByMaSanPham(int maSanPham)
        {
            List<Export> list = new List<Export>();

            string query = string.Format("select * from Export where maSanPham = {0}" , maSanPham);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Export export = new Export(item);
                list.Add(export);
            }

            return list;
        }

        public List<Import> GetListImport()
        {
            List<Import> list = new List<Import>();

            string query = "select * from Import";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Import import = new Import(item);
                list.Add(import);
            }

            return list;
        }

        public List<Export> GetListExport()
        {
            List<Export> list = new List<Export>();

            string query = "select * from Export";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Export export = new Export(item);
                list.Add(export);
            }

            return list;
        }
    }
}
