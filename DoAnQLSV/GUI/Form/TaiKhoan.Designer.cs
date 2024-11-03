using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class frm_TaiKhoan
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
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.lbl_TaiKhoan = new System.Windows.Forms.Label();
            this.grp_ThongTinTK = new System.Windows.Forms.GroupBox();
            this.txt_GioiTinh = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_SuaThongTin = new System.Windows.Forms.Button();
            this.btn_DoiMK = new System.Windows.Forms.Button();
            this.pnl_TieuDe = new System.Windows.Forms.Panel();
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.grp_ThongTinTK.SuspendLayout();
            this.pnl_TieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(304, 34);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(99, 25);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDT.Location = new System.Drawing.Point(17, 178);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(126, 25);
            this.lblSoDT.TabIndex = 4;
            this.lblSoDT.Text = "Số điện thoại";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(304, 106);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(82, 25);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // dt_NgaySinh
            // 
            this.dt_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_NgaySinh.Location = new System.Drawing.Point(312, 63);
            this.dt_NgaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dt_NgaySinh.Name = "dt_NgaySinh";
            this.dt_NgaySinh.Size = new System.Drawing.Size(132, 27);
            this.dt_NgaySinh.TabIndex = 5;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(26, 207);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(243, 27);
            this.txt_SDT.TabIndex = 1;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BackColor = System.Drawing.SystemColors.Window;
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(26, 135);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(243, 27);
            this.txt_HoTen.TabIndex = 1;
            this.txt_HoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_HoTen_KeyPress);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(17, 106);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(95, 25);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ và tên";
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(26, 63);
            this.txt_TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(243, 27);
            this.txt_TaiKhoan.TabIndex = 9;
            this.txt_TaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TaiKhoan_KeyPress);
            // 
            // lbl_TaiKhoan
            // 
            this.lbl_TaiKhoan.AutoSize = true;
            this.lbl_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaiKhoan.Location = new System.Drawing.Point(17, 34);
            this.lbl_TaiKhoan.Name = "lbl_TaiKhoan";
            this.lbl_TaiKhoan.Size = new System.Drawing.Size(99, 25);
            this.lbl_TaiKhoan.TabIndex = 10;
            this.lbl_TaiKhoan.Text = "Tài khoản";
            // 
            // grp_ThongTinTK
            // 
            this.grp_ThongTinTK.Controls.Add(this.txt_GioiTinh);
            this.grp_ThongTinTK.Controls.Add(this.lbl_Email);
            this.grp_ThongTinTK.Controls.Add(this.txt_Email);
            this.grp_ThongTinTK.Controls.Add(this.lbl_TaiKhoan);
            this.grp_ThongTinTK.Controls.Add(this.txt_TaiKhoan);
            this.grp_ThongTinTK.Controls.Add(this.dt_NgaySinh);
            this.grp_ThongTinTK.Controls.Add(this.lblGioiTinh);
            this.grp_ThongTinTK.Controls.Add(this.lblSoDT);
            this.grp_ThongTinTK.Controls.Add(this.lblNgaySinh);
            this.grp_ThongTinTK.Controls.Add(this.lblHoTen);
            this.grp_ThongTinTK.Controls.Add(this.txt_SDT);
            this.grp_ThongTinTK.Controls.Add(this.txt_HoTen);
            this.grp_ThongTinTK.Location = new System.Drawing.Point(150, 103);
            this.grp_ThongTinTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_ThongTinTK.Name = "grp_ThongTinTK";
            this.grp_ThongTinTK.Padding = new System.Windows.Forms.Padding(0);
            this.grp_ThongTinTK.Size = new System.Drawing.Size(576, 266);
            this.grp_ThongTinTK.TabIndex = 11;
            this.grp_ThongTinTK.TabStop = false;
            // 
            // txt_GioiTinh
            // 
            this.txt_GioiTinh.Location = new System.Drawing.Point(312, 136);
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.Size = new System.Drawing.Size(193, 27);
            this.txt_GioiTinh.TabIndex = 11;
            this.txt_GioiTinh.Leave += new System.EventHandler(this.txt_GioiTinh_Leave);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(304, 178);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(60, 25);
            this.lbl_Email.TabIndex = 10;
            this.lbl_Email.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(312, 207);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(219, 27);
            this.txt_Email.TabIndex = 9;
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // btn_SuaThongTin
            // 
            this.btn_SuaThongTin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_SuaThongTin.FlatAppearance.BorderSize = 0;
            this.btn_SuaThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuaThongTin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaThongTin.ForeColor = System.Drawing.Color.White;
            this.btn_SuaThongTin.Location = new System.Drawing.Point(77, 417);
            this.btn_SuaThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SuaThongTin.Name = "btn_SuaThongTin";
            this.btn_SuaThongTin.Size = new System.Drawing.Size(185, 52);
            this.btn_SuaThongTin.TabIndex = 12;
            this.btn_SuaThongTin.Text = "Sửa thông tin";
            this.btn_SuaThongTin.UseVisualStyleBackColor = false;
            this.btn_SuaThongTin.Click += new System.EventHandler(this.btn_SuaThongTin_Click);
            // 
            // btn_DoiMK
            // 
            this.btn_DoiMK.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_DoiMK.FlatAppearance.BorderSize = 0;
            this.btn_DoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DoiMK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMK.ForeColor = System.Drawing.Color.White;
            this.btn_DoiMK.Location = new System.Drawing.Point(338, 417);
            this.btn_DoiMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DoiMK.Name = "btn_DoiMK";
            this.btn_DoiMK.Size = new System.Drawing.Size(185, 52);
            this.btn_DoiMK.TabIndex = 12;
            this.btn_DoiMK.Text = "Đổi mật khẩu";
            this.btn_DoiMK.UseVisualStyleBackColor = false;
            this.btn_DoiMK.Click += new System.EventHandler(this.btn_DoiMK_Click);
            // 
            // pnl_TieuDe
            // 
            this.pnl_TieuDe.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnl_TieuDe.Controls.Add(this.lbl_TieuDe);
            this.pnl_TieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TieuDe.ForeColor = System.Drawing.Color.White;
            this.pnl_TieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnl_TieuDe.Name = "pnl_TieuDe";
            this.pnl_TieuDe.Size = new System.Drawing.Size(869, 81);
            this.pnl_TieuDe.TabIndex = 13;
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.AutoSize = true;
            this.lbl_TieuDe.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.Location = new System.Drawing.Point(237, 23);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(390, 44);
            this.lbl_TieuDe.TabIndex = 0;
            this.lbl_TieuDe.Text = "Thông Tin Tài Khoản";
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_DangXuat.FlatAppearance.BorderSize = 0;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.White;
            this.btn_DangXuat.Location = new System.Drawing.Point(591, 417);
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(185, 52);
            this.btn_DangXuat.TabIndex = 12;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // frm_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 495);
            this.Controls.Add(this.pnl_TieuDe);
            this.Controls.Add(this.btn_DangXuat);
            this.Controls.Add(this.btn_DoiMK);
            this.Controls.Add(this.btn_SuaThongTin);
            this.Controls.Add(this.grp_ThongTinTK);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_TaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountProfile";
            this.grp_ThongTinTK.ResumeLayout(false);
            this.grp_ThongTinTK.PerformLayout();
            this.pnl_TieuDe.ResumeLayout(false);
            this.pnl_TieuDe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label lblNgaySinh;
        private Label lblSoDT;
        private Label lblGioiTinh;
        private DateTimePicker dt_NgaySinh;
        private TextBox txt_SDT;
        private TextBox txt_HoTen;
        private Label lblHoTen;
        private TextBox txt_TaiKhoan;
        private Label lbl_TaiKhoan;
        private GroupBox grp_ThongTinTK;
        private Button btn_SuaThongTin;
        private Button btn_DoiMK;
        private Panel pnl_TieuDe;
        private Label lbl_TieuDe;
        private Button btn_DangXuat;
        private Label lbl_Email;
        private TextBox txt_Email;
        private TextBox txt_GioiTinh;
    }
}