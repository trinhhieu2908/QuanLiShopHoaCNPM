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
using FontAwesome.Sharp;

namespace QuanLiShopHoa
{
    public partial class formHomePage : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public formHomePage()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 72);
            panelMenu.Controls.Add(leftBorderBtn);
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;           
            
        }

        private void openChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //Struct
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 61, 142);
            public static Color color2 = Color.FromArgb(99, 245, 91);
            public static Color color3 = Color.FromArgb(71, 201, 245);
            public static Color color4 = Color.FromArgb(255, 143, 94);
            public static Color color5 = Color.FromArgb(232, 245, 91);

        }

        //Methods
        private void activateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                disableButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(64, 62, 64);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                //label title child form
                labelTitleChildForm.Text = currentBtn.Text;
                labelTitleChildForm.ForeColor = color;
            }
        }

        private void disableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(8, 8, 8);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        //code
        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color1);
            openChildForm(new formTaoDonHang());
            panelShadow.BackColor = RGBColors.color1;
        }

        private void btnQuanLiDonHang_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color2);
            openChildForm(new formQuanLiDonHang());
            panelShadow.BackColor = RGBColors.color2;
        }

        private void btnQuanLiKho_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color3);
            openChildForm(new formQuanLiKho());
            panelShadow.BackColor = RGBColors.color3;
        }

        private void btnQuanLiNhanVien_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color4);
            openChildForm(new formQuanLiNhanVien());
            panelShadow.BackColor = RGBColors.color4;
        }

        private void btnQuanLiDoanhThu_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color5);
            openChildForm(new formQuanLiDoanhThu());
            panelShadow.BackColor = RGBColors.color5;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
                reset();
            }
        }

        private void reset()
        {
            disableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.HotPink;
            labelTitleChildForm.Text = "Home";
            labelTitleChildForm.ForeColor = Color.Gainsboro;
            panelShadow.BackColor = Color.FromArgb(33, 31, 33);
        }

        //Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMgs, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }            

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
