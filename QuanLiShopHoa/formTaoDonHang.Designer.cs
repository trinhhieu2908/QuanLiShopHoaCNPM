﻿namespace QuanLiShopHoa
{
    partial class formTaoDonHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTaoDonHang));
            this.listViewSP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtgvProduct = new System.Windows.Forms.DataGridView();
            this.btnGiamGia = new System.Windows.Forms.PictureBox();
            this.btnThanhToan = new System.Windows.Forms.PictureBox();
            this.btnThemSP = new System.Windows.Forms.PictureBox();
            this.numericUpDownThemSP = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBotSP = new System.Windows.Forms.NumericUpDown();
            this.btnBotSP = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconTimSanPham = new FontAwesome.Sharp.IconPictureBox();
            this.panelTimSanPham = new System.Windows.Forms.Panel();
            this.txbTimSanPham = new System.Windows.Forms.TextBox();
            this.flpHoaDonChuaThanhToan = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThemSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBotSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBotSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTimSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewSP
            // 
            this.listViewSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listViewSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewSP.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSP.ForeColor = System.Drawing.Color.White;
            this.listViewSP.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSP.HideSelection = false;
            this.listViewSP.Location = new System.Drawing.Point(805, 76);
            this.listViewSP.Margin = new System.Windows.Forms.Padding(4);
            this.listViewSP.Name = "listViewSP";
            this.listViewSP.Size = new System.Drawing.Size(625, 666);
            this.listViewSP.TabIndex = 1;
            this.listViewSP.UseCompatibleStateImageBehavior = false;
            this.listViewSP.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 245;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SL";
            this.columnHeader3.Width = 56;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thành tiền";
            this.columnHeader5.Width = 138;
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.AllowUserToAddRows = false;
            this.dtgvProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(181)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dtgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(17);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(181)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvProduct.DefaultCellStyle = dataGridViewCellStyle15;
            this.dtgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dtgvProduct.Location = new System.Drawing.Point(111, 76);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgvProduct.RowHeadersVisible = false;
            this.dtgvProduct.RowHeadersWidth = 51;
            this.dtgvProduct.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(181)))), ((int)(((byte)(114)))));
            this.dtgvProduct.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.dtgvProduct.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvProduct.RowTemplate.DividerHeight = 5;
            this.dtgvProduct.RowTemplate.Height = 50;
            this.dtgvProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProduct.Size = new System.Drawing.Size(687, 790);
            this.dtgvProduct.TabIndex = 2;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGiamGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiamGia.Image = ((System.Drawing.Image)(resources.GetObject("btnGiamGia.Image")));
            this.btnGiamGia.Location = new System.Drawing.Point(915, 825);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(159, 47);
            this.btnGiamGia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGiamGia.TabIndex = 29;
            this.btnGiamGia.TabStop = false;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.Image = global::QuanLiShopHoa.Properties.Resources.buttonThanhToan;
            this.btnThanhToan.Location = new System.Drawing.Point(1172, 794);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(258, 78);
            this.btnThanhToan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThanhToan.TabIndex = 28;
            this.btnThanhToan.TabStop = false;
            this.btnThanhToan.MouseLeave += new System.EventHandler(this.btnThanhToan_MouseLeave);
            this.btnThanhToan.MouseHover += new System.EventHandler(this.btnThanhToan_MouseHover);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSP.Image")));
            this.btnThemSP.Location = new System.Drawing.Point(1147, 8);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(170, 58);
            this.btnThemSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThemSP.TabIndex = 30;
            this.btnThemSP.TabStop = false;
            // 
            // numericUpDownThemSP
            // 
            this.numericUpDownThemSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownThemSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.numericUpDownThemSP.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownThemSP.ForeColor = System.Drawing.Color.White;
            this.numericUpDownThemSP.Location = new System.Drawing.Point(1334, 15);
            this.numericUpDownThemSP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownThemSP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownThemSP.Name = "numericUpDownThemSP";
            this.numericUpDownThemSP.Size = new System.Drawing.Size(96, 45);
            this.numericUpDownThemSP.TabIndex = 33;
            this.numericUpDownThemSP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownBotSP
            // 
            this.numericUpDownBotSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownBotSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.numericUpDownBotSP.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBotSP.ForeColor = System.Drawing.Color.White;
            this.numericUpDownBotSP.Location = new System.Drawing.Point(996, 16);
            this.numericUpDownBotSP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownBotSP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBotSP.Name = "numericUpDownBotSP";
            this.numericUpDownBotSP.Size = new System.Drawing.Size(96, 45);
            this.numericUpDownBotSP.TabIndex = 34;
            this.numericUpDownBotSP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBotSP
            // 
            this.btnBotSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBotSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBotSP.Image = ((System.Drawing.Image)(resources.GetObject("btnBotSP.Image")));
            this.btnBotSP.Location = new System.Drawing.Point(807, 8);
            this.btnBotSP.Name = "btnBotSP";
            this.btnBotSP.Size = new System.Drawing.Size(170, 58);
            this.btnBotSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBotSP.TabIndex = 35;
            this.btnBotSP.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1121, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 80);
            this.panel1.TabIndex = 36;
            // 
            // iconTimSanPham
            // 
            this.iconTimSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconTimSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.iconTimSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(189)))), ((int)(((byte)(144)))));
            this.iconTimSanPham.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconTimSanPham.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(189)))), ((int)(((byte)(144)))));
            this.iconTimSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTimSanPham.IconSize = 34;
            this.iconTimSanPham.Location = new System.Drawing.Point(762, 26);
            this.iconTimSanPham.Name = "iconTimSanPham";
            this.iconTimSanPham.Size = new System.Drawing.Size(34, 34);
            this.iconTimSanPham.TabIndex = 28;
            this.iconTimSanPham.TabStop = false;
            // 
            // panelTimSanPham
            // 
            this.panelTimSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTimSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(189)))), ((int)(((byte)(144)))));
            this.panelTimSanPham.Location = new System.Drawing.Point(396, 64);
            this.panelTimSanPham.Name = "panelTimSanPham";
            this.panelTimSanPham.Size = new System.Drawing.Size(401, 1);
            this.panelTimSanPham.TabIndex = 27;
            // 
            // txbTimSanPham
            // 
            this.txbTimSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTimSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txbTimSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTimSanPham.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(189)))), ((int)(((byte)(144)))));
            this.txbTimSanPham.HideSelection = false;
            this.txbTimSanPham.Location = new System.Drawing.Point(401, 26);
            this.txbTimSanPham.Name = "txbTimSanPham";
            this.txbTimSanPham.Size = new System.Drawing.Size(353, 34);
            this.txbTimSanPham.TabIndex = 26;
            this.txbTimSanPham.Text = "Tìm sản phẩm";
            // 
            // flpHoaDonChuaThanhToan
            // 
            this.flpHoaDonChuaThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpHoaDonChuaThanhToan.AutoScroll = true;
            this.flpHoaDonChuaThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.flpHoaDonChuaThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpHoaDonChuaThanhToan.ForeColor = System.Drawing.Color.White;
            this.flpHoaDonChuaThanhToan.Location = new System.Drawing.Point(13, 76);
            this.flpHoaDonChuaThanhToan.Name = "flpHoaDonChuaThanhToan";
            this.flpHoaDonChuaThanhToan.Size = new System.Drawing.Size(90, 790);
            this.flpHoaDonChuaThanhToan.TabIndex = 37;
            // 
            // formTaoDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1445, 884);
            this.Controls.Add(this.flpHoaDonChuaThanhToan);
            this.Controls.Add(this.iconTimSanPham);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTimSanPham);
            this.Controls.Add(this.txbTimSanPham);
            this.Controls.Add(this.btnBotSP);
            this.Controls.Add(this.numericUpDownBotSP);
            this.Controls.Add(this.numericUpDownThemSP);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.btnGiamGia);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dtgvProduct);
            this.Controls.Add(this.listViewSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formTaoDonHang";
            this.Text = "formTaoDonHang";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThemSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBotSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBotSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTimSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewSP;
        private System.Windows.Forms.DataGridView dtgvProduct;
        private System.Windows.Forms.PictureBox btnThanhToan;
        private System.Windows.Forms.PictureBox btnGiamGia;
        private System.Windows.Forms.PictureBox btnThemSP;
        private System.Windows.Forms.NumericUpDown numericUpDownThemSP;
        private System.Windows.Forms.NumericUpDown numericUpDownBotSP;
        private System.Windows.Forms.PictureBox btnBotSP;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconTimSanPham;
        private System.Windows.Forms.Panel panelTimSanPham;
        private System.Windows.Forms.TextBox txbTimSanPham;
        private System.Windows.Forms.FlowLayoutPanel flpHoaDonChuaThanhToan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}