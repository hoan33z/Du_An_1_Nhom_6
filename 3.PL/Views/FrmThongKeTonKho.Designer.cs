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
            this.dgrid_TonKho = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_TonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_TonKho
            // 
            this.dgrid_TonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_TonKho.Location = new System.Drawing.Point(0, 98);
            this.dgrid_TonKho.Name = "dgrid_TonKho";
            this.dgrid_TonKho.RowHeadersWidth = 51;
            this.dgrid_TonKho.RowTemplate.Height = 29;
            this.dgrid_TonKho.Size = new System.Drawing.Size(800, 338);
            this.dgrid_TonKho.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(206, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "Thống kê sản phẩm tồn kho";
            // 
            // FrmThongKeTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgrid_TonKho);
            this.Controls.Add(this.label1);
            this.Name = "FrmThongKeTonKho";
            this.Text = "FrmThongKeTonKho";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_TonKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_TonKho;
        private System.Windows.Forms.Label label1;
    }
}