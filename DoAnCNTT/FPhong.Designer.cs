namespace DoAnCNTT
{
    partial class FPhong
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
            this.components = new System.ComponentModel.Container();
            this.them = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.tenphong = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listBoxPhong = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // them
            // 
            this.them.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Location = new System.Drawing.Point(12, 159);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(127, 47);
            this.them.TabIndex = 1;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(12, 246);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(127, 47);
            this.xoa.TabIndex = 2;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.Location = new System.Drawing.Point(197, 159);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(127, 47);
            this.sua.TabIndex = 3;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(197, 245);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(127, 47);
            this.thoat.TabIndex = 4;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // tenphong
            // 
            this.tenphong.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenphong.Location = new System.Drawing.Point(22, 36);
            this.tenphong.Name = "tenphong";
            this.tenphong.Size = new System.Drawing.Size(312, 35);
            this.tenphong.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listBoxPhong
            // 
            this.listBoxPhong.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPhong.FormattingEnabled = true;
            this.listBoxPhong.ItemHeight = 23;
            this.listBoxPhong.Location = new System.Drawing.Point(361, 36);
            this.listBoxPhong.Name = "listBoxPhong";
            this.listBoxPhong.Size = new System.Drawing.Size(362, 257);
            this.listBoxPhong.TabIndex = 7;
            this.listBoxPhong.SelectedIndexChanged += new System.EventHandler(this.listBoxPhong_SelectedIndexChanged);
            // 
            // FPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 305);
            this.Controls.Add(this.listBoxPhong);
            this.Controls.Add(this.tenphong);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Name = "FPhong";
            this.Text = "FPhong";
            this.Load += new System.EventHandler(this.FPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.TextBox tenphong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox listBoxPhong;
    }
}