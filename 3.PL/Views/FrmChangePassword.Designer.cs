﻿
namespace _3_GUI_Layer
{
    partial class FrmChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.txtPassNew2 = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(180, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi Mật Khẩu";
            this.label1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox1.Location = new System.Drawing.Point(20, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMail.Location = new System.Drawing.Point(41, 180);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(76, 32);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Email";
            this.lblMail.UseWaitCursor = true;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMatKhau.Location = new System.Drawing.Point(41, 256);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(155, 32);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật khẩu cũ";
            this.lblMatKhau.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 409);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập lại mật khẩu mới :";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 332);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới :";
            this.label3.UseWaitCursor = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(41, 219);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(429, 31);
            this.txtMail.TabIndex = 1;
            this.txtMail.UseWaitCursor = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(41, 295);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(429, 31);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseWaitCursor = true;
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(41, 371);
            this.txtPassNew.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.PasswordChar = 'x';
            this.txtPassNew.Size = new System.Drawing.Size(429, 31);
            this.txtPassNew.TabIndex = 3;
            this.txtPassNew.UseWaitCursor = true;
            // 
            // txtPassNew2
            // 
            this.txtPassNew2.Location = new System.Drawing.Point(41, 448);
            this.txtPassNew2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassNew2.Name = "txtPassNew2";
            this.txtPassNew2.PasswordChar = 'x';
            this.txtPassNew2.Size = new System.Drawing.Size(429, 31);
            this.txtPassNew2.TabIndex = 4;
            this.txtPassNew2.UseWaitCursor = true;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(296, 544);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(175, 54);
            this.btnChangePass.TabIndex = 5;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.UseWaitCursor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.Location = new System.Drawing.Point(48, 502);
            this.cbHienMK.Margin = new System.Windows.Forms.Padding(4);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(153, 29);
            this.cbHienMK.TabIndex = 7;
            this.cbHienMK.Text = "Hiện mật khẩu";
            this.cbHienMK.UseVisualStyleBackColor = true;
            this.cbHienMK.UseWaitCursor = true;
            this.cbHienMK.CheckedChanged += new System.EventHandler(this.cbHienMK_CheckedChanged);
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 601);
            this.Controls.Add(this.cbHienMK);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.txtPassNew2);
            this.Controls.Add(this.txtPassNew);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmChangePassword";
            this.Text = "Đổi Mật Khẩu";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.TextBox txtPassNew2;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.CheckBox cbHienMK;
    }
}