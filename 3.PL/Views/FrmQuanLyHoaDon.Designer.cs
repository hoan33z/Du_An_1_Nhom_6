namespace _3.PL.Views
{
    partial class FrmQuanLyHoaDon
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
            this.dgrid_hoaDon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_hoaDon
            // 
            this.dgrid_hoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hoaDon.Location = new System.Drawing.Point(-1, 109);
            this.dgrid_hoaDon.Name = "dgrid_hoaDon";
            this.dgrid_hoaDon.RowHeadersWidth = 51;
            this.dgrid_hoaDon.RowTemplate.Height = 29;
            this.dgrid_hoaDon.Size = new System.Drawing.Size(800, 338);
            this.dgrid_hoaDon.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "Thống Kê Hóa Đơn";
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(521, 76);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(278, 27);
            this.txt_timKiem.TabIndex = 26;
            // 
            // FrmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_timKiem);
            this.Controls.Add(this.dgrid_hoaDon);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuanLyHoaDon";
            this.Text = "FrmQuanLyHoaDon";
            this.Load += new System.EventHandler(this.FrmQuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_hoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_timKiem;
    }
}