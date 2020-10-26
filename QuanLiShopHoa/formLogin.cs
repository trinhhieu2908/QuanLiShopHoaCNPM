using QuanLiShopHoa.DAO;
using QuanLiShopHoa.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiShopHoa
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }


        #region events
        private void txbTenDangNhap_Click(object sender, EventArgs e)
        {            
            picTenDangNhap.BackgroundImage = Properties.Resources.userloginClick;
            panel1.BackColor = Color.FromArgb(80, 8, 189);
            txbTenDangNhap.ForeColor = Color.FromArgb(80, 8, 189);
            
            picMatKhau.BackgroundImage = Properties.Resources.passwordlogin;
            panel2.BackColor = Color.Black;
            txbMatKhau.ForeColor = Color.Black;
        }

        private void txbMatKhau_Click(object sender, EventArgs e)
        {            
            picMatKhau.BackgroundImage = Properties.Resources.passwordloginClick;
            panel2.BackColor = Color.FromArgb(80, 8, 189);
            txbMatKhau.ForeColor = Color.FromArgb(80, 8, 189);

            picTenDangNhap.BackgroundImage = Properties.Resources.userlogin;
            panel1.BackColor = Color.Black;
            txbTenDangNhap.ForeColor = Color.Black;
        }

        private void txbTenDangNhap_DoubleClick(object sender, EventArgs e)
        {
            txbTenDangNhap.Clear();
            txbMatKhau.Clear();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txbTenDangNhap.Text;
            string matKhau = txbMatKhau.Text;
            if (DangNhap(tenDangNhap, matKhau))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByTenDangNhap(tenDangNhap);

                formHomePage f = new formHomePage(loginAccount);
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }

        }

        #endregion

        #region method
        private void Form1_Load(object sender, EventArgs e)
        {

        }        

        bool DangNhap(string tenDangNhap, string matKhau)
        {
            return AccountDAO.Instance.DangNhap(tenDangNhap, matKhau);
        }

        #endregion

        #region design
        //move
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMgs, int wParam, int lParam);

        private void formLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void txbTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
