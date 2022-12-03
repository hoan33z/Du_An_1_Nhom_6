namespace _3.PL.Views
{
    partial class FrmLogin
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
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.cbx_ghiNhoTk = new System.Windows.Forms.CheckBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbHienMK.Location = new System.Drawing.Point(470, 256);
            this.cbHienMK.Margin = new System.Windows.Forms.Padding(4);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(190, 34);
            this.cbHienMK.TabIndex = 15;
            this.cbHienMK.Text = "Hiện mật khẩu";
            this.cbHienMK.UseVisualStyleBackColor = true;
            this.cbHienMK.CheckedChanged += new System.EventHandler(this.cbHienMK_CheckedChanged);
            // 
            // cbx_ghiNhoTk
            // 
            this.cbx_ghiNhoTk.AutoSize = true;
            this.cbx_ghiNhoTk.Location = new System.Drawing.Point(78, 256);
            this.cbx_ghiNhoTk.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_ghiNhoTk.Name = "cbx_ghiNhoTk";
            this.cbx_ghiNhoTk.Size = new System.Drawing.Size(185, 34);
            this.cbx_ghiNhoTk.TabIndex = 14;
            this.cbx_ghiNhoTk.Text = "Nhớ tài khoản";
            this.cbx_ghiNhoTk.UseVisualStyleBackColor = true;
            // 
            // txt_mk
            // 
            this.txt_mk.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_mk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_mk.Location = new System.Drawing.Point(78, 179);
            this.txt_mk.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mk.Multiline = true;
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(582, 51);
            this.txt_mk.TabIndex = 13;
            this.txt_mk.Text = "Mật Khẩu";
            this.txt_mk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_mk_MouseClick);
            this.txt_mk.TextChanged += new System.EventHandler(this.txt_mk_TextChanged);
            // 
            // txt_tk
            // 
            this.txt_tk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tk.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_tk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tk.Location = new System.Drawing.Point(78, 111);
            this.txt_tk.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tk.Multiline = true;
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(582, 60);
            this.txt_tk.TabIndex = 12;
            this.txt_tk.Text = "Tài Khoản";
            this.txt_tk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_tk_MouseClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(191, 298);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 64);
            this.button1.TabIndex = 11;
            this.button1.Text = "Đăng Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 402);
            this.Controls.Add(this.cbHienMK);
            this.Controls.Add(this.cbx_ghiNhoTk);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbHienMK;
        private System.Windows.Forms.CheckBox cbx_ghiNhoTk;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Button button1;
    }
}