﻿namespace _3.PL.Views
{
    partial class FrmLoaiTk
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTenLoaiTk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgridLoaiTk = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgridLoaiTk)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 41);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 35);
            this.button3.TabIndex = 18;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 41);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTenLoaiTk
            // 
            this.txtTenLoaiTk.Location = new System.Drawing.Point(117, 2);
            this.txtTenLoaiTk.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLoaiTk.Name = "txtTenLoaiTk";
            this.txtTenLoaiTk.Size = new System.Drawing.Size(222, 31);
            this.txtTenLoaiTk.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "TenLoaiTk";
            // 
            // dgridLoaiTk
            // 
            this.dgridLoaiTk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridLoaiTk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgridLoaiTk.Location = new System.Drawing.Point(0, 84);
            this.dgridLoaiTk.Margin = new System.Windows.Forms.Padding(4);
            this.dgridLoaiTk.Name = "dgridLoaiTk";
            this.dgridLoaiTk.RowHeadersWidth = 51;
            this.dgridLoaiTk.RowTemplate.Height = 29;
            this.dgridLoaiTk.Size = new System.Drawing.Size(346, 167);
            this.dgridLoaiTk.TabIndex = 14;
            this.dgridLoaiTk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridLoaiTk_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLoaiTk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 251);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTenLoaiTk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgridLoaiTk);
            this.Controls.Add(this.button1);
            this.Name = "FrmLoaiTk";
            this.Text = "FrmLoaiTk";
            ((System.ComponentModel.ISupportInitialize)(this.dgridLoaiTk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTenLoaiTk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgridLoaiTk;
        private System.Windows.Forms.Button button1;
    }
}