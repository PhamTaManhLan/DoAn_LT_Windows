namespace GUI
{
    partial class frm_SinhVien
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grp_ThongTinSinhVien = new System.Windows.Forms.GroupBox();
            this.cmb_Lop = new System.Windows.Forms.ComboBox();
            this.cmb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.cmb_Khoa = new System.Windows.Forms.ComboBox();
            this.lbl_Khoa = new System.Windows.Forms.Label();
            this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.lbl_lop = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.txt_MaSinhVien = new System.Windows.Forms.TextBox();
            this.lbl_MaSinhVien = new System.Windows.Forms.Label();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TieuDe2 = new System.Windows.Forms.Label();
            this.pnl_TieuDe = new System.Windows.Forms.Panel();
            this.lbl_TieuDe1 = new System.Windows.Forms.Label();
            this.dgv_SinhVien = new System.Windows.Forms.DataGridView();
            this.grp_ThongTinSinhVien.SuspendLayout();
            this.pnl_TieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(404, 159);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 26);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(504, 159);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 26);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(604, 159);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 26);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grp_ThongTinSinhVien
            // 
            this.grp_ThongTinSinhVien.Controls.Add(this.lbl_TimKiem);
            this.grp_ThongTinSinhVien.Controls.Add(this.cmb_Lop);
            this.grp_ThongTinSinhVien.Controls.Add(this.cmb_GioiTinh);
            this.grp_ThongTinSinhVien.Controls.Add(this.cmb_Khoa);
            this.grp_ThongTinSinhVien.Controls.Add(this.lbl_Khoa);
            this.grp_ThongTinSinhVien.Controls.Add(this.dt_NgaySinh);
            this.grp_ThongTinSinhVien.Controls.Add(this.txt_TimKiem);
            this.grp_ThongTinSinhVien.Controls.Add(this.btnXoa);
            this.grp_ThongTinSinhVien.Controls.Add(this.btnThem);
            this.grp_ThongTinSinhVien.Controls.Add(this.lbl_NgaySinh);
            this.grp_ThongTinSinhVien.Controls.Add(this.btnSua);
            this.grp_ThongTinSinhVien.Controls.Add(this.txt_HoTen);
            this.grp_ThongTinSinhVien.Controls.Add(this.lbl_lop);
            this.grp_ThongTinSinhVien.Controls.Add(this.lbl_HoTen);
            this.grp_ThongTinSinhVien.Controls.Add(this.lbl_GioiTinh);
            this.grp_ThongTinSinhVien.Controls.Add(this.txt_SDT);
            this.grp_ThongTinSinhVien.Controls.Add(this.lbl_SDT);
            this.grp_ThongTinSinhVien.Controls.Add(this.txt_MaSinhVien);
            this.grp_ThongTinSinhVien.Controls.Add(this.lbl_MaSinhVien);
            this.grp_ThongTinSinhVien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTinSinhVien.Location = new System.Drawing.Point(77, 88);
            this.grp_ThongTinSinhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_ThongTinSinhVien.Name = "grp_ThongTinSinhVien";
            this.grp_ThongTinSinhVien.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_ThongTinSinhVien.Size = new System.Drawing.Size(704, 193);
            this.grp_ThongTinSinhVien.TabIndex = 7;
            this.grp_ThongTinSinhVien.TabStop = false;
            // 
            // cmb_Lop
            // 
            this.cmb_Lop.FormattingEnabled = true;
            this.cmb_Lop.Location = new System.Drawing.Point(572, 71);
            this.cmb_Lop.Name = "cmb_Lop";
            this.cmb_Lop.Size = new System.Drawing.Size(93, 27);
            this.cmb_Lop.TabIndex = 19;
            // 
            // cmb_GioiTinh
            // 
            this.cmb_GioiTinh.FormattingEnabled = true;
            this.cmb_GioiTinh.Location = new System.Drawing.Point(445, 71);
            this.cmb_GioiTinh.Name = "cmb_GioiTinh";
            this.cmb_GioiTinh.Size = new System.Drawing.Size(72, 27);
            this.cmb_GioiTinh.TabIndex = 19;
            // 
            // cmb_Khoa
            // 
            this.cmb_Khoa.FormattingEnabled = true;
            this.cmb_Khoa.Location = new System.Drawing.Point(443, 114);
            this.cmb_Khoa.Name = "cmb_Khoa";
            this.cmb_Khoa.Size = new System.Drawing.Size(220, 27);
            this.cmb_Khoa.TabIndex = 19;
            this.cmb_Khoa.SelectedIndexChanged += new System.EventHandler(this.cmb_Khoa_SelectedIndexChanged);
            // 
            // lbl_Khoa
            // 
            this.lbl_Khoa.AutoSize = true;
            this.lbl_Khoa.Location = new System.Drawing.Point(368, 122);
            this.lbl_Khoa.Name = "lbl_Khoa";
            this.lbl_Khoa.Size = new System.Drawing.Size(47, 19);
            this.lbl_Khoa.TabIndex = 18;
            this.lbl_Khoa.Text = "Khoa";
            // 
            // dt_NgaySinh
            // 
            this.dt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_NgaySinh.Location = new System.Drawing.Point(133, 68);
            this.dt_NgaySinh.Name = "dt_NgaySinh";
            this.dt_NgaySinh.Size = new System.Drawing.Size(135, 27);
            this.dt_NgaySinh.TabIndex = 7;
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Location = new System.Drawing.Point(21, 74);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(82, 19);
            this.lbl_NgaySinh.TabIndex = 4;
            this.lbl_NgaySinh.Text = "Ngày sinh";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(443, 23);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(222, 27);
            this.txt_HoTen.TabIndex = 1;
            // 
            // lbl_lop
            // 
            this.lbl_lop.AutoSize = true;
            this.lbl_lop.Location = new System.Drawing.Point(528, 74);
            this.lbl_lop.Name = "lbl_lop";
            this.lbl_lop.Size = new System.Drawing.Size(38, 19);
            this.lbl_lop.TabIndex = 6;
            this.lbl_lop.Text = "Lớp";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Location = new System.Drawing.Point(368, 31);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(56, 19);
            this.lbl_HoTen.TabIndex = 0;
            this.lbl_HoTen.Text = "Họ tên";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(368, 74);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(72, 19);
            this.lbl_GioiTinh.TabIndex = 6;
            this.lbl_GioiTinh.Text = "Giới tính";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(133, 114);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(220, 27);
            this.txt_SDT.TabIndex = 3;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Location = new System.Drawing.Point(21, 122);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(106, 19);
            this.lbl_SDT.TabIndex = 2;
            this.lbl_SDT.Text = "Số điện thoại";
            // 
            // txt_MaSinhVien
            // 
            this.txt_MaSinhVien.Location = new System.Drawing.Point(133, 23);
            this.txt_MaSinhVien.Name = "txt_MaSinhVien";
            this.txt_MaSinhVien.Size = new System.Drawing.Size(220, 27);
            this.txt_MaSinhVien.TabIndex = 3;
            // 
            // lbl_MaSinhVien
            // 
            this.lbl_MaSinhVien.AutoSize = true;
            this.lbl_MaSinhVien.Location = new System.Drawing.Point(21, 31);
            this.lbl_MaSinhVien.Name = "lbl_MaSinhVien";
            this.lbl_MaSinhVien.Size = new System.Drawing.Size(100, 19);
            this.lbl_MaSinhVien.TabIndex = 2;
            this.lbl_MaSinhVien.Text = "Mã sinh viên";
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(28, 163);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(75, 19);
            this.lbl_TimKiem.TabIndex = 21;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(133, 158);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(220, 27);
            this.txt_TimKiem.TabIndex = 3;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // lbl_TieuDe2
            // 
            this.lbl_TieuDe2.AutoSize = true;
            this.lbl_TieuDe2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbl_TieuDe2.Location = new System.Drawing.Point(289, 285);
            this.lbl_TieuDe2.Name = "lbl_TieuDe2";
            this.lbl_TieuDe2.Size = new System.Drawing.Size(286, 33);
            this.lbl_TieuDe2.TabIndex = 9;
            this.lbl_TieuDe2.Text = "Danh sách sinh viên";
            // 
            // pnl_TieuDe
            // 
            this.pnl_TieuDe.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnl_TieuDe.Controls.Add(this.lbl_TieuDe1);
            this.pnl_TieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnl_TieuDe.Name = "pnl_TieuDe";
            this.pnl_TieuDe.Size = new System.Drawing.Size(869, 81);
            this.pnl_TieuDe.TabIndex = 10;
            // 
            // lbl_TieuDe1
            // 
            this.lbl_TieuDe1.AutoSize = true;
            this.lbl_TieuDe1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe1.ForeColor = System.Drawing.Color.White;
            this.lbl_TieuDe1.Location = new System.Drawing.Point(268, 18);
            this.lbl_TieuDe1.Name = "lbl_TieuDe1";
            this.lbl_TieuDe1.Size = new System.Drawing.Size(340, 44);
            this.lbl_TieuDe1.TabIndex = 9;
            this.lbl_TieuDe1.Text = "Quản Lý sinh viên";
            // 
            // dgv_SinhVien
            // 
            this.dgv_SinhVien.AllowUserToResizeColumns = false;
            this.dgv_SinhVien.AllowUserToResizeRows = false;
            this.dgv_SinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SinhVien.Location = new System.Drawing.Point(12, 321);
            this.dgv_SinhVien.Name = "dgv_SinhVien";
            this.dgv_SinhVien.RowHeadersVisible = false;
            this.dgv_SinhVien.RowHeadersWidth = 51;
            this.dgv_SinhVien.RowTemplate.Height = 24;
            this.dgv_SinhVien.Size = new System.Drawing.Size(845, 176);
            this.dgv_SinhVien.TabIndex = 11;
            // 
            // frm_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 509);
            this.Controls.Add(this.dgv_SinhVien);
            this.Controls.Add(this.grp_ThongTinSinhVien);
            this.Controls.Add(this.pnl_TieuDe);
            this.Controls.Add(this.lbl_TieuDe2);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_SinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.Load += new System.EventHandler(this.frm_SinhVien_Load);
            this.grp_ThongTinSinhVien.ResumeLayout(false);
            this.grp_ThongTinSinhVien.PerformLayout();
            this.pnl_TieuDe.ResumeLayout(false);
            this.pnl_TieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grp_ThongTinSinhVien;
        private System.Windows.Forms.DateTimePicker dt_NgaySinh;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.TextBox txt_MaSinhVien;
        private System.Windows.Forms.Label lbl_MaSinhVien;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_TieuDe2;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.Panel pnl_TieuDe;
        private System.Windows.Forms.Label lbl_TieuDe1;
        private System.Windows.Forms.ComboBox cmb_Khoa;
        private System.Windows.Forms.Label lbl_Khoa;
        private System.Windows.Forms.DataGridView dgv_SinhVien;
        private System.Windows.Forms.ComboBox cmb_GioiTinh;
        private System.Windows.Forms.ComboBox cmb_Lop;
        private System.Windows.Forms.Label lbl_lop;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lbl_TimKiem;
    }
}