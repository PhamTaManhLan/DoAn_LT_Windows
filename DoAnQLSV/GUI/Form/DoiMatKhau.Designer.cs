namespace GUI
{
    partial class frm_DoiMatKhau
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
            this.lbl_MkHienTai = new System.Windows.Forms.Label();
            this.txt_MkHienTai = new System.Windows.Forms.TextBox();
            this.txt_MkMoi = new System.Windows.Forms.TextBox();
            this.lbl_MkMoi = new System.Windows.Forms.Label();
            this.txt_XacNhanMk = new System.Windows.Forms.TextBox();
            this.lbl_XacNhan = new System.Windows.Forms.Label();
            this.btn_DoiMatKhau = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_MkHienTai
            // 
            this.lbl_MkHienTai.AutoSize = true;
            this.lbl_MkHienTai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MkHienTai.Location = new System.Drawing.Point(67, 44);
            this.lbl_MkHienTai.Name = "lbl_MkHienTai";
            this.lbl_MkHienTai.Size = new System.Drawing.Size(159, 23);
            this.lbl_MkHienTai.TabIndex = 0;
            this.lbl_MkHienTai.Text = "Mật khẩu hiện tại";
            // 
            // txt_MkHienTai
            // 
            this.txt_MkHienTai.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MkHienTai.Location = new System.Drawing.Point(106, 73);
            this.txt_MkHienTai.Name = "txt_MkHienTai";
            this.txt_MkHienTai.Size = new System.Drawing.Size(294, 34);
            this.txt_MkHienTai.TabIndex = 1;
            // 
            // txt_MkMoi
            // 
            this.txt_MkMoi.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MkMoi.Location = new System.Drawing.Point(106, 168);
            this.txt_MkMoi.Name = "txt_MkMoi";
            this.txt_MkMoi.Size = new System.Drawing.Size(294, 34);
            this.txt_MkMoi.TabIndex = 3;
            // 
            // lbl_MkMoi
            // 
            this.lbl_MkMoi.AutoSize = true;
            this.lbl_MkMoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MkMoi.Location = new System.Drawing.Point(67, 139);
            this.lbl_MkMoi.Name = "lbl_MkMoi";
            this.lbl_MkMoi.Size = new System.Drawing.Size(130, 23);
            this.lbl_MkMoi.TabIndex = 2;
            this.lbl_MkMoi.Text = "Mật khẩu mới";
            // 
            // txt_XacNhanMk
            // 
            this.txt_XacNhanMk.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_XacNhanMk.Location = new System.Drawing.Point(106, 262);
            this.txt_XacNhanMk.Name = "txt_XacNhanMk";
            this.txt_XacNhanMk.Size = new System.Drawing.Size(294, 34);
            this.txt_XacNhanMk.TabIndex = 5;
            // 
            // lbl_XacNhan
            // 
            this.lbl_XacNhan.AutoSize = true;
            this.lbl_XacNhan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_XacNhan.Location = new System.Drawing.Point(67, 233);
            this.lbl_XacNhan.Name = "lbl_XacNhan";
            this.lbl_XacNhan.Size = new System.Drawing.Size(177, 23);
            this.lbl_XacNhan.TabIndex = 4;
            this.lbl_XacNhan.Text = "Xác nhận mật khẩu";
            // 
            // btn_DoiMatKhau
            // 
            this.btn_DoiMatKhau.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_DoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btn_DoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DoiMatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btn_DoiMatKhau.Location = new System.Drawing.Point(58, 327);
            this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            this.btn_DoiMatKhau.Size = new System.Drawing.Size(139, 41);
            this.btn_DoiMatKhau.TabIndex = 6;
            this.btn_DoiMatKhau.Text = "Đổi mật khẩu";
            this.btn_DoiMatKhau.UseVisualStyleBackColor = false;
            this.btn_DoiMatKhau.Click += new System.EventHandler(this.btn_DoiMatKhau_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Location = new System.Drawing.Point(281, 327);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(139, 41);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 402);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DoiMatKhau);
            this.Controls.Add(this.txt_XacNhanMk);
            this.Controls.Add(this.lbl_XacNhan);
            this.Controls.Add(this.txt_MkMoi);
            this.Controls.Add(this.lbl_MkMoi);
            this.Controls.Add(this.txt_MkHienTai);
            this.Controls.Add(this.lbl_MkHienTai);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MkHienTai;
        private System.Windows.Forms.TextBox txt_MkHienTai;
        private System.Windows.Forms.TextBox txt_MkMoi;
        private System.Windows.Forms.Label lbl_MkMoi;
        private System.Windows.Forms.TextBox txt_XacNhanMk;
        private System.Windows.Forms.Label lbl_XacNhan;
        private System.Windows.Forms.Button btn_DoiMatKhau;
        private System.Windows.Forms.Button btn_Thoat;
    }
}