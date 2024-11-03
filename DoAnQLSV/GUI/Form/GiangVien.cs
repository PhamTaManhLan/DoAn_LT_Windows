using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Models;

namespace GUI
{
    public partial class frm_GiangVien : Form
    {
        public frm_GiangVien()
        {
            InitializeComponent();
            LoadGiangVien();
            Binding();
        }

        private void LoadGiangVien()
        {
            using (var giangvien = new ManagementDB())
            {
                var giangvienlist = giangvien.GiangViens.Select(gv => new
                {
                    gv.GiangVienID,
                    gv.HoTen,
                    gv.NgaySinh,
                    gv.GioiTinh,
                    gv.SoDienThoai,
                    gv.Email,

                }).ToList();

                dgv_GiangVien.DataSource = giangvienlist;
            }
        }
        private void Binding()
        {
            txt_MaGV.DataBindings.Clear();
            txt_HoTen.DataBindings.Clear();
            dt_NgaySinh.DataBindings.Clear();
            cmb_GioiTinh.DataBindings.Clear();
            txt_SoDT.DataBindings.Clear();
            txt_Email.DataBindings.Clear();

            txt_MaGV.DataBindings.Add("Text", dgv_GiangVien.DataSource, "GiangVienID");
            txt_HoTen.DataBindings.Add("Text", dgv_GiangVien.DataSource, "HoTen");
            dt_NgaySinh.DataBindings.Add("Value", dgv_GiangVien.DataSource, "NgaySinh");
            cmb_GioiTinh.DataBindings.Add("Text", dgv_GiangVien.DataSource, "GioiTinh");
            txt_SoDT.DataBindings.Add("Text", dgv_GiangVien.DataSource, "SoDienThoai");
            txt_Email.DataBindings.Add("Text", dgv_GiangVien.DataSource, "Email");
        }

