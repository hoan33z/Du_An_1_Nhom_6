namespace _3.PL.Views
{
    partial class FrmThongKeDoanhThu
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
            this.btn_thongKe = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_denNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_tuNgay = new System.Windows.Forms.DateTimePicker();
            this.dgrid_doanhThu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_doanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_thongKe
            // 
            this.btn_thongKe.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_thongKe.Location = new System.Drawing.Point(635, 112);
            this.btn_thongKe.Name = "btn_thongKe";
            this.btn_thongKe.Size = new System.Drawing.Size(126, 29);
            this.btn_thongKe.TabIndex = 40;
            this.btn_thongKe.Text = "Thống kê";
            this.btn_thongKe.UseVisualStyleBackColor = true;
            this.btn_thongKe.Click += new System.EventHandler(this.btn_thongKe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Sản Phẩm";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 28);
            this.comboBox1.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(344, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Đến ngày";
            // 
            // dt_denNgay
            // 
            this.dt_denNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_denNgay.Location = new System.Drawing.Point(460, 114);
            this.dt_denNgay.Name = "dt_denNgay";
            this.dt_denNgay.Size = new System.Drawing.Size(150, 27);
            this.dt_denNgay.TabIndex = 36;
            this.dt_denNgay.ValueChanged += new System.EventHandler(this.dt_denNgay_ValueChanged);
            this.dt_denNgay.Leave += new System.EventHandler(this.dt_denNgay_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Từ Ngày";
            // 
            // dt_tuNgay
            // 
            this.dt_tuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_tuNgay.Location = new System.Drawing.Point(142, 112);
            this.dt_tuNgay.Name = "dt_tuNgay";
            this.dt_tuNgay.Size = new System.Drawing.Size(150, 27);
            this.dt_tuNgay.TabIndex = 34;
            this.dt_tuNgay.ValueChanged += new System.EventHandler(this.dt_tuNgay_ValueChanged);
            this.dt_tuNgay.Leave += new System.EventHandler(this.dt_tuNgay_Leave);
            // 
            // dgrid_doanhThu
            // 
            this.dgrid_doanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_doanhThu.Location = new System.Drawing.Point(0, 157);
            this.dgrid_doanhThu.Name = "dgrid_doanhThu";
            this.dgrid_doanhThu.RowHeadersWidth = 51;
            this.dgrid_doanhThu.RowTemplate.Height = 29;
            this.dgrid_doanhThu.Size = new System.Drawing.Size(800, 299);
            this.dgrid_doanhThu.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(254, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Thống Kê Doanh Thu";
            // 
            // FrmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thongKe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt_denNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_tuNgay);
            this.Controls.Add(this.dgrid_doanhThu);
            this.Controls.Add(this.label1);
            this.Name = "FrmThongKeDoanhThu";
            this.Text = "FrmThongKeDoanhThu";
            this.Load += new System.EventHandler(this.FrmThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_doanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thongKe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_denNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_tuNgay;
        private System.Windows.Forms.DataGridView dgrid_doanhThu;
        private System.Windows.Forms.Label label1;
    }
}