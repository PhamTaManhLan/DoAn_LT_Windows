using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using GUI.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI
{
    public partial class frm_SinhVien : Form
    {
        public frm_SinhVien()
        {
            InitializeComponent();
            LoadSinhVien();
            LoadComboBoxKhoa();
            Binding();
        }

        BindingSource bindingSource = new BindingSource();

        private void LoadSinhVien()
        {
            using (var student = new ManagementDB())
            {
                var studentlist = student.SinhViens.Select(sv => new
                {
                    sv.SinhVienID,
                    sv.HoTen,
                    sv.NgaySinh,
                    sv.GioiTinh,
                    sv.SoDienThoai,
                    sv.Khoa.TenKhoa,
                    sv.Lop.TenLop
                }).ToList();
                dgv_SinhVien.DataSource = studentlist;
            }
        }

        private void LoadComboBoxKhoa()
        {
            using (var managementDB = new ManagementDB())
            {
                var khoa = managementDB.Khoas.ToList();
                cmb_Khoa.DataSource = khoa;
                cmb_Khoa.DisplayMember = "TenKhoa";
                cmb_Khoa.ValueMember = "KhoaID";
            }
        }

        private void LoadComboBoxLop(string KhoaID)
        {
            using (var managementDB = new ManagementDB())
            {
                var lop = managementDB.Lops.Where(l => l.KhoaID == KhoaID).ToList();
                cmb_Lop.DataSource = lop;
                cmb_Lop.DisplayMember = "TenLop";
                cmb_Lop.ValueMember = "LopID";
            }
        }

        private void Binding()
        {
            txt_MaSinhVien.DataBindings.Clear();
            txt_HoTen.DataBindings.Clear();
            dt_NgaySinh.DataBindings.Clear();
            cmb_Khoa.DataBindings.Clear();
            cmb_GioiTinh.DataBindings.Clear();
            txt_SDT.DataBindings.Clear();
            cmb_Lop.DataBindings.Clear();

            txt_MaSinhVien.DataBindings.Add("Text", dgv_SinhVien.DataSource, "SinhVienID");
            txt_HoTen.DataBindings.Add("Text", dgv_SinhVien.DataSource, "HoTen");
            dt_NgaySinh.DataBindings.Add("Value", dgv_SinhVien.DataSource, "NgaySinh");
            cmb_Khoa.DataBindings.Add("Text", dgv_SinhVien.DataSource, "TenKhoa");
            cmb_GioiTinh.DataBindings.Add("Text", dgv_SinhVien.DataSource, "GioiTinh");
            txt_SDT.DataBindings.Add("Text", dgv_SinhVien.DataSource, "SoDienThoai");
            cmb_Lop.DataBindings.Add("Text", dgv_SinhVien.DataSource, "TenLop");
        }

        private bool ValidateSinhVienInputs(bool isEdit = false)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txt_MaSinhVien.Text) ||
                string.IsNullOrWhiteSpace(txt_HoTen.Text) ||
                string.IsNullOrWhiteSpace(txt_SDT.Text) ||
                string.IsNullOrWhiteSpace(cmb_GioiTinh.Text) ||
                string.IsNullOrWhiteSpace(cmb_Lop.Text) ||
                string.IsNullOrWhiteSpace(cmb_Khoa.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra họ tên chỉ bao gồm các ký tự chữ cái và dấu, độ dài từ 3 đến 100 ký tự
            if (!Regex.IsMatch(txt_HoTen.Text, @"^[\p{L}\s]{3,100}$"))
            {
                MessageBox.Show("Họ tên sinh viên không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra độ dài chuỗi
            if (txt_MaSinhVien.Text.Length > 10)
            {
                MessageBox.Show("Mã sinh viên không được dài quá 10 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            using (ManagementDB managementDB = new ManagementDB())
            {
                // Kiểm tra trùng lặp chỉ khi thêm mới
                if (!isEdit)
                {
                    if (managementDB.SinhViens.Any(sv => sv.SinhVienID == txt_MaSinhVien.Text))
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                if (managementDB.SinhViens.Any(sv => sv.SoDienThoai == txt_SDT.Text && sv.SinhVienID != txt_MaSinhVien.Text))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Tất cả kiểm tra đều hợp lệ
            return true;
        }

        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            cmb_GioiTinh.Items.Add("Nam");
            cmb_GioiTinh.Items.Add("Nữ");
        }

        private void cmb_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedKhoaID = cmb_Khoa.SelectedValue.ToString();
            LoadComboBoxLop(selectedKhoaID);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateSinhVienInputs())
            {
                using (ManagementDB managementDB = new ManagementDB())
                {
                    string selectedLopID = cmb_Lop.SelectedValue.ToString();

                    SinhVien sinhVien = new SinhVien
                    {
                        SinhVienID = txt_MaSinhVien.Text,
                        HoTen = txt_HoTen.Text,
                        NgaySinh = dt_NgaySinh.Value,
                        GioiTinh = cmb_GioiTinh.Text,
                        SoDienThoai = txt_SDT.Text,
                        LopID = selectedLopID,
                        KhoaID = cmb_Khoa.SelectedValue.ToString()
                    };
                    managementDB.SinhViens.Add(sinhVien);
                    var lop = managementDB.Lops.FirstOrDefault(l => l.LopID == selectedLopID);
                    if (lop != null)
                    {
                        lop.SoSinhVien += 1;
                    }

                    try
                    {
                        managementDB.SaveChanges();
                        MessageBox.Show("Thêm sinh viên thành công");
                        LoadSinhVien();
                        Binding();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ValidateSinhVienInputs(true))
            {
                if (dgv_SinhVien.SelectedCells.Count >= 0)
                {
                    string selectedStudentID = dgv_SinhVien.SelectedCells[0].OwningRow.Cells["SinhVienID"].Value.ToString();

                    using (ManagementDB managementDB = new ManagementDB())
                    {
                        var studentToEdit = managementDB.SinhViens.FirstOrDefault(sv => sv.SinhVienID == selectedStudentID);
                        if (studentToEdit != null)
                        {
                            // Cập nhật thông tin sinh viên
                            studentToEdit.HoTen = txt_HoTen.Text;
                            studentToEdit.NgaySinh = dt_NgaySinh.Value;
                            studentToEdit.GioiTinh = cmb_GioiTinh.Text;
                            studentToEdit.SoDienThoai = txt_SDT.Text;
                            studentToEdit.LopID = cmb_Lop.SelectedValue.ToString();
                            studentToEdit.KhoaID = cmb_Khoa.SelectedValue.ToString();

                            managementDB.SaveChanges();

                            MessageBox.Show("Sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSinhVien();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv_SinhVien.SelectedCells.Count > 0)
            {
                string selectedSinhVienID = dgv_SinhVien.SelectedCells[0].OwningRow.Cells["SinhVienID"].Value.ToString();
                string selectedLopID = dgv_SinhVien.SelectedCells[0].OwningRow.Cells["TenLop"].Value.ToString();

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (ManagementDB managementDB = new ManagementDB())
                        {
                            var sinhVien = managementDB.SinhViens.FirstOrDefault(sv => sv.SinhVienID == selectedSinhVienID);
                            var lop = managementDB.Lops.FirstOrDefault(lp => lp.TenLop == selectedLopID);

                            if (sinhVien != null)
                            {
                                if (lop != null)
                                {
                                    var diemList = managementDB.Diems.Where(d => d.SinhVienID == selectedSinhVienID).ToList();
                                    managementDB.Diems.RemoveRange(diemList);
                                    managementDB.SinhViens.Remove(sinhVien);
                                    lop.SoSinhVien -= 1;
                                    managementDB.SaveChanges();

                                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadSinhVien();
                                    Binding();
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string TimKiem = txt_TimKiem.Text.Trim();

            using (ManagementDB context = new ManagementDB())
            {
                var results = context.SinhViens
                    .Where(sv => sv.SinhVienID.Contains(TimKiem) ||
                                 sv.HoTen.Contains(TimKiem) ||
                                 sv.NgaySinh.ToString().Contains(TimKiem) ||
                                 sv.GioiTinh.Contains(TimKiem) ||
                                 sv.SoDienThoai.Contains(TimKiem) ||
                                 sv.Khoa.TenKhoa.Contains(TimKiem) ||
                                 sv.Lop.TenLop.Contains(TimKiem))
                    .Select(sv => new
                    {
                        sv.SinhVienID,
                        sv.HoTen,
                        sv.NgaySinh,
                        sv.GioiTinh,
                        sv.SoDienThoai,
                        Khoa = sv.Khoa.TenKhoa,
                        Lop = sv.Lop.TenLop
                    }).ToList();

                if (results.Count > 0)
                {
                    dgv_SinhVien.DataSource = results;
                }
                else
                {
                    dgv_SinhVien.DataSource = null;
                }

            }
        }
    }
}
