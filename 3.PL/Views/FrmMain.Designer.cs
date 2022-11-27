namespace _3.PL.Views
{
    partial class FrmMain
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
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.loadForm = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_heThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_myInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DoiMk = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_quanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.qlNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.qlSanPhamCT = new System.Windows.Forms.ToolStripMenuItem();
            this.QLHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.QLLoaiSp = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNhaCC = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_thongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongKeDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_thongkeTonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // loadForm
            // 
            this.loadForm.Location = new System.Drawing.Point(0, 31);
            this.loadForm.Name = "loadForm";
            this.loadForm.Size = new System.Drawing.Size(1417, 542);
            this.loadForm.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_heThong,
            this.menu_quanLy,
            this.menu_thongKe,
            this.quảnLýBánHàngToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.thanhToánToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1417, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_heThong
            // 
            this.menu_heThong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu_heThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_myInfor,
            this.menu_DoiMk,
            this.DangXuat});
            this.menu_heThong.Name = "menu_heThong";
            this.menu_heThong.Size = new System.Drawing.Size(85, 24);
            this.menu_heThong.Text = "Hệ thống";
            // 
            // menu_myInfor
            // 
            this.menu_myInfor.Name = "menu_myInfor";
            this.menu_myInfor.Size = new System.Drawing.Size(204, 26);
            this.menu_myInfor.Text = "Thông tin của tôi";
            this.menu_myInfor.Click += new System.EventHandler(this.menu_myInfor_Click);
            // 
            // menu_DoiMk
            // 
            this.menu_DoiMk.Name = "menu_DoiMk";
            this.menu_DoiMk.Size = new System.Drawing.Size(204, 26);
            this.menu_DoiMk.Text = "Đổi mật khẩu";
            this.menu_DoiMk.Click += new System.EventHandler(this.menu_DoiMk_Click);
            // 
            // DangXuat
            // 
            this.DangXuat.Name = "DangXuat";
            this.DangXuat.Size = new System.Drawing.Size(204, 26);
            this.DangXuat.Text = "Đăng xuất";
            // 
            // menu_quanLy
            // 
            this.menu_quanLy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu_quanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qlNhanVien,
            this.qlSanPhamCT,
            this.QLHoaDon,
            this.QLLoaiSp,
            this.QLNhaCC,
            this.loạiSảnPhẩmToolStripMenuItem});
            this.menu_quanLy.Name = "menu_quanLy";
            this.menu_quanLy.Size = new System.Drawing.Size(73, 24);
            this.menu_quanLy.Text = "Quản lý";
            // 
            // qlNhanVien
            // 
            this.qlNhanVien.Name = "qlNhanVien";
            this.qlNhanVien.Size = new System.Drawing.Size(224, 26);
            this.qlNhanVien.Text = "Nhân Viên";
            this.qlNhanVien.Click += new System.EventHandler(this.qlNhanVien_Click);
            // 
            // qlSanPhamCT
            // 
            this.qlSanPhamCT.Name = "qlSanPhamCT";
            this.qlSanPhamCT.Size = new System.Drawing.Size(224, 26);
            this.qlSanPhamCT.Text = "Chi Tiết Sản Phẩm";
            this.qlSanPhamCT.Click += new System.EventHandler(this.qlSanPhamCT_Click);
            // 
            // QLHoaDon
            // 
            this.QLHoaDon.Name = "QLHoaDon";
            this.QLHoaDon.Size = new System.Drawing.Size(224, 26);
            this.QLHoaDon.Text = "Hóa Đơn";
            // 
            // QLLoaiSp
            // 
            this.QLLoaiSp.Name = "QLLoaiSp";
            this.QLLoaiSp.Size = new System.Drawing.Size(224, 26);
            this.QLLoaiSp.Text = "Sản Phẩm";
            this.QLLoaiSp.Click += new System.EventHandler(this.QLLoaiSp_Click);
            // 
            // QLNhaCC
            // 
            this.QLNhaCC.Name = "QLNhaCC";
            this.QLNhaCC.Size = new System.Drawing.Size(224, 26);
            this.QLNhaCC.Text = "Nhà Cung Cấp";
            // 
            // loạiSảnPhẩmToolStripMenuItem
            // 
            this.loạiSảnPhẩmToolStripMenuItem.Name = "loạiSảnPhẩmToolStripMenuItem";
            this.loạiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loạiSảnPhẩmToolStripMenuItem.Text = "Loại Sản Phẩm";
            this.loạiSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.loạiSảnPhẩmToolStripMenuItem_Click);
            // 
            // menu_thongKe
            // 
            this.menu_thongKe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu_thongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThongKeDoanhThu,
            this.menu_thongkeTonKho});
            this.menu_thongKe.Name = "menu_thongKe";
            this.menu_thongKe.Size = new System.Drawing.Size(84, 24);
            this.menu_thongKe.Text = "Thống kê";
            // 
            // ThongKeDoanhThu
            // 
            this.ThongKeDoanhThu.Name = "ThongKeDoanhThu";
            this.ThongKeDoanhThu.Size = new System.Drawing.Size(274, 26);
            this.ThongKeDoanhThu.Text = "Thống kê doanh thu";
            this.ThongKeDoanhThu.Click += new System.EventHandler(this.ThongKeDoanhThu_Click);
            // 
            // menu_thongkeTonKho
            // 
            this.menu_thongkeTonKho.Name = "menu_thongkeTonKho";
            this.menu_thongkeTonKho.Size = new System.Drawing.Size(274, 26);
            this.menu_thongkeTonKho.Text = "Số lượng sản phẩm tồn kho";
            this.menu_thongkeTonKho.Click += new System.EventHandler(this.menu_thongkeTonKho_Click);
            // 
            // quảnLýBánHàngToolStripMenuItem
            // 
            this.quảnLýBánHàngToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quảnLýBánHàngToolStripMenuItem.Name = "quảnLýBánHàngToolStripMenuItem";
            this.quảnLýBánHàngToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.quảnLýBánHàngToolStripMenuItem.Text = "Quản Lý Bán Hàng";
            this.quảnLýBánHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýBánHàngToolStripMenuItem_Click);
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            this.quảnLýKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // thanhToánToolStripMenuItem1
            // 
            this.thanhToánToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.thanhToánToolStripMenuItem1.Name = "thanhToánToolStripMenuItem1";
            this.thanhToánToolStripMenuItem1.Size = new System.Drawing.Size(99, 24);
            this.thanhToánToolStripMenuItem1.Text = "Thanh Toán";
            this.thanhToánToolStripMenuItem1.Click += new System.EventHandler(this.thanhToánToolStripMenuItem1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1417, 573);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.loadForm);
            this.Name = "FrmMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        public System.Windows.Forms.Panel loadForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_heThong;
        private System.Windows.Forms.ToolStripMenuItem menu_myInfor;
        private System.Windows.Forms.ToolStripMenuItem menu_DoiMk;
        private System.Windows.Forms.ToolStripMenuItem DangXuat;
        private System.Windows.Forms.ToolStripMenuItem menu_quanLy;
        private System.Windows.Forms.ToolStripMenuItem qlNhanVien;
        private System.Windows.Forms.ToolStripMenuItem qlSanPhamCT;
        private System.Windows.Forms.ToolStripMenuItem menu_thongKe;
        private System.Windows.Forms.ToolStripMenuItem ThongKeDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem menu_thongkeTonKho;
        private System.Windows.Forms.ToolStripMenuItem QLHoaDon;
        private System.Windows.Forms.ToolStripMenuItem QLLoaiSp;
        private System.Windows.Forms.ToolStripMenuItem QLNhaCC;
        private System.Windows.Forms.ToolStripMenuItem loạiSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem1;
    }
}