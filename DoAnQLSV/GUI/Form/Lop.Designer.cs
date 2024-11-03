namespace GUI
{
    partial class frm_Lop
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
            this.lbl_Khoa = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.lbl_TenLop = new System.Windows.Forms.Label();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.lbl_MaLop = new System.Windows.Forms.Label();
            this.cmb_Khoa = new System.Windows.Forms.ComboBox();
            this.pnl_TieuDe = new System.Windows.Forms.Panel();
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            this.grp_ThongTin = new System.Windows.Forms.GroupBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TieuDe2 = new System.Windows.Forms.Label();
            this.dgv_QLLop = new System.Windows.Forms.DataGridView();
            this.pnl_TieuDe.SuspendLayout();
            this.grp_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLLop)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Khoa
            // 
            this.lbl_Khoa.AutoSize = true;
            this.lbl_Khoa.Location = new System.Drawing.Point(33, 81);
            this.lbl_Khoa.Name = "lbl_Khoa";
            this.lbl_Khoa.Size = new System.Drawing.Size(47, 19);
            this.lbl_Khoa.TabIndex = 8;
            this.lbl_Khoa.Text = "Khoa";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(385, 123);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(97, 26);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(505, 123);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(97, 26);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(436, 26);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(150, 27);
            this.txt_TenLop.TabIndex = 3;
            // 
            // lbl_TenLop
            // 
            this.lbl_TenLop.AutoSize = true;
            this.lbl_TenLop.Location = new System.Drawing.Point(349, 28);
            this.lbl_TenLop.Name = "lbl_TenLop";
            this.lbl_TenLop.Size = new System.Drawing.Size(64, 19);
            this.lbl_TenLop.TabIndex = 2;
            this.lbl_TenLop.Text = "Tên lớp";
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Location = new System.Drawing.Point(117, 26);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(183, 27);
            this.txt_MaLop.TabIndex = 1;
            // 
            // lbl_MaLop
            // 
            this.lbl_MaLop.AutoSize = true;
            this.lbl_MaLop.Location = new System.Drawing.Point(33, 28);
            this.lbl_MaLop.Name = "lbl_MaLop";
            this.lbl_MaLop.Size = new System.Drawing.Size(59, 19);
            this.lbl_MaLop.TabIndex = 0;
            this.lbl_MaLop.Text = "Mã lớp";
            // 
            // cmb_Khoa
            // 
            this.cmb_Khoa.FormattingEnabled = true;
            this.cmb_Khoa.Location = new System.Drawing.Point(117, 78);
            this.cmb_Khoa.Name = "cmb_Khoa";
            this.cmb_Khoa.Size = new System.Drawing.Size(183, 27);
            this.cmb_Khoa.TabIndex = 15;
            // 
            // pnl_TieuDe
            // 
            this.pnl_TieuDe.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnl_TieuDe.Controls.Add(this.lbl_TieuDe);
            this.pnl_TieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnl_TieuDe.Name = "pnl_TieuDe";
            this.pnl_TieuDe.Size = new System.Drawing.Size(869, 81);
            this.pnl_TieuDe.TabIndex = 16;
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.AutoSize = true;
            this.lbl_TieuDe.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.ForeColor = System.Drawing.Color.White;
            this.lbl_TieuDe.Location = new System.Drawing.Point(292, 18);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(250, 44);
            this.lbl_TieuDe.TabIndex = 0;
            this.lbl_TieuDe.Text = "Quản Lý Lớp";
            // 
            // grp_ThongTin
            // 
            this.grp_ThongTin.Controls.Add(this.lbl_TimKiem);
            this.grp_ThongTin.Controls.Add(this.txt_TimKiem);
            this.grp_ThongTin.Controls.Add(this.cmb_Khoa);
            this.grp_ThongTin.Controls.Add(this.txt_MaLop);
            this.grp_ThongTin.Controls.Add(this.lbl_MaLop);
            this.grp_ThongTin.Controls.Add(this.btn_Them);
            this.grp_ThongTin.Controls.Add(this.lbl_TenLop);
            this.grp_ThongTin.Controls.Add(this.btn_Sua);
            this.grp_ThongTin.Controls.Add(this.txt_TenLop);
            this.grp_ThongTin.Controls.Add(this.lbl_Khoa);
            this.grp_ThongTin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTin.ForeColor = System.Drawing.Color.Black;
            this.grp_ThongTin.Location = new System.Drawing.Point(122, 87);
            this.grp_ThongTin.Name = "grp_ThongTin";
            this.grp_ThongTin.Size = new System.Drawing.Size(627, 165);
            this.grp_ThongTin.TabIndex = 17;
            this.grp_ThongTin.TabStop = false;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(349, 84);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(75, 19);
            this.lbl_TimKiem.TabIndex = 17;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(436, 81);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(150, 27);
            this.txt_TimKiem.TabIndex = 16;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // lbl_TieuDe2
            // 
            this.lbl_TieuDe2.AutoSize = true;
            this.lbl_TieuDe2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbl_TieuDe2.Location = new System.Drawing.Point(331, 263);
            this.lbl_TieuDe2.Name = "lbl_TieuDe2";
            this.lbl_TieuDe2.Size = new System.Drawing.Size(223, 33);
            this.lbl_TieuDe2.TabIndex = 0;
            this.lbl_TieuDe2.Text = "Danh Sách Lớp";
            // 
            // dgv_QLLop
            // 
            this.dgv_QLLop.AllowUserToResizeColumns = false;
            this.dgv_QLLop.AllowUserToResizeRows = false;
            this.dgv_QLLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_QLLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLLop.Location = new System.Drawing.Point(12, 299);
            this.dgv_QLLop.Name = "dgv_QLLop";
            this.dgv_QLLop.RowHeadersVisible = false;
            this.dgv_QLLop.RowHeadersWidth = 51;
            this.dgv_QLLop.RowTemplate.Height = 24;
            this.dgv_QLLop.Size = new System.Drawing.Size(845, 198);
            this.dgv_QLLop.TabIndex = 18;
            // 
            // frm_Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 509);
            this.Controls.Add(this.dgv_QLLop);
            this.Controls.Add(this.grp_ThongTin);
            this.Controls.Add(this.lbl_TieuDe2);
            this.Controls.Add(this.pnl_TieuDe);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Lop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyLop";
            this.pnl_TieuDe.ResumeLayout(false);
            this.pnl_TieuDe.PerformLayout();
            this.grp_ThongTin.ResumeLayout(false);
            this.grp_ThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Khoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.Label lbl_TenLop;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.Label lbl_MaLop;
        private System.Windows.Forms.ComboBox cmb_Khoa;
        private System.Windows.Forms.Panel pnl_TieuDe;
        private System.Windows.Forms.Label lbl_TieuDe;
        private System.Windows.Forms.GroupBox grp_ThongTin;
        private System.Windows.Forms.Label lbl_TieuDe2;
        private System.Windows.Forms.DataGridView dgv_QLLop;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lbl_TimKiem;
    }
}