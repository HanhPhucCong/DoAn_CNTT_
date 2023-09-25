namespace DoAnCNTT
{
    partial class FDangNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.tMatKhau = new System.Windows.Forms.TextBox();
            this.tTaiKhoan = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // tMatKhau
            // 
            this.tMatKhau.Location = new System.Drawing.Point(228, 111);
            this.tMatKhau.Multiline = true;
            this.tMatKhau.Name = "tMatKhau";
            this.tMatKhau.Size = new System.Drawing.Size(191, 26);
            this.tMatKhau.TabIndex = 5;
            // 
            // tTaiKhoan
            // 
            this.tTaiKhoan.Location = new System.Drawing.Point(228, 47);
            this.tTaiKhoan.Multiline = true;
            this.tTaiKhoan.Name = "tTaiKhoan";
            this.tTaiKhoan.Size = new System.Drawing.Size(191, 26);
            this.tTaiKhoan.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(437, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Hiển thị mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btDangNhap
            // 
            this.btDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.Location = new System.Drawing.Point(56, 233);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(161, 39);
            this.btDangNhap.TabIndex = 8;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(385, 233);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(161, 39);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // FDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 296);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tTaiKhoan);
            this.Controls.Add(this.tMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FDangNhap";
            this.Text = "Fdangnhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tMatKhau;
        private System.Windows.Forms.TextBox tTaiKhoan;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btThoat;
    }
}