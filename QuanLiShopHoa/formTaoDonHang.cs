using QuanLiShopHoa.DAO;
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
    public partial class formTaoDonHang : Form
    {
        public formTaoDonHang()
        {
            InitializeComponent();

            LoadListProduct();
        }

        void LoadListProduct()
        {
            dtgvProduct.DataSource = ProductDAO.Instance.GetListProduct();
        }

        private void btnThanhToan_MouseHover(object sender, EventArgs e)
        {
            btnThanhToan.Image = Properties.Resources.buttonThanhToanhover;
        }

        private void btnThanhToan_MouseLeave(object sender, EventArgs e)
        {
            btnThanhToan.Image = Properties.Resources.buttonThanhToan;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
