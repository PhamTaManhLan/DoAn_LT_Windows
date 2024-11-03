using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class frm_QuanLy : Form
    {
        private TaiKhoan tk;
        private GiangVien gv;
        ManagementDB ManagementDB = new ManagementDB();
        public frm_QuanLy(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            tk = taiKhoan;
            lbl_Name.Text = tk.GiangVien.HoTen;
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_FormLoad.Controls.Add(childForm);
            pnl_FormLoad.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private Button currentButton = null;
        private void designButton(Button bt, object sender)
        {
            Button clickedButton = sender as Button;
            // Nếu có Button nào đang được chọn, trả lại màu cũ của nó
            if (currentButton != null)
            {
                currentButton.BackColor = Color.MediumSlateBlue;
            }
            // Đặt màu cho Button vừa được nhấp
            clickedButton.BackColor = Color.SlateBlue;

            // Cập nhật Button hiện tại
            currentButton = clickedButton;
        }

        #region Buttons
        private void btnQuanLySinhVien_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frm_SinhVien());
            designButton(btn_QuanLySinhVien, sender as Button);
        }

        private void btnQLMonHoc_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frm_MonHoc());
            designButton(btn_QLMonHoc, sender as Button);
        }

        private void btnQLLop_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Lop());
            designButton(btn_QLLop, sender as Button);
        }

        private void btn_QLDiem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Diem());
            designButton(btn_QLDiem, sender as Button);
        }

        private void btn_QLGiangVien_Click(object sender, EventArgs e)
        {
            if (tk.Role == "Giảng Viên")
                MessageBox.Show("Bạn cần quyền admin để truy cập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                openChildForm(new frm_GiangVien());
                designButton(btn_QLGiangVien, sender as Button);
            }
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            using(ManagementDB context = new ManagementDB())
            {
                var user = context.TaiKhoans.FirstOrDefault(u => u.Username == tk.Username && u.Password == tk.Password);
                openChildForm(new frm_TaiKhoan(user));
            
            }    
            
            designButton(btn_TaiKhoan, sender as Button);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            designButton(btn_Thoat, sender as Button);
            Application.Exit();
        }
        #endregion
    }
}