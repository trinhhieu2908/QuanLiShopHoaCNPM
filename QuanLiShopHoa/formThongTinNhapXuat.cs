using QuanLiShopHoa.DAO;
using QuanLiShopHoa.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiShopHoa
{
    public partial class formThongTinNhapXuat : Form
    {
        public formThongTinNhapXuat()
        {
            InitializeComponent();

            LoadListImport();
            LoadListExport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadListImport()
        {
            dtgvImport.DataSource = ProductDAO.Instance.GetListImport();
        }

        void LoadListExport()
        {
            dtgvExport.DataSource = ProductDAO.Instance.GetListExport();
        }

        List<Import> SearchImportByMaSanPham(int maSo)
        {
            List<Import> listImport = ProductDAO.Instance.SearchImportByMaSanPham(maSo);

            return listImport;
        }

        List<Export> SearchExportByMaSanPham(int maSo)
        {
            List<Export> listExport = ProductDAO.Instance.SearchExportByMaSanPham(maSo);

            return listExport;
        }

        private void iconTSPNhap_Click(object sender, EventArgs e)
        {
            if (txbTSPNhap.Text == "")
            {
                LoadListImport();
            }
            else
            {
                dtgvImport.DataSource = SearchImportByMaSanPham(Convert.ToInt32(txbTSPNhap.Text));
            }
                
        }

        private void iconTSPXuat_Click(object sender, EventArgs e)
        {
            if (txbTSPXuat.Text == "")
            {
                LoadListExport();
            }
            else
            {
                dtgvExport.DataSource = SearchExportByMaSanPham(Convert.ToInt32(txbTSPXuat.Text));
            }
        }

        private void txbTSPNhap_Click(object sender, EventArgs e)
        {
            txbTSPNhap.Clear();
        }

        private void txbTSPXuat_Click(object sender, EventArgs e)
        {
            txbTSPXuat.Clear();
        }
    }
}
