using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Models;

namespace GUI
{
    public partial class frm_MonHoc : Form
    {
        public frm_MonHoc()
        {
            InitializeComponent();
            LoadMonHocData();
            Loadcmb_Khoa();
            Loadcmb_Loc();
        }

        private void Loadcmb_Khoa()
        {
            using (var managementDB = new ManagementDB())
            {
                var khoa = managementDB.Khoas.ToList();
                cmb_Khoa.DataSource = khoa;
                cmb_Khoa.DisplayMember = "TenKhoa";
                cmb_Khoa.ValueMember = "KhoaID";
            }
        }
        private void LoadMonHocData()
        {
            using (var monhoc = new ManagementDB())
            {
                var monhoclist = monhoc.MonHocs.Select(mh =>new 
                {
                    mh.MonHocID,
                    mh.TenMonHoc,
                    mh.SoTinChi,
                    mh.Khoa.TenKhoa
                }).ToList();
                dgv_MonHoc.DataSource = monhoclist;
            }    
        }

        BindingSource bindingSource = new BindingSource();
        private void Binding()
        {
            txt_MaMonHoc.DataBindings.Clear();
            txt_TenMonHoc.DataBindings.Clear();
            txt_SoTinChi.DataBindings.Clear();
            cmb_Khoa.DataBindings.Clear();

            txt_MaMonHoc.DataBindings.Add("Text", dgv_MonHoc.DataSource, "MonHocID");
            txt_TenMonHoc.DataBindings.Add("Text", dgv_MonHoc.DataSource, "TenMonHoc");
            txt_SoTinChi.DataBindings.Add("Text", dgv_MonHoc.DataSource, "SoTinChi");
            cmb_Khoa.DataBindings.Add("Text", dgv_MonHoc.DataSource, "TenKhoa");
        }

        private void Loadcmb_Loc()
        {
            cmb_Loc.Items.Add("Lọc theo tín chỉ");
            cmb_Loc.Items.Add("Môn học 3 tín chỉ");
            cmb_Loc.Items.Add("Môn học 2 tín chỉ");
            cmb_Loc.Items.Add("Môn học 1 tín chỉ");
        }

        private bool ValidateMonHocInputs(bool isEdit = false)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txt_MaMonHoc.Text) ||
                string.IsNullOrWhiteSpace(txt_TenMonHoc.Text) ||
                string.IsNullOrWhiteSpace(txt_SoTinChi.Text) ||
                cmb_Khoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra họ tên chỉ bao gồm các ký tự chữ cái và dấu, độ dài từ 3 đến 100 ký tự
            if (!Regex.IsMatch(txt_TenMonHoc.Text, @"^[\p{L}\p{N}\p{P}\p{S}\s]+$"))
            {
                MessageBox.Show("Tên môn học không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra kiểu dữ liệu cho số tín chỉ
            if (!int.TryParse(txt_SoTinChi.Text, out int soTinChi) || soTinChi <= 0)
            {
                MessageBox.Show("Số tín chỉ phải là một số nguyên dương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra trùng lặp MonHocID (Chỉ thực hiện kiểm tra này khi thêm mới, không phải khi sửa)
            if (!isEdit)
            {
                using (ManagementDB managementDB = new ManagementDB())
                {
                    if (managementDB.MonHocs.Any(mh => mh.MonHocID == txt_MaMonHoc.Text))
                    {
                        MessageBox.Show("Mã môn học đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            return true; // Tất cả các kiểm tra đều hợp lệ
        }

        private void LocTheoSoTinChi(int soTinChi)
        {
            using (var context = new ManagementDB())
            {
                var monHocs = context.MonHocs
                                     .Where(mh => mh.SoTinChi == soTinChi)
                                     .Select(mh => new
                                     {
                                         mh.MonHocID,
                                         mh.TenMonHoc,
                                         mh.SoTinChi,
                                         mh.KhoaID
                                     })
                                     .ToList();

                dgv_MonHoc.DataSource = monHocs;
            }
        }

        private void frm_MonHoc_Load(object sender, EventArgs e)
        {
            cmb_Loc.SelectedIndex = 0;
            Binding();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (ValidateMonHocInputs(false))
            {
                using (ManagementDB managementDB = new ManagementDB())
                {
                    MonHoc monHoc = new MonHoc
                    {
                        MonHocID = txt_MaMonHoc.Text,
                        TenMonHoc = txt_TenMonHoc.Text,
                        SoTinChi = int.Parse(txt_SoTinChi.Text),
                        KhoaID = cmb_Khoa.SelectedValue.ToString()    
                    };
                    managementDB.MonHocs.Add(monHoc);
                    try
                    {
                        managementDB.SaveChanges();
                        MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMonHocData(); // Tải lại danh sách môn học
                    }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    } 
                }    
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_MaMonHoc.Text) && ValidateMonHocInputs(true))
            {
                using (ManagementDB managementDB = new ManagementDB())
                {
                    var monHocToEdit = managementDB.MonHocs.FirstOrDefault(mh => mh.MonHocID == txt_MaMonHoc.Text);
                    if (monHocToEdit != null)
                    {

                        try
                        {
                            // Cập nhật thông tin môn học
                            monHocToEdit.TenMonHoc = txt_TenMonHoc.Text;
                            monHocToEdit.SoTinChi = int.Parse(txt_SoTinChi.Text);
                            monHocToEdit.KhoaID = cmb_Khoa.SelectedValue.ToString();

                            managementDB.SaveChanges();
                            MessageBox.Show("Sửa thông tin môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadMonHocData(); // Tải lại danh sách môn học
                            Binding();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi cập nhật môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Môn học không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một môn học để sửa và điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_MaMonHoc.Text))
            {
                using (ManagementDB managementDB = new ManagementDB())
                {
                    var monHocToDelete = managementDB.MonHocs.FirstOrDefault(mh => mh.MonHocID == txt_MaMonHoc.Text);
                    if (monHocToDelete != null)
                    {
                        try
                        {
                            // Xóa môn học
                            managementDB.MonHocs.Remove(monHocToDelete);
                            managementDB.SaveChanges();
                            MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadMonHocData(); // Tải lại danh sách môn học
                            Binding();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi xóa môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Môn học không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một môn học để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmb_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = cmb_Loc.SelectedItem.ToString();
            
            if (selectedValue == "Lọc theo tín chỉ")
            {
                LoadMonHocData();
                Binding();
            }
            else
            {
                int soTinChi;
                // Xác định số tín chỉ từ lựa chọn trong ComboBox
                switch (selectedValue)
                {
                    case "Môn học 3 tín chỉ":
                        soTinChi = 3;
                        break;
                    case "Môn học 2 tín chỉ":
                        soTinChi = 2;
                        break;
                    case "Môn học 1 tín chỉ":
                        soTinChi = 1;
                        break;
                    default:
                        soTinChi = 0;
                        break;
                }

                LocTheoSoTinChi(soTinChi);
                Binding();
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string TimKiem = txt_TimKiem.Text.Trim();

            using(ManagementDB context = new ManagementDB())
            {
                var results = context.MonHocs
                    .Where(mh => mh.MonHocID.Contains(TimKiem) ||
                                 mh.TenMonHoc.Contains(TimKiem))
                    .Select(mh => new
                    {
                        mh.MonHocID,
                        mh.TenMonHoc,
                        mh.SoTinChi
                    }).ToList();
                
                if(results.Count > 0)
                {
                    dgv_MonHoc.DataSource = results;
                }
                else
                {
                    dgv_MonHoc.DataSource = null;
                }
            }    
        }
    }
}
