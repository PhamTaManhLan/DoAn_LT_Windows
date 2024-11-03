namespace GUI
{
    partial class frm_GiangVien
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
            this.pnl_TieuDe = new System.Windows.Forms.Panel();
            this.lbl_TieuDe1 = new System.Windows.Forms.Label();
            this.dgv_GiangVien = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_MaGV = new System.Windows.Forms.TextBox();
            this.grp_ThongTinGiangVien = new System.Windows.Forms.GroupBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.cmb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btn_ThemAdmin = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.lbl_SoDT = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_MaGV = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_SoDT = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.pnl_TieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiangVien)).BeginInit();
            this.grp_ThongTinGiangVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_TieuDe
            // 
            this.pnl_TieuDe.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnl_TieuDe.Controls.Add(this.lbl_TieuDe1);
            this.pnl_TieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnl_TieuDe.Name = "pnl_TieuDe";
            this.pnl_TieuDe.Size = new System.Drawing.Size(869, 81);
            this.pnl_TieuDe.TabIndex = 0;
            // 
            // lbl_TieuDe1
            // 
            this.lbl_TieuDe1.AutoSize = true;
            this.lbl_TieuDe1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe1.ForeColor = System.Drawing.Color.White;
            this.lbl_TieuDe1.Location = new System.Drawing.Point(268, 18);
            this.lbl_TieuDe1.Name = "lbl_TieuDe1";
            this.lbl_TieuDe1.Size = new System.Drawing.Size(372, 44);
            this.lbl_TieuDe1.TabIndex = 0;
            this.lbl_TieuDe1.Text = "Quản Lý Giảng Viên";
            // 
            // dgv_GiangVien
            // 
            this.dgv_GiangVien.AllowUserToResizeColumns = false;
            this.dgv_GiangVien.AllowUserToResizeRows = false;
            this.dgv_GiangVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GiangVien.Location = new System.Drawing.Point(12, 321);
            this.dgv_GiangVien.Name = "dgv_GiangVien";
            this.dgv_GiangVien.RowHeadersVisible = false;
            this.dgv_GiangVien.RowHeadersWidth = 51;
            this.dgv_GiangVien.RowTemplate.Height = 24;
            this.dgv_GiangVien.Size = new System.Drawing.Size(845, 176);
            this.dgv_GiangVien.TabIndex = 1;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(461, 161);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(79, 27);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_MaGV
            // 
            this.txt_MaGV.Location = new System.Drawing.Point(163, 23);
            this.txt_MaGV.Name = "txt_MaGV";
            this.txt_MaGV.Size = new System.Drawing.Size(145, 27);
            this.txt_MaGV.TabIndex = 3;
            // 
            // grp_ThongTinGiangVien
            // 
            this.grp_ThongTinGiangVien.Controls.Add(this.lbl_TimKiem);
            this.grp_ThongTinGiangVien.Controls.Add(this.txt_TimKiem);
            this.grp_ThongTinGiangVien.Controls.Add(this.cmb_GioiTinh);
            this.grp_ThongTinGiangVien.Controls.Add(this.dt_NgaySinh);
            this.grp_ThongTinGiangVien.Controls.Add(this.btn_ThemAdmin);
            this.grp_ThongTinGiangVien.Controls.Add(this.btn_Xoa);
            this.grp_ThongTinGiangVien.Controls.Add(this.lbl_Email);
            this.grp_ThongTinGiangVien.Controls.Add(this.lbl_NgaySinh);
            this.grp_ThongTinGiangVien.Controls.Add(this.lbl_GioiTinh);
            this.grp_ThongTinGiangVien.Controls.Add(this.btn_Sua);
            this.grp_ThongTinGiangVien.Controls.Add(this.btn_Them);
            this.grp_ThongTinGiangVien.Controls.Add(this.lbl_SoDT);
            this.grp_ThongTinGiangVien.Controls.Add(this.lbl_HoTen);
            this.grp_ThongTinGiangVien.Controls.Add(this.lbl_MaGV);
            this.grp_ThongTinGiangVien.Controls.Add(this.txt_Email);
            this.grp_ThongTinGiangVien.Controls.Add(this.txt_SoDT);
            this.grp_ThongTinGiangVien.Controls.Add(this.txt_HoTen);
            this.grp_ThongTinGiangVien.Controls.Add(this.txt_MaGV);
            this.grp_ThongTinGiangVien.Location = new System.Drawing.Point(76, 87);
            this.grp_ThongTinGiangVien.Name = "grp_ThongTinGiangVien";
            this.grp_ThongTinGiangVien.Size = new System.Drawing.Size(716, 195);
            this.grp_ThongTinGiangVien.TabIndex = 4;
            this.grp_ThongTinGiangVien.TabStop = false;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(82, 162);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(125, 27);
            this.txt_TimKiem.TabIndex = 9;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // cmb_GioiTinh
            // 
            this.cmb_GioiTinh.FormattingEnabled = true;
            this.cmb_GioiTinh.Location = new System.Drawing.Point(461, 72);
            this.cmb_GioiTinh.Name = "cmb_GioiTinh";
            this.cmb_GioiTinh.Size = new System.Drawing.Size(121, 27);
            this.cmb_GioiTinh.TabIndex = 8;
            // 
            // dt_NgaySinh
            // 
            this.dt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_NgaySinh.Location = new System.Drawing.Point(163, 66);
            this.dt_NgaySinh.Name = "dt_NgaySinh";
            this.dt_NgaySinh.Size = new System.Drawing.Size(145, 27);
            this.dt_NgaySinh.TabIndex = 7;
            // 
            // btn_ThemAdmin
            // 
            this.btn_ThemAdmin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_ThemAdmin.FlatAppearance.BorderSize = 0;
            this.btn_ThemAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemAdmin.ForeColor = System.Drawing.Color.White;
            this.btn_ThemAdmin.Location = new System.Drawing.Point(346, 162);
            this.btn_ThemAdmin.Name = "btn_ThemAdmin";
            this.btn_ThemAdmin.Size = new System.Drawing.Size(109, 27);
            this.btn_ThemAdmin.TabIndex = 2;
            this.btn_ThemAdmin.Text = "Thêm Admin";
            this.btn_ThemAdmin.UseVisualStyleBackColor = false;
            this.btn_ThemAdmin.Click += new System.EventHandler(this.btn_ThemAdmin_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(631, 161);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(79, 27);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(383, 119);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(49, 19);
            this.lbl_Email.TabIndex = 6;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Location = new System.Drawing.Point(47, 72);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(82, 19);
            this.lbl_NgaySinh.TabIndex = 6;
            this.lbl_NgaySinh.Text = "Ngày sinh";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(383, 77);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(72, 19);
            this.lbl_GioiTinh.TabIndex = 6;
            this.lbl_GioiTinh.Text = "Giới tính";
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(546, 161);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(79, 27);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // lbl_SoDT
            // 
            this.lbl_SoDT.AutoSize = true;
            this.lbl_SoDT.Location = new System.Drawing.Point(47, 119);
            this.lbl_SoDT.Name = "lbl_SoDT";
            this.lbl_SoDT.Size = new System.Drawing.Size(106, 19);
            this.lbl_SoDT.TabIndex = 6;
            this.lbl_SoDT.Text = "Số điện thoại";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Location = new System.Drawing.Point(383, 29);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(56, 19);
            this.lbl_HoTen.TabIndex = 6;
            this.lbl_HoTen.Text = "Họ tên";
            // 
            // lbl_MaGV
            // 
            this.lbl_MaGV.AutoSize = true;
            this.lbl_MaGV.Location = new System.Drawing.Point(47, 26);
            this.lbl_MaGV.Name = "lbl_MaGV";
            this.lbl_MaGV.Size = new System.Drawing.Size(110, 19);
            this.lbl_MaGV.TabIndex = 6;
            this.lbl_MaGV.Text = "Mã giảng viên";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(459, 119);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(215, 27);
            this.txt_Email.TabIndex = 3;
            // 
            // txt_SoDT
            // 
            this.txt_SoDT.Location = new System.Drawing.Point(163, 116);
            this.txt_SoDT.Name = "txt_SoDT";
            this.txt_SoDT.Size = new System.Drawing.Size(145, 27);
            this.txt_SoDT.TabIndex = 3;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(459, 23);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(215, 27);
            this.txt_HoTen.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(306, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Giảng Viên";
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(10, 165);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(75, 19);
            this.lbl_TimKiem.TabIndex = 11;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // frm_GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_ThongTinGiangVien);
            this.Controls.Add(this.dgv_GiangVien);
            this.Controls.Add(this.pnl_TieuDe);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_GiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiangVien";
            this.Load += new System.EventHandler(this.frm_GiangVien_Load);
            this.pnl_TieuDe.ResumeLayout(false);
            this.pnl_TieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiangVien)).EndInit();
            this.grp_ThongTinGiangVien.ResumeLayout(false);
            this.grp_ThongTinGiangVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_TieuDe;
        private System.Windows.Forms.Label lbl_TieuDe1;
        private System.Windows.Forms.DataGridView dgv_GiangVien;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_MaGV;
        private System.Windows.Forms.GroupBox grp_ThongTinGiangVien;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_MaGV;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label lbl_SoDT;
        private System.Windows.Forms.TextBox txt_SoDT;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.DateTimePicker dt_NgaySinh;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ThemAdmin;
        private System.Windows.Forms.ComboBox cmb_GioiTinh;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lbl_TimKiem;
    }
}