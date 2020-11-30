namespace QuanLiShopHoa
{
    partial class formQuanLiDonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuanLiDonHang));
            this.dtgvCheckedBill = new System.Windows.Forms.DataGridView();
            this.dateTimeHoaDon = new System.Windows.Forms.DateTimePicker();
            this.listViewSP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.lbHDDangChon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCheckedBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXem)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCheckedBill
            // 
            this.dtgvCheckedBill.AllowUserToAddRows = false;
            this.dtgvCheckedBill.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(181)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvCheckedBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvCheckedBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvCheckedBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvCheckedBill.BackgroundColor = System.Drawing.Color.White;
            this.dtgvCheckedBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvCheckedBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvCheckedBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(17);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCheckedBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvCheckedBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(181)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCheckedBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvCheckedBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dtgvCheckedBill.Location = new System.Drawing.Point(33, 93);
            this.dtgvCheckedBill.Name = "dtgvCheckedBill";
            this.dtgvCheckedBill.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCheckedBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvCheckedBill.RowHeadersVisible = false;
            this.dtgvCheckedBill.RowHeadersWidth = 51;
            this.dtgvCheckedBill.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(181)))), ((int)(((byte)(114)))));
            this.dtgvCheckedBill.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvCheckedBill.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.dtgvCheckedBill.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvCheckedBill.RowTemplate.DividerHeight = 5;
            this.dtgvCheckedBill.RowTemplate.Height = 50;
            this.dtgvCheckedBill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCheckedBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCheckedBill.Size = new System.Drawing.Size(719, 758);
            this.dtgvCheckedBill.TabIndex = 3;
            // 
            // dateTimeHoaDon
            // 
            this.dateTimeHoaDon.AllowDrop = true;
            this.dateTimeHoaDon.CalendarFont = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeHoaDon.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimeHoaDon.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(245)))), ((int)(((byte)(91)))));
            this.dateTimeHoaDon.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(245)))), ((int)(((byte)(91)))));
            this.dateTimeHoaDon.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimeHoaDon.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dateTimeHoaDon.Checked = false;
            this.dateTimeHoaDon.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeHoaDon.Location = new System.Drawing.Point(574, 28);
            this.dateTimeHoaDon.Name = "dateTimeHoaDon";
            this.dateTimeHoaDon.Size = new System.Drawing.Size(384, 36);
            this.dateTimeHoaDon.TabIndex = 23;
            this.dateTimeHoaDon.Value = new System.DateTime(2020, 11, 11, 0, 0, 0, 0);
            this.dateTimeHoaDon.ValueChanged += new System.EventHandler(this.dateTimeHoaDon_ValueChanged);
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
            this.listViewSP.Location = new System.Drawing.Point(784, 145);
            this.listViewSP.Margin = new System.Windows.Forms.Padding(4);
            this.listViewSP.Name = "listViewSP";
            this.listViewSP.Size = new System.Drawing.Size(625, 650);
            this.listViewSP.TabIndex = 24;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1031, 816);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 35);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tổng tiền:";
            // 
            // txbTongTien
            // 
            this.txbTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTongTien.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongTien.ForeColor = System.Drawing.Color.White;
            this.txbTongTien.HideSelection = false;
            this.txbTongTien.Location = new System.Drawing.Point(1163, 821);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(246, 33);
            this.txbTongTien.TabIndex = 40;
            this.txbTongTien.Text = "0";
            this.txbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbHDDangChon
            // 
            this.lbHDDangChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbHDDangChon.AutoSize = true;
            this.lbHDDangChon.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHDDangChon.ForeColor = System.Drawing.Color.White;
            this.lbHDDangChon.Location = new System.Drawing.Point(1215, 93);
            this.lbHDDangChon.Name = "lbHDDangChon";
            this.lbHDDangChon.Size = new System.Drawing.Size(25, 29);
            this.lbHDDangChon.TabIndex = 43;
            this.lbHDDangChon.Text = "0";
            this.lbHDDangChon.TextChanged += new System.EventHandler(this.lbHDDangChon_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(896, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "Đơn hàng đang chọn:";
            // 
            // btnXem
            // 
            this.btnXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.Location = new System.Drawing.Point(825, 813);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(159, 47);
            this.btnXem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnXem.TabIndex = 44;
            this.btnXem.TabStop = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // formQuanLiDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1446, 888);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.lbHDDangChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTongTien);
            this.Controls.Add(this.listViewSP);
            this.Controls.Add(this.dateTimeHoaDon);
            this.Controls.Add(this.dtgvCheckedBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formQuanLiDonHang";
            this.Text = "formQuanLiDonHang";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCheckedBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCheckedBill;
        private System.Windows.Forms.DateTimePicker dateTimeHoaDon;
        private System.Windows.Forms.ListView listViewSP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Label lbHDDangChon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnXem;
    }
}