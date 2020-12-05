using iTextSharp.text;
using iTextSharp.text.pdf;
using QuanLiShopHoa.DAO;
using QuanLiShopHoa.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiShopHoa
{
    public partial class formXacNhanThanhToan : Form
    {
        private Account loginAccount;
        private Bill currentBill;
        private float totalPrice;
        public formXacNhanThanhToan(Account acc, Bill bill, float totalPrice)
        {
            InitializeComponent();

            this.loginAccount = acc;
            this.currentBill = bill;
            this.totalPrice = totalPrice;
                        
            LoadBill();
            
        }

        void LoadBill()
        {
            lbNVThanhToan.Text = loginAccount.HoTen;
            lbMaHoaDon.Text = currentBill.MaSo.ToString();
            CultureInfo culture = new CultureInfo("vi-Vn");
            lbTongTien.Text = totalPrice.ToString("c", culture);
            lbNgayThanhToan.Text = currentBill.NgayThanhToan.ToString();
        }

        void MakePayment(int maSo, float tongTien, string tenKH, string soDienThoaiKH, string nVThanhToan, string ghiChu)
        {            
            if(BillDAO.Instance.MakePayment(maSo, tongTien, tenKH, soDienThoaiKH, nVThanhToan, ghiChu))
            {
                MessageBox.Show("Thanh toán thành công!");
                this.Close();                
            }
            else
            {
                MessageBox.Show("Thanh toán không thành công!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            int maSo = currentBill.MaSo;
            float tongTien = totalPrice;
            string tenKH = txbTenKH.Text;
            string soDienThoaiKH = txbSoDienThoaiKH.Text;
            string nVThanhToan = lbNVThanhToan.Text;
            string ghiChu = txbGhiChu.Text;

            MakePayment(maSo, tongTien, tenKH, soDienThoaiKH, nVThanhToan, ghiChu);
        }            

        
        
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter ="PDF file|*.pdf",ValidateNames = true })
            {
                if(sfd.ShowDialog()== DialogResult.OK)
                {
                    DataTable listMenu = MenuBillInfoDAO.Instance.GetMenuToPrint(Convert.ToInt32(lbMaHoaDon.Text));
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A5);
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();


                        string fontpath = "D:\\CNTT\\Cong nghe phan mem\\DoAn\\Project\\QuanLyCuaHangHoa\\QuanLyCuaHangHoa\\font\\vuArial.ttf";
                        BaseFont bf = BaseFont.CreateFont(fontpath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);


                        //Ten shop
                        iTextSharp.text.Font fshop = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.BOLD);
                        Paragraph shop = new Paragraph();
                        shop.Alignment = Element.ALIGN_CENTER;
                        shop.Add(new Chunk("THE FLOWER HOUSE", fshop));
                        doc.Add(shop);

                        //dia chi
                        iTextSharp.text.Font fdc = new iTextSharp.text.Font(bf, 12);
                        Paragraph dc = new Paragraph();
                        dc.Alignment = Element.ALIGN_CENTER;
                        dc.Add(new Chunk("19 Nguyễn Hữu Thọ - Tân Phong - Quận 7 - Hồ Chí Minh", fdc));
                        doc.Add(dc);

                        //sdt                        
                        Paragraph dt = new Paragraph();
                        dt.Alignment = Element.ALIGN_CENTER;
                        dt.Add(new Chunk("Điện thoại: 0949961157 or 0963773237", fdc));
                        doc.Add(dt);
                        doc.Add(new Chunk("\n"));

                        //hoa don
                        iTextSharp.text.Font fhoadon = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
                        Paragraph hoadon = new Paragraph();
                        hoadon.Alignment = Element.ALIGN_CENTER;
                        hoadon.Add(new Chunk("Hóa đơn thanh toán", fhoadon));
                        doc.Add(hoadon);
                        


                        // thong tin
                        iTextSharp.text.Font fthongtin = new iTextSharp.text.Font(bf, 12);
                        Paragraph thongtin = new Paragraph();
                        thongtin.Alignment = Element.ALIGN_CENTER;
                        thongtin.Add(new Chunk("Mã hóa đơn: ", fthongtin));
                        thongtin.Add(new Chunk(lbMaHoaDon.Text, fthongtin));
                        thongtin.Add(new Chunk("\nNgày thanh toán: ", fthongtin));
                        thongtin.Add(new Chunk(lbNgayThanhToan.Text, fthongtin));
                        thongtin.Add(new Chunk("\nNhân viên thanh toán: ", fthongtin));
                        thongtin.Add(new Chunk(lbNVThanhToan.Text, fthongtin));
                        doc.Add(thongtin);
                        doc.Add(new Chunk("\n"));

                        // thong tin khach hang                        
                        Paragraph thongtinkh = new Paragraph();
                        thongtinkh.Alignment = Element.ALIGN_LEFT;
                        thongtinkh.Add(new Chunk("Khách hàng: ", fthongtin));
                        thongtinkh.Add(new Chunk(txbTenKH.Text, fthongtin));
                        thongtinkh.Add(new Chunk("\nSDT: ", fthongtin));
                        thongtinkh.Add(new Chunk(txbSoDienThoaiKH.Text, fthongtin));                        
                        doc.Add(thongtinkh);

                        //Line
                        Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK , Element.ALIGN_LEFT, 1)));
                        doc.Add(line);
                        doc.Add(new Chunk("\n"));


                        //table data
                        iTextSharp.text.Font fdatas = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.BOLDITALIC);
                        iTextSharp.text.Font fdata = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.ITALIC);
                        float ThanhTien = 0;
                        for (int i = 0; i < listMenu.Rows.Count; i++)
                        {
                            Paragraph item = new Paragraph();
                            item.Alignment = Element.ALIGN_LEFT;
                            item.Add(new Chunk("- "));
                            item.Add(new Chunk(listMenu.Rows[i][0].ToString(), fdatas));

                            item.Add(new Chunk("\n"));
                            item.Add(new Chunk("      + Số lượng: ", fdata));
                            item.Add(new Chunk(listMenu.Rows[i][1].ToString(), fdata));

                            item.Add(new Chunk("\n"));
                            item.Add(new Chunk("      + Đơn giá: ", fdata));
                            item.Add(new Chunk(listMenu.Rows[i][2].ToString(), fdata));                            

                            item.Add(new Chunk("\n"));
                            doc.Add(item);

                            ThanhTien += float.Parse(listMenu.Rows[i][3].ToString());
                        }
                        float discount = 100 - (totalPrice / ThanhTien) * 100;
                        
                        doc.Add(new Chunk("\n"));
                        doc.Add(line);

                        //Tong tien hang
                        iTextSharp.text.Font fthongtint = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
                        Paragraph tongtien = new Paragraph();
                        tongtien.Alignment = Element.ALIGN_RIGHT;
                        tongtien.Add(new Chunk("Tổng tiền hàng: ", fthongtint));
                        CultureInfo culture = new CultureInfo("vi-Vn");
                        tongtien.Add(new Chunk(ThanhTien.ToString("c", culture), fthongtin));
                        doc.Add(tongtien);

                        //chiet khau
                        Paragraph chietkhau = new Paragraph();
                        chietkhau.Alignment = Element.ALIGN_RIGHT;
                        chietkhau.Add(new Chunk("Chiết khấu: ", fthongtint));
                        chietkhau.Add(new Chunk(discount.ToString() + "%", fthongtin));
                        doc.Add(chietkhau);


                        Paragraph tongtienTT = new Paragraph();
                        tongtienTT.Alignment = Element.ALIGN_RIGHT;
                        tongtienTT.Add(new Chunk("Tổng thanh toán: ", fthongtint));
                        tongtienTT.Add(new Chunk(lbTongTien.Text, fthongtin));
                        doc.Add(tongtienTT);

                        doc.Add(new Chunk("\n"));

                        Paragraph Thank = new Paragraph();
                        Thank.Alignment = Element.ALIGN_CENTER;
                        Thank.Add(new Chunk("Thank you so much ♥ ♥ ", fthongtint));                        
                        doc.Add(Thank);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi");
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }
    }
}
