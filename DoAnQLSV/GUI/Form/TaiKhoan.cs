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

namespace GUI
{
    public partial class frm_TaiKhoan : Form
    {
        private TaiKhoan tk;
        public frm_TaiKhoan(TaiKhoan taiKhoan)
        {
            tk = taiKhoan;
            InitializeComponent();
            LoadThongTin();
        }

        private void LoadThongTin()
        {
            txt_TaiKhoan.Text = tk.GiangVien.GiangVienID;
            txt_HoTen.Text = tk.GiangVien.HoTen;
            txt_SDT.Text = tk.GiangVien.SoDienThoai;
            dt_NgaySinh.Value = tk.GiangVien.NgaySinh;
            txt_GioiTinh.Text = tk.GiangVien.GioiTinh;
            txt_Email.Text = tk.GiangVien.Email;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            using (ManagementDB management = new ManagementDB())
            {
                var user = management.TaiKhoans.FirstOrDefault(u => u.Username == tk.Username && u.Password == tk.Password);
                frm_DoiMatKhau frm_DoiMatKhau = new frm_DoiMatKhau(user);
                frm_DoiMatKhau.Show();
            }
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            this.Close();
            Application.OpenForms["frm_QuanLy"]?.Close();
            frmDangNhap.Show();
        }

        private void btn_SuaThongTin_Click(object sender, EventArgs e)
        {
            string newMaGiangVien = txt_TaiKhoan.Text;
            string newHoTen = txt_HoTen.Text;
            DateTime newNgaySinh = dt_NgaySinh.Value;
            string newGioiTinh = txt_GioiTinh.Text;
            string newSoDienThoai = txt_SDT.Text;
            string newEmail = txt_Email.Text;

            using (var context = new ManagementDB())
            {
                var user = context.TaiKhoans.FirstOrDefault(t => t.Username == tk.Username);
                if (user != null)
                {
                    user.GiangVien.GiangVienID = newMaGiangVien;
                    user.GiangVien.HoTen = newHoTen;
                    user.GiangVien.NgaySinh = newNgaySinh;
                    user.GiangVien.GioiTinh = newGioiTinh;
                    user.GiangVien.SoDienThoai = newSoDienThoai;
                    user.GiangVien.Email = newEmail;

                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("Sửa thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Cập nhật thông tin người dùng hiện tại
                        tk.GiangVien.GiangVienID = newMaGiangVien;
                        tk.GiangVien.HoTen = newHoTen;
                        tk.GiangVien.NgaySinh = newNgaySinh;
                        tk.GiangVien.GioiTinh = newGioiTinh;
                        tk.GiangVien.SoDienThoai = newSoDienThoai;
                        tk.GiangVien.Email = newEmail;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi sửa thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_TaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_HoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập các ký tự chữ và khoảng trắng
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_GioiTinh_Leave(object sender, EventArgs e)
        {
            var gioiTinh = txt_GioiTinh.Text.Trim().ToLower();
            if (gioiTinh != "nam" && gioiTinh != "nữ" && gioiTinh != "khác")
            {
                MessageBox.Show("Giới tính không hợp lệ. Vui lòng nhập 'Nam', 'Nữ', hoặc 'Khác'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txt_Email.Text))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
