﻿namespace _3.PL.Views
{
    partial class FrmSanPham
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgridSanPham = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSanPham = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgridSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgridSanPham
            // 
            this.dgridSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgridSanPham.Location = new System.Drawing.Point(0, 85);
            this.dgridSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgridSanPham.Name = "dgridSanPham";
            this.dgridSanPham.RowHeadersWidth = 51;
            this.dgridSanPham.RowTemplate.Height = 29;
            this.dgridSanPham.Size = new System.Drawing.Size(345, 167);
            this.dgridSanPham.TabIndex = 1;
            this.dgridSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridSanPham_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "TenSp";
            // 
            // txtSanPham
            // 
            this.txtSanPham.Location = new System.Drawing.Point(82, 6);
            this.txtSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Size = new System.Drawing.Size(257, 31);
            this.txtSanPham.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 45);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 45);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 252);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSanPham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgridSanPham);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSanPham";
            this.Text = "SanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dgridSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgridSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSanPham;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}