namespace DoAnCNTT
{
    partial class FThem
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
            this.btThemQl = new System.Windows.Forms.Button();
            this.btThemCN = new System.Windows.Forms.Button();
            this.btThemKS = new System.Windows.Forms.Button();
            this.btThemNV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btThemQl
            // 
            this.btThemQl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemQl.Location = new System.Drawing.Point(104, 33);
            this.btThemQl.Name = "btThemQl";
            this.btThemQl.Size = new System.Drawing.Size(196, 59);
            this.btThemQl.TabIndex = 0;
            this.btThemQl.Text = "Thêm quản lý";
            this.btThemQl.UseVisualStyleBackColor = true;
            this.btThemQl.Click += new System.EventHandler(this.btThemQl_Click);
            // 
            // btThemCN
            // 
            this.btThemCN.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemCN.Location = new System.Drawing.Point(104, 316);
            this.btThemCN.Name = "btThemCN";
            this.btThemCN.Size = new System.Drawing.Size(196, 59);
            this.btThemCN.TabIndex = 6;
            this.btThemCN.Text = "Thêm công nhân";
            this.btThemCN.UseVisualStyleBackColor = true;
            this.btThemCN.Click += new System.EventHandler(this.btThemCN_Click);
            // 
            // btThemKS
            // 
            this.btThemKS.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemKS.Location = new System.Drawing.Point(104, 214);
            this.btThemKS.Name = "btThemKS";
            this.btThemKS.Size = new System.Drawing.Size(196, 59);
            this.btThemKS.TabIndex = 5;
            this.btThemKS.Text = "Thêm kỹ sư";
            this.btThemKS.UseVisualStyleBackColor = true;
            this.btThemKS.Click += new System.EventHandler(this.btThemKS_Click);
            // 
            // btThemNV
            // 
            this.btThemNV.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemNV.Location = new System.Drawing.Point(104, 114);
            this.btThemNV.Name = "btThemNV";
            this.btThemNV.Size = new System.Drawing.Size(196, 59);
            this.btThemNV.TabIndex = 4;
            this.btThemNV.Text = "Thêm nhân viên";
            this.btThemNV.UseVisualStyleBackColor = true;
            this.btThemNV.Click += new System.EventHandler(this.btThemNV_Click);
            // 
            // FThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 428);
            this.Controls.Add(this.btThemCN);
            this.Controls.Add(this.btThemKS);
            this.Controls.Add(this.btThemNV);
            this.Controls.Add(this.btThemQl);
            this.Name = "FThem";
            this.Text = "FThem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btThemQl;
        private System.Windows.Forms.Button btThemCN;
        private System.Windows.Forms.Button btThemKS;
        private System.Windows.Forms.Button btThemNV;
    }
}