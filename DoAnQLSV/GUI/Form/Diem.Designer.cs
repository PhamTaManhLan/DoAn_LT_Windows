namespace GUI
{
    partial class frm_Diem
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
            this.grp_Diem = new System.Windows.Forms.GroupBox();
            this.btn_XoaDiem = new System.Windows.Forms.Button();
            this.btn_XemDS = new System.Windows.Forms.Button();
            this.lbl_MonHoc = new System.Windows.Forms.Label();
            this.btn_NhapDiem = new System.Windows.Forms.Button();
            this.txt_MaSinhVien = new System.Windows.Forms.TextBox();
            this.txt_DiemHe10 = new System.Windows.Forms.TextBox();
            this.lbl_DiemHe10 = new System.Windows.Forms.Label();
            this.btn_KiemTra = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.lbl_MaSV = new System.Windows.Forms.Label();
            this.lbl_Khoa = new System.Windows.Forms.Label();
            this.dgv_Diem = new System.Windows.Forms.DataGridView();
            this.lbl_TieuDe2 = new System.Windows.Forms.Label();
            this.lbl_TSV = new System.Windows.Forms.Label();
            this.lbl_TenSV = new System.Windows.Forms.Label();
            this.lbl_Tmonhoc = new System.Windows.Forms.Label();
            this.pnl_TieuDe.SuspendLayout();
            this.grp_Diem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Diem)).BeginInit();
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
            this.lbl_TieuDe1.Location = new System.Drawing.Point(287, 18);
            this.lbl_TieuDe1.Name = "lbl_TieuDe1";
            this.lbl_TieuDe1.Size = new System.Drawing.Size(269, 44);
            this.lbl_TieuDe1.TabIndex = 0;
            this.lbl_TieuDe1.Text = "Quản Lý Điểm";
            // 
            // grp_Diem
            // 
            this.grp_Diem.Controls.Add(this.lbl_Tmonhoc);
            this.grp_Diem.Controls.Add(this.lbl_TenSV);
            this.grp_Diem.Controls.Add(this.btn_XoaDiem);
            this.grp_Diem.Controls.Add(this.lbl_TSV);
            this.grp_Diem.Controls.Add(this.btn_XemDS);
            this.grp_Diem.Controls.Add(this.btn_NhapDiem);
            this.grp_Diem.Controls.Add(this.txt_MaSinhVien);
            this.grp_Diem.Controls.Add(this.lbl_MonHoc);
            this.grp_Diem.Controls.Add(this.txt_DiemHe10);
            this.grp_Diem.Controls.Add(this.lbl_DiemHe10);
            this.grp_Diem.Controls.Add(this.btn_KiemTra);
            this.grp_Diem.Controls.Add(this.btn_Sua);
            this.grp_Diem.Controls.Add(this.lbl_MaSV);
            this.grp_Diem.Location = new System.Drawing.Point(148, 97);
            this.grp_Diem.Name = "grp_Diem";
            this.grp_Diem.Size = new System.Drawing.Size(580, 131);
            this.grp_Diem.TabIndex = 1;
            this.grp_Diem.TabStop = false;
            // 
            // btn_XoaDiem
            // 
            this.btn_XoaDiem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_XoaDiem.FlatAppearance.BorderSize = 0;
            this.btn_XoaDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaDiem.ForeColor = System.Drawing.Color.White;
            this.btn_XoaDiem.Location = new System.Drawing.Point(480, 98);
            this.btn_XoaDiem.Name = "btn_XoaDiem";
            this.btn_XoaDiem.Size = new System.Drawing.Size(85, 27);
            this.btn_XoaDiem.TabIndex = 9;
            this.btn_XoaDiem.Text = "Xóa";
            this.btn_XoaDiem.UseVisualStyleBackColor = false;
            this.btn_XoaDiem.Click += new System.EventHandler(this.btn_XoaDiem_Click);
            // 
            // btn_XemDS
            // 
            this.btn_XemDS.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_XemDS.FlatAppearance.BorderSize = 0;
            this.btn_XemDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XemDS.ForeColor = System.Drawing.Color.White;
            this.btn_XemDS.Location = new System.Drawing.Point(140, 98);
            this.btn_XemDS.Name = "btn_XemDS";
            this.btn_XemDS.Size = new System.Drawing.Size(134, 27);
            this.btn_XemDS.TabIndex = 8;
            this.btn_XemDS.Text = "Xem danh sách";
            this.btn_XemDS.UseVisualStyleBackColor = false;
            this.btn_XemDS.Click += new System.EventHandler(this.btn_XemDS_Click);
            // 
            // lbl_MonHoc
            // 
            this.lbl_MonHoc.AutoSize = true;
            this.lbl_MonHoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MonHoc.Location = new System.Drawing.Point(406, 67);
            this.lbl_MonHoc.Name = "lbl_MonHoc";
            this.lbl_MonHoc.Size = new System.Drawing.Size(84, 23);
            this.lbl_MonHoc.TabIndex = 7;
            this.lbl_MonHoc.Text = "môn học";
            // 
            // btn_NhapDiem
            // 
            this.btn_NhapDiem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_NhapDiem.FlatAppearance.BorderSize = 0;
            this.btn_NhapDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhapDiem.ForeColor = System.Drawing.Color.White;
            this.btn_NhapDiem.Location = new System.Drawing.Point(280, 98);
            this.btn_NhapDiem.Name = "btn_NhapDiem";
            this.btn_NhapDiem.Size = new System.Drawing.Size(103, 27);
            this.btn_NhapDiem.TabIndex = 6;
            this.btn_NhapDiem.Text = "Nhập điểm";
            this.btn_NhapDiem.UseVisualStyleBackColor = false;
            this.btn_NhapDiem.Click += new System.EventHandler(this.btn_NhapDiem_Click);
            // 
            // txt_MaSinhVien
            // 
            this.txt_MaSinhVien.Location = new System.Drawing.Point(143, 23);
            this.txt_MaSinhVien.Name = "txt_MaSinhVien";
            this.txt_MaSinhVien.Size = new System.Drawing.Size(138, 27);
            this.txt_MaSinhVien.TabIndex = 5;
            this.txt_MaSinhVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MaSinhVien_KeyDown);
            // 
            // txt_DiemHe10
            // 
            this.txt_DiemHe10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiemHe10.Enabled = false;
            this.txt_DiemHe10.Location = new System.Drawing.Point(410, 23);
            this.txt_DiemHe10.Name = "txt_DiemHe10";
            this.txt_DiemHe10.Size = new System.Drawing.Size(142, 27);
            this.txt_DiemHe10.TabIndex = 1;
            this.txt_DiemHe10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DiemHe10_KeyPress);
            // 
            // lbl_DiemHe10
            // 
            this.lbl_DiemHe10.AutoSize = true;
            this.lbl_DiemHe10.Location = new System.Drawing.Point(307, 31);
            this.lbl_DiemHe10.Name = "lbl_DiemHe10";
            this.lbl_DiemHe10.Size = new System.Drawing.Size(93, 19);
            this.lbl_DiemHe10.TabIndex = 0;
            this.lbl_DiemHe10.Text = "Điểm hệ 10";
            // 
            // btn_KiemTra
            // 
            this.btn_KiemTra.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_KiemTra.FlatAppearance.BorderSize = 0;
            this.btn_KiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KiemTra.ForeColor = System.Drawing.Color.White;
            this.btn_KiemTra.Location = new System.Drawing.Point(49, 98);
            this.btn_KiemTra.Name = "btn_KiemTra";
            this.btn_KiemTra.Size = new System.Drawing.Size(85, 27);
            this.btn_KiemTra.TabIndex = 3;
            this.btn_KiemTra.Text = "Kiểm tra";
            this.btn_KiemTra.UseVisualStyleBackColor = false;
            this.btn_KiemTra.Click += new System.EventHandler(this.btn_KiemTra_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Sua.Enabled = false;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(389, 98);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(85, 27);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // lbl_MaSV
            // 
            this.lbl_MaSV.AutoSize = true;
            this.lbl_MaSV.Location = new System.Drawing.Point(34, 31);
            this.lbl_MaSV.Name = "lbl_MaSV";
            this.lbl_MaSV.Size = new System.Drawing.Size(100, 19);
            this.lbl_MaSV.TabIndex = 0;
            this.lbl_MaSV.Text = "Mã sinh viên";
            // 
            // lbl_Khoa
            // 
            this.lbl_Khoa.AutoSize = true;
            this.lbl_Khoa.Location = new System.Drawing.Point(12, 273);
            this.lbl_Khoa.Name = "lbl_Khoa";
            this.lbl_Khoa.Size = new System.Drawing.Size(34, 19);
            this.lbl_Khoa.TabIndex = 0;
            this.lbl_Khoa.Text = "     ";
            // 
            // dgv_Diem
            // 
            this.dgv_Diem.AllowUserToResizeColumns = false;
            this.dgv_Diem.AllowUserToResizeRows = false;
            this.dgv_Diem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Diem.Location = new System.Drawing.Point(12, 295);
            this.dgv_Diem.Name = "dgv_Diem";
            this.dgv_Diem.RowHeadersVisible = false;
            this.dgv_Diem.RowHeadersWidth = 51;
            this.dgv_Diem.RowTemplate.Height = 24;
            this.dgv_Diem.Size = new System.Drawing.Size(845, 202);
            this.dgv_Diem.TabIndex = 2;
            this.dgv_Diem.SelectionChanged += new System.EventHandler(this.dgv_Diem_SelectionChanged);
            // 
            // lbl_TieuDe2
            // 
            this.lbl_TieuDe2.AutoSize = true;
            this.lbl_TieuDe2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbl_TieuDe2.Location = new System.Drawing.Point(331, 231);
            this.lbl_TieuDe2.Name = "lbl_TieuDe2";
            this.lbl_TieuDe2.Size = new System.Drawing.Size(214, 33);
            this.lbl_TieuDe2.TabIndex = 0;
            this.lbl_TieuDe2.Text = "Điểm sinh viên";
            // 
            // lbl_TSV
            // 
            this.lbl_TSV.AutoSize = true;
            this.lbl_TSV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TSV.Location = new System.Drawing.Point(143, 67);
            this.lbl_TSV.Name = "lbl_TSV";
            this.lbl_TSV.Size = new System.Drawing.Size(46, 23);
            this.lbl_TSV.TabIndex = 4;
            this.lbl_TSV.Text = "      ";
            // 
            // lbl_TenSV
            // 
            this.lbl_TenSV.AutoSize = true;
            this.lbl_TenSV.Location = new System.Drawing.Point(34, 67);
            this.lbl_TenSV.Name = "lbl_TenSV";
            this.lbl_TenSV.Size = new System.Drawing.Size(34, 19);
            this.lbl_TenSV.TabIndex = 10;
            this.lbl_TenSV.Text = "     ";
            // 
            // lbl_Tmonhoc
            // 
            this.lbl_Tmonhoc.AutoSize = true;
            this.lbl_Tmonhoc.Location = new System.Drawing.Point(307, 71);
            this.lbl_Tmonhoc.Name = "lbl_Tmonhoc";
            this.lbl_Tmonhoc.Size = new System.Drawing.Size(77, 19);
            this.lbl_Tmonhoc.TabIndex = 11;
            this.lbl_Tmonhoc.Text = "Môn học:";
            // 
            // frm_Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 509);
            this.Controls.Add(this.lbl_TieuDe2);
            this.Controls.Add(this.dgv_Diem);
            this.Controls.Add(this.grp_Diem);
            this.Controls.Add(this.pnl_TieuDe);
            this.Controls.Add(this.lbl_Khoa);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Diem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diem";
            this.pnl_TieuDe.ResumeLayout(false);
            this.pnl_TieuDe.PerformLayout();
            this.grp_Diem.ResumeLayout(false);
            this.grp_Diem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Diem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_TieuDe;
        private System.Windows.Forms.Label lbl_TieuDe1;
        private System.Windows.Forms.GroupBox grp_Diem;
        private System.Windows.Forms.Label lbl_MaSV;
        private System.Windows.Forms.TextBox txt_DiemHe10;
        private System.Windows.Forms.Label lbl_DiemHe10;
        private System.Windows.Forms.DataGridView dgv_Diem;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_KiemTra;
        private System.Windows.Forms.Label lbl_TieuDe2;
        private System.Windows.Forms.Label lbl_Khoa;
        private System.Windows.Forms.TextBox txt_MaSinhVien;
        private System.Windows.Forms.Label lbl_TSV;
        private System.Windows.Forms.Button btn_NhapDiem;
        private System.Windows.Forms.Label lbl_MonHoc;
        private System.Windows.Forms.Button btn_XoaDiem;
        private System.Windows.Forms.Button btn_XemDS;
        private System.Windows.Forms.Label lbl_Tmonhoc;
        private System.Windows.Forms.Label lbl_TenSV;
    }
}