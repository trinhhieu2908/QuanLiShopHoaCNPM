﻿using QuanLiShopHoa.DTO;
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

    }
}