        private bool ValidateGiangVienInputs(bool isEdit = false)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txt_MaGV.Text) ||
                string.IsNullOrWhiteSpace(txt_HoTen.Text) ||
                string.IsNullOrWhiteSpace(txt_SoDT.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                string.IsNullOrWhiteSpace(cmb_GioiTinh.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra định dạng email bằng regex
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txt_Email.Text, emailPattern))
            {
                MessageBox.Show("Email không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra họ tên chỉ bao gồm các ký tự chữ cái và dấu, độ dài từ 3 đến 100 ký tự
            if (!Regex.IsMatch(txt_HoTen.Text, @"^[\p{L}\s]{3,100}$"))
            {
                MessageBox.Show("Họ tên giảng viên không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra độ dài chuỗi
            if (txt_MaGV.Text.Length > 10)
            {
                MessageBox.Show("Mã giảng viên không được dài quá 10 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            using (ManagementDB managementDB = new ManagementDB())
            {
                // Kiểm tra trùng lặp chỉ khi thêm mới
                if (!isEdit)
                {
                    if (managementDB.GiangViens.Any(gv => gv.GiangVienID == txt_MaGV.Text))
                    {
                        MessageBox.Show("Mã giảng viên đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                if (managementDB.GiangViens.Any(gv => gv.SoDienThoai == txt_SoDT.Text && gv.GiangVienID != txt_MaGV.Text))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (managementDB.GiangViens.Any(gv => gv.Email == txt_Email.Text && gv.GiangVienID != txt_MaGV.Text))
                {
                    MessageBox.Show("Email đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Tất cả kiểm tra đều hợp lệ
            return true;
        }

        private void frm_GiangVien_Load(object sender, EventArgs e)
        {
            cmb_GioiTinh.Items.Add("Nam");
            cmb_GioiTinh.Items.Add("Nữ");

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (ValidateGiangVienInputs())
            {
                using (ManagementDB managementDB = new ManagementDB())
                {
                    // Thêm giảng viên
                    GiangVien giangVien = new GiangVien
                    {
                        GiangVienID = txt_MaGV.Text,
                        HoTen = txt_HoTen.Text,
                        NgaySinh = DateTime.Parse(dt_NgaySinh.Text),
                        GioiTinh = cmb_GioiTinh.SelectedItem.ToString(),
                        SoDienThoai = txt_SoDT.Text,
                        Email = txt_Email.Text
                    };

                    managementDB.GiangViens.Add(giangVien);

                    // Tạo tài khoản cho giảng viên mới
                    TaiKhoan taiKhoan = new TaiKhoan
                    {
                        TaiKhoanID = "TK_" + txt_MaGV.Text, // ID tài khoản có thể thiết lập theo quy tắc riêng
                        Username = txt_MaGV.Text, // Tên đăng nhập có thể là ID giảng viên
                        Password = "123321", // Thiết lập mật khẩu mặc định hoặc tạo ngẫu nhiên
                        Role = "Giảng Viên", // Vai trò là Giảng Viên
                        GiangVienID = txt_MaGV.Text
                    };

                    managementDB.TaiKhoans.Add(taiKhoan);

                    try
                    {
                        managementDB.SaveChanges();
                        MessageBox.Show("Thêm giảng viên và tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGiangVien();
                        Binding();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (ValidateGiangVienInputs(true))
            {
                if (dgv_GiangVien.SelectedCells.Count >= 0)
                {
                    string selectedGiangVienID = dgv_GiangVien.SelectedCells[0].OwningRow.Cells["GiangVienID"].Value.ToString();

                    using (ManagementDB managementDB = new ManagementDB())
                    {
                        var SuaGiangVien = managementDB.GiangViens.FirstOrDefault(gv => gv.GiangVienID == selectedGiangVienID);
                        if (SuaGiangVien != null)
                        {
                            // Cập nhật thông tin sinh viên
                            SuaGiangVien.HoTen = txt_HoTen.Text;
                            SuaGiangVien.NgaySinh = dt_NgaySinh.Value;
                            SuaGiangVien.GioiTinh = cmb_GioiTinh.Text;
                            SuaGiangVien.SoDienThoai = txt_SoDT.Text;
                            SuaGiangVien.Email = txt_Email.Text;

                            managementDB.SaveChanges();

                            MessageBox.Show("Sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadGiangVien();
                            Binding();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            LoadGiangVien();
        }

        private void btn_ThemAdmin_Click(object sender, EventArgs e)
        {
            if (dgv_GiangVien.SelectedRows.Count >= 0)
            {
                string selectedGiangVienID = dgv_GiangVien.SelectedCells[0].OwningRow.Cells["GiangVienID"].Value.ToString();
                using (ManagementDB dB = new ManagementDB())
                {
                    var taiKhoan = dB.TaiKhoans.FirstOrDefault(tk => tk.GiangVienID == selectedGiangVienID);

                    if (taiKhoan != null)
                    {
                        taiKhoan.Role = "Admin";
                        dB.SaveChanges();
                        MessageBox.Show("Đã cấp quyền admin cho giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGiangVien();
                        Binding();
                    }
                    else
                    {
                        MessageBox.Show("Giảng viên không có tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một giảng viên để cấp quyền admin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string TimKiem = txt_TimKiem.Text.Trim();

            using (ManagementDB context = new ManagementDB())
            {
                var results = context.GiangViens
                    .Where(gv => gv.GiangVienID.Contains(TimKiem) ||
                                 gv.HoTen.Contains(TimKiem) ||
                                 gv.NgaySinh.ToString().Contains(TimKiem) ||
                                 gv.GioiTinh.Contains(TimKiem) ||
                                 gv.SoDienThoai.Contains(TimKiem) ||
                                 gv.Email.Contains(TimKiem))
                    .Select(gv => new
                    {
                        gv.GiangVienID,
                        gv.HoTen,
                        gv.NgaySinh,
                        gv.GioiTinh,
                        gv.SoDienThoai,
                        gv.Email
                    })
                    .ToList();

                if (results.Count > 0)
                {
                    dgv_GiangVien.DataSource = results;
                }
                else
                {
                    dgv_GiangVien.DataSource = null; // Clear DataGridView if no results
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_GiangVien.SelectedRows.Count >= 0)
            {
                string selectedGiangVienID = dgv_GiangVien.SelectedCells[0].OwningRow.Cells["GiangVienID"].Value.ToString();

                using (ManagementDB context = new ManagementDB())
                {
                    var taiKhoanToDelete = context.TaiKhoans.FirstOrDefault(tk => tk.GiangVienID == selectedGiangVienID);

                    // Kiểm tra nếu tài khoản là Admin
                    if (taiKhoanToDelete != null && taiKhoanToDelete.Role == "Admin")
                    {
                        MessageBox.Show("Không thể xóa tài khoản Admin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var result = MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var giangVienToDelete = context.GiangViens.FirstOrDefault(gv => gv.GiangVienID == selectedGiangVienID);

                        if (giangVienToDelete != null)
                        {
                            // Xóa tài khoản liên quan đến giảng viên
                            if (taiKhoanToDelete != null)
                            {
                                context.TaiKhoans.Remove(taiKhoanToDelete);
                            }

                            // Xóa giảng viên
                            context.GiangViens.Remove(giangVienToDelete);

                            context.SaveChanges();
                            MessageBox.Show("Xóa giảng viên và tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadGiangVien();
                            Binding();
                        }
                        else
                        {
                            MessageBox.Show("Giảng viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một giảng viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
