namespace _3.PL.Views
{
    partial class FrmThongKeTonKho
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_danhMuc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_loaiSp = new System.Windows.Forms.ComboBox();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.dgrid_TonKho = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_TonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Danh Mục";
            // 
            // cbx_danhMuc
            // 
            this.cbx_danhMuc.FormattingEnabled = true;
            this.cbx_danhMuc.Location = new System.Drawing.Point(337, 110);
            this.cbx_danhMuc.Name = "cbx_danhMuc";
            this.cbx_danhMuc.Size = new System.Drawing.Size(181, 28);
            this.cbx_danhMuc.TabIndex = 34;
            this.cbx_danhMuc.SelectedIndexChanged += new System.EventHandler(this.cbx_danhMuc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Loại sản phẩm";
            // 
            // cbx_loaiSp
            // 
            this.cbx_loaiSp.FormattingEnabled = true;
            this.cbx_loaiSp.Location = new System.Drawing.Point(646, 110);
            this.cbx_loaiSp.Name = "cbx_loaiSp";
            this.cbx_loaiSp.Size = new System.Drawing.Size(181, 28);
            this.cbx_loaiSp.TabIndex = 32;
            this.cbx_loaiSp.SelectedIndexChanged += new System.EventHandler(this.cbx_loaiSp_SelectedIndexChanged);
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(40, 111);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(175, 27);
            this.txt_timKiem.TabIndex = 31;
            this.txt_timKiem.TextChanged += new System.EventHandler(this.txt_timKiem_TextChanged);
            // 
            // dgrid_TonKho
            // 
            this.dgrid_TonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_TonKho.Location = new System.Drawing.Point(4, 144);
            this.dgrid_TonKho.Name = "dgrid_TonKho";
            this.dgrid_TonKho.RowHeadersWidth = 51;
            this.dgrid_TonKho.RowTemplate.Height = 29;
            this.dgrid_TonKho.Size = new System.Drawing.Size(881, 338);
            this.dgrid_TonKho.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(245, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 38);
            this.label1.TabIndex = 29;
            this.label1.Text = "Thống kê sản phẩm tồn kho";
            // 
            // FrmThongKeTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 528);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_danhMuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_loaiSp);
            this.Controls.Add(this.txt_timKiem);
            this.Controls.Add(this.dgrid_TonKho);
            this.Controls.Add(this.label1);
            this.Name = "FrmThongKeTonKho";
            this.Text = "FrmThongKeTonKho";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_TonKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_danhMuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_loaiSp;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.DataGridView dgrid_TonKho;
        private System.Windows.Forms.Label label1;
    }
}