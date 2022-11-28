namespace _3.PL.Views
{
    partial class FrmThanhToan
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgridHoaDon = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.rbtnKhong = new System.Windows.Forms.RadioButton();
            this.rbtnCo = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhanVienTT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgridGioHang = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridGioHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgridHoaDon);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(779, 259);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hóa Đơn";
            // 
            // dgridHoaDon
            // 
            this.dgridHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridHoaDon.Location = new System.Drawing.Point(3, 30);
            this.dgridHoaDon.Name = "dgridHoaDon";
            this.dgridHoaDon.RowHeadersWidth = 62;
            this.dgridHoaDon.RowTemplate.Height = 33;
            this.dgridHoaDon.Size = new System.Drawing.Size(773, 226);
            this.dgridHoaDon.TabIndex = 0;
            this.dgridHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridHoaDon_CellClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThanhToan.Location = new System.Drawing.Point(3, 443);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(542, 58);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.rbtnKhong);
            this.groupBox1.Controls.Add(this.rbtnCo);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNhanVienTT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnThanhToan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(985, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 504);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Toán";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(200, 343);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(336, 39);
            this.txtTongTien.TabIndex = 14;
            // 
            // rbtnKhong
            // 
            this.rbtnKhong.AutoSize = true;
            this.rbtnKhong.Location = new System.Drawing.Point(275, 268);
            this.rbtnKhong.Name = "rbtnKhong";
            this.rbtnKhong.Size = new System.Drawing.Size(114, 36);
            this.rbtnKhong.TabIndex = 13;
            this.rbtnKhong.Text = "Không";
            this.rbtnKhong.UseVisualStyleBackColor = true;
            // 
            // rbtnCo
            // 
            this.rbtnCo.AutoSize = true;
            this.rbtnCo.Checked = true;
            this.rbtnCo.Location = new System.Drawing.Point(200, 268);
            this.rbtnCo.Name = "rbtnCo";
            this.rbtnCo.Size = new System.Drawing.Size(69, 36);
            this.rbtnCo.TabIndex = 12;
            this.rbtnCo.TabStop = true;
            this.rbtnCo.Text = "Có";
            this.rbtnCo.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(336, 39);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(200, 115);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(336, 39);
            this.txtTenKH.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phí Giao Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // txtNhanVienTT
            // 
            this.txtNhanVienTT.Location = new System.Drawing.Point(200, 39);
            this.txtNhanVienTT.Name = "txtNhanVienTT";
            this.txtNhanVienTT.Size = new System.Drawing.Size(336, 39);
            this.txtNhanVienTT.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "NV Thanh Toán";
            // 
            // dgridGioHang
            // 
            this.dgridGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridGioHang.Location = new System.Drawing.Point(15, 274);
            this.dgridGioHang.Name = "dgridGioHang";
            this.dgridGioHang.RowHeadersWidth = 62;
            this.dgridGioHang.Size = new System.Drawing.Size(964, 225);
            this.dgridGioHang.TabIndex = 5;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.Location = new System.Drawing.Point(6, 33);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(178, 44);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy Hóa Đơn";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuayLai);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Location = new System.Drawing.Point(797, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 259);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuayLai.Location = new System.Drawing.Point(4, 83);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(178, 44);
            this.btnQuayLai.TabIndex = 9;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // FrmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1533, 504);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgridGioHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "FrmThanhToan";
            this.Text = "FormHoaDon";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridGioHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgridHoaDon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhanVienTT;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.RadioButton rbtnKhong;
        private System.Windows.Forms.RadioButton rbtnCo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.DataGridView dgridGioHang;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQuayLai;
    }
}