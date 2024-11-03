namespace GUI
{
    partial class frm_MonHoc
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
            this.lbl_SoTinChi = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgv_MonHoc = new System.Windows.Forms.DataGridView();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_TenMonHoc = new System.Windows.Forms.TextBox();
            this.lbl_TenMonHoc = new System.Windows.Forms.Label();
            this.txt_MaMonHoc = new System.Windows.Forms.TextBox();
            this.lbl_MaMonHoc = new System.Windows.Forms.Label();
            this.pnl_TieuDe = new System.Windows.Forms.Panel();
            this.lbl_TieuDe1 = new System.Windows.Forms.Label();
            this.lbl_TieuDe2 = new System.Windows.Forms.Label();
            this.grp_MonHoc = new System.Windows.Forms.GroupBox();
            this.cmb_Khoa = new System.Windows.Forms.ComboBox();
            this.txt_SoTinChi = new System.Windows.Forms.TextBox();
            this.lbl_Khoa = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.cmb_Loc = new System.Windows.Forms.ComboBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.lbl_Loc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).BeginInit();
            this.pnl_TieuDe.SuspendLayout();
            this.grp_MonHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_SoTinChi
            // 
            this.lbl_SoTinChi.AutoSize = true;
            this.lbl_SoTinChi.Location = new System.Drawing.Point(350, 30);
            this.lbl_SoTinChi.Name = "lbl_SoTinChi";
            this.lbl_SoTinChi.Size = new System.Drawing.Size(74, 19);
            this.lbl_SoTinChi.TabIndex = 12;
            this.lbl_SoTinChi.Text = "Số tín chỉ";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(267, 148);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(109, 29);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgv_MonHoc
            // 
            this.dgv_MonHoc.AllowUserToResizeColumns = false;
            this.dgv_MonHoc.AllowUserToResizeRows = false;
            this.dgv_MonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MonHoc.Location = new System.Drawing.Point(12, 319);
            this.dgv_MonHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_MonHoc.Name = "dgv_MonHoc";
            this.dgv_MonHoc.RowHeadersVisible = false;
            this.dgv_MonHoc.RowHeadersWidth = 51;
            this.dgv_MonHoc.RowTemplate.Height = 24;
            this.dgv_MonHoc.Size = new System.Drawing.Size(845, 177);
            this.dgv_MonHoc.TabIndex = 0;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(497, 148);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(105, 29);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(382, 148);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(109, 29);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txt_TenMonHoc
            // 
            this.txt_TenMonHoc.Location = new System.Drawing.Point(127, 70);
            this.txt_TenMonHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenMonHoc.Name = "txt_TenMonHoc";
            this.txt_TenMonHoc.Size = new System.Drawing.Size(168, 27);
            this.txt_TenMonHoc.TabIndex = 3;
            // 
            // lbl_TenMonHoc
            // 
            this.lbl_TenMonHoc.AutoSize = true;
            this.lbl_TenMonHoc.Location = new System.Drawing.Point(24, 73);
            this.lbl_TenMonHoc.Name = "lbl_TenMonHoc";
            this.lbl_TenMonHoc.Size = new System.Drawing.Size(97, 19);
            this.lbl_TenMonHoc.TabIndex = 2;
            this.lbl_TenMonHoc.Text = "Tên môn học";
            // 
            // txt_MaMonHoc
            // 
            this.txt_MaMonHoc.Location = new System.Drawing.Point(127, 28);
            this.txt_MaMonHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaMonHoc.Name = "txt_MaMonHoc";
            this.txt_MaMonHoc.Size = new System.Drawing.Size(168, 27);
            this.txt_MaMonHoc.TabIndex = 1;
            // 
            // lbl_MaMonHoc
            // 
            this.lbl_MaMonHoc.AutoSize = true;
            this.lbl_MaMonHoc.Location = new System.Drawing.Point(27, 35);
            this.lbl_MaMonHoc.Name = "lbl_MaMonHoc";
            this.lbl_MaMonHoc.Size = new System.Drawing.Size(94, 19);
            this.lbl_MaMonHoc.TabIndex = 0;
            this.lbl_MaMonHoc.Text = "Mã môn học";
            // 
            // pnl_TieuDe
            // 
            this.pnl_TieuDe.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnl_TieuDe.Controls.Add(this.lbl_TieuDe1);
            this.pnl_TieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TieuDe.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_TieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnl_TieuDe.Name = "pnl_TieuDe";
            this.pnl_TieuDe.Size = new System.Drawing.Size(869, 81);
            this.pnl_TieuDe.TabIndex = 19;
            // 
            // lbl_TieuDe1
            // 
            this.lbl_TieuDe1.AutoSize = true;
            this.lbl_TieuDe1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe1.ForeColor = System.Drawing.Color.White;
            this.lbl_TieuDe1.Location = new System.Drawing.Point(268, 18);
            this.lbl_TieuDe1.Name = "lbl_TieuDe1";
            this.lbl_TieuDe1.Size = new System.Drawing.Size(336, 44);
            this.lbl_TieuDe1.TabIndex = 9;
            this.lbl_TieuDe1.Text = "Quản Lý Môn Học";
            // 
            // lbl_TieuDe2
            // 
            this.lbl_TieuDe2.AutoSize = true;
            this.lbl_TieuDe2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbl_TieuDe2.Location = new System.Drawing.Point(285, 282);
            this.lbl_TieuDe2.Name = "lbl_TieuDe2";
            this.lbl_TieuDe2.Size = new System.Drawing.Size(289, 33);
            this.lbl_TieuDe2.TabIndex = 21;
            this.lbl_TieuDe2.Text = "Danh Sách Môn Học";
            // 
            // grp_MonHoc
            // 
            this.grp_MonHoc.Controls.Add(this.lbl_Loc);
            this.grp_MonHoc.Controls.Add(this.lbl_TimKiem);
            this.grp_MonHoc.Controls.Add(this.cmb_Loc);
            this.grp_MonHoc.Controls.Add(this.cmb_Khoa);
            this.grp_MonHoc.Controls.Add(this.txt_SoTinChi);
            this.grp_MonHoc.Controls.Add(this.txt_TenMonHoc);
            this.grp_MonHoc.Controls.Add(this.btn_Xoa);
            this.grp_MonHoc.Controls.Add(this.btn_Them);
            this.grp_MonHoc.Controls.Add(this.txt_TimKiem);
            this.grp_MonHoc.Controls.Add(this.btn_Sua);
            this.grp_MonHoc.Controls.Add(this.lbl_MaMonHoc);
            this.grp_MonHoc.Controls.Add(this.lbl_Khoa);
            this.grp_MonHoc.Controls.Add(this.lbl_SoTinChi);
            this.grp_MonHoc.Controls.Add(this.txt_MaMonHoc);
            this.grp_MonHoc.Controls.Add(this.lbl_TenMonHoc);
            this.grp_MonHoc.Location = new System.Drawing.Point(124, 87);
            this.grp_MonHoc.Name = "grp_MonHoc";
            this.grp_MonHoc.Size = new System.Drawing.Size(635, 192);
            this.grp_MonHoc.TabIndex = 22;
            this.grp_MonHoc.TabStop = false;
            // 
            // cmb_Khoa
            // 
            this.cmb_Khoa.FormattingEnabled = true;
            this.cmb_Khoa.Location = new System.Drawing.Point(430, 70);
            this.cmb_Khoa.Name = "cmb_Khoa";
            this.cmb_Khoa.Size = new System.Drawing.Size(172, 27);
            this.cmb_Khoa.TabIndex = 13;
            // 
            // txt_SoTinChi
            // 
            this.txt_SoTinChi.Location = new System.Drawing.Point(430, 27);
            this.txt_SoTinChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SoTinChi.Name = "txt_SoTinChi";
            this.txt_SoTinChi.Size = new System.Drawing.Size(172, 27);
            this.txt_SoTinChi.TabIndex = 3;
            // 
            // lbl_Khoa
            // 
            this.lbl_Khoa.AutoSize = true;
            this.lbl_Khoa.Location = new System.Drawing.Point(350, 73);
            this.lbl_Khoa.Name = "lbl_Khoa";
            this.lbl_Khoa.Size = new System.Drawing.Size(45, 19);
            this.lbl_Khoa.TabIndex = 12;
            this.lbl_Khoa.Text = "Khoa";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(127, 112);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(168, 28);
            this.txt_TimKiem.TabIndex = 1;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // cmb_Loc
            // 
            this.cmb_Loc.FormattingEnabled = true;
            this.cmb_Loc.Location = new System.Drawing.Point(430, 113);
            this.cmb_Loc.Name = "cmb_Loc";
            this.cmb_Loc.Size = new System.Drawing.Size(172, 27);
            this.cmb_Loc.TabIndex = 13;
            this.cmb_Loc.SelectedIndexChanged += new System.EventHandler(this.cmb_Loc_SelectedIndexChanged);
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(27, 116);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(74, 19);
            this.lbl_TimKiem.TabIndex = 14;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // lbl_Loc
            // 
            this.lbl_Loc.AutoSize = true;
            this.lbl_Loc.Location = new System.Drawing.Point(350, 116);
            this.lbl_Loc.Name = "lbl_Loc";
            this.lbl_Loc.Size = new System.Drawing.Size(36, 19);
            this.lbl_Loc.TabIndex = 15;
            this.lbl_Loc.Text = "Lọc";
            // 
            // frm_MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 509);
            this.Controls.Add(this.grp_MonHoc);
            this.Controls.Add(this.lbl_TieuDe2);
            this.Controls.Add(this.pnl_TieuDe);
            this.Controls.Add(this.dgv_MonHoc);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_MonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyMonHoc";
            this.Load += new System.EventHandler(this.frm_MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).EndInit();
            this.pnl_TieuDe.ResumeLayout(false);
            this.pnl_TieuDe.PerformLayout();
            this.grp_MonHoc.ResumeLayout(false);
            this.grp_MonHoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_SoTinChi;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TextBox txt_TenMonHoc;
        private System.Windows.Forms.Label lbl_TenMonHoc;
        private System.Windows.Forms.TextBox txt_MaMonHoc;
        private System.Windows.Forms.Label lbl_MaMonHoc;
        private System.Windows.Forms.DataGridView dgv_MonHoc;
        private System.Windows.Forms.Panel pnl_TieuDe;
        private System.Windows.Forms.Label lbl_TieuDe1;
        private System.Windows.Forms.Label lbl_TieuDe2;
        private System.Windows.Forms.GroupBox grp_MonHoc;
        private System.Windows.Forms.TextBox txt_SoTinChi;
        private System.Windows.Forms.ComboBox cmb_Khoa;
        private System.Windows.Forms.Label lbl_Khoa;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.ComboBox cmb_Loc;
        private System.Windows.Forms.Label lbl_Loc;
        private System.Windows.Forms.Label lbl_TimKiem;
    }
}