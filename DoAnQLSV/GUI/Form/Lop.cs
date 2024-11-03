using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Models;

namespace GUI
{
    public partial class frm_Lop : Form
    {
        public frm_Lop()
        {
            InitializeComponent();
            LoadLop();
            Loadcmb_Khoa();
            Binding();
        }

        BindingSource BindingSource = new BindingSource();
        private void LoadLop()
        {
            using(ManagementDB management = new ManagementDB())
            {
                var Loplist = management.Lops.Select(lop => new
                {
                    lop.LopID,
                    lop.TenLop,
                    lop.Khoa.TenKhoa,
                    lop.SoSinhVien
                }).ToList();

                dgv_QLLop.DataSource = Loplist;
            }    
        }

        private void Binding()
        {
            txt_MaLop.DataBindings.Clear();
            txt_TenLop.DataBindings.Clear();
            cmb_Khoa.DataBindings.Clear();

            txt_MaLop.DataBindings.Add("Text", dgv_QLLop.DataSource, "lopID");
            txt_TenLop.DataBindings.Add("Text", dgv_QLLop.DataSource, "TenLop");
            cmb_Khoa.DataBindings.Add("Text", dgv_QLLop.DataSource, "TenKhoa");
        }

        private void Loadcmb_Khoa()
        {
            using(var management = new ManagementDB())
            {
                var khoa = management.Khoas.ToList();
                cmb_Khoa.DataSource = khoa;
                cmb_Khoa.ValueMember = "KhoaID";
                cmb_Khoa.DisplayMember = "TenKhoa";
            }    
        }

        private bool ValidateLopInputs(bool isEdit = false)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txt_MaLop.Text) ||
                string.IsNullOrWhiteSpace(txt_TenLop.Text) ||
                cmb_Khoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra tên lớp chỉ bao gồm các ký tự chữ cái và dấu, độ dài từ 3 đến 100 ký tự
            if (!Regex.IsMatch(txt_TenLop.Text, @"^[\p{L}\p{N}\s]{1,100}$"))
            {
                MessageBox.Show("Tên lớp chỉ được bao gồm các ký tự chữ cái và dấu, độ dài từ 3 đến 100 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra độ dài chuỗi
            if (txt_MaLop.Text.Length > 10)
            {
                MessageBox.Show("Mã lớp không được dài quá 10 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            using (ManagementDB managementDB = new ManagementDB())
            {
                // Kiểm tra trùng lặp chỉ khi thêm mới
                if (!isEdit)
                {
                    if (managementDB.Lops.Any(lop => lop.LopID == txt_MaLop.Text))
                    {
                        MessageBox.Show("Mã lớp đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    if (managementDB.Lops.Any(lop =>lop.TenLop == txt_TenLop.Text && lop.LopID != txt_MaLop.Text))
                    {
                        MessageBox.Show("Tên lớp đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            // Tất cả kiểm tra đều hợp lệ
            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(ValidateLopInputs())
            {
                using(ManagementDB managementDB = new ManagementDB())
                {
                    var lop = new Lop
                    {
                        LopID = txt_MaLop.Text,
                        TenLop = txt_TenLop.Text,
                        SoSinhVien = 0,
                        KhoaID = cmb_Khoa.SelectedValue.ToString()
                    };
                    managementDB.Lops.Add(lop);
                    try
                    {
                        managementDB.SaveChanges();
                        MessageBox.Show("Thêm lớp thành công", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information );
                        LoadLop();
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
            if (ValidateLopInputs(true))
            {
                if (dgv_QLLop.SelectedCells.Count >= 0)
                {
                    string selectedLopID = dgv_QLLop.SelectedCells[0].OwningRow.Cells["LopID"].Value.ToString();

                    try
                    {
                        using (ManagementDB managementDB = new ManagementDB())
                        {
                            var SuaLop = managementDB.Lops.FirstOrDefault(lp => lp.LopID == selectedLopID);

                            if (SuaLop != null)
                            {
                                // Cập nhật thông tin lớp
                                SuaLop.TenLop = txt_TenLop.Text;
                                SuaLop.KhoaID = cmb_Khoa.SelectedValue.ToString();

                                managementDB.SaveChanges();
                                MessageBox.Show("Sửa thông tin lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadLop();
                                Binding();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một lớp để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string TimKiem = txt_TimKiem.Text.Trim();

            using(ManagementDB managementDB = new ManagementDB())
            {
                var results = managementDB.Lops
                    .Where(lop => lop.LopID.Contains(TimKiem) ||
                                    lop.TenLop.Contains(TimKiem) ||
                                    lop.Khoa.TenKhoa.Contains(TimKiem))
                    .Select(lop => new
                    {
                        lop.LopID,
                        lop.TenLop,
                        khoa = lop.Khoa.TenKhoa
                    }).ToList();
                if(results.Count > 0)
                {
                    dgv_QLLop.DataSource = results;
                }
                else
                {
                    dgv_QLLop.DataSource = null;
                }
            }     
        }
    }
}
