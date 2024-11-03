using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Models;

namespace GUI
{
    public partial class frm_Diem : Form
    {
        public frm_Diem()
        {
            InitializeComponent();
            LoadData();
            
        }

        private BindingSource bindingSource = new BindingSource();
        private void LoadData()
        {
            using (var context = new ManagementDB())
            {
                var query = from sv in context.SinhViens
                            join lop in context.Lops on sv.LopID equals lop.LopID
                            join khoa in context.Khoas on lop.KhoaID equals khoa.KhoaID
                            join mh in context.MonHocs on khoa.KhoaID equals mh.KhoaID
                            join diem in context.Diems on new { sv.SinhVienID, mh.MonHocID } equals new { diem.SinhVienID, diem.MonHocID } into sinhVienMonHocDiem
                            from svmh in sinhVienMonHocDiem.DefaultIfEmpty()
                            select new
                            {
                                sv.SinhVienID,
                                mh.MonHocID,
                                mh.TenMonHoc,
                                DiemHe10 = svmh.DiemSoHe10.ToString(),
                                DiemHe4 = svmh.DiemSoHe4.ToString(),
                                DiemChu = svmh.DiemChu
                            };
                bindingSource.DataSource = query.ToList();
                dgv_Diem.DataSource = bindingSource;
                dgv_Diem.Columns["MonHocID"].Visible = false; // Ẩn cột MonHocID
                Binding();
            }
        }

        private void Binding()
        {
            using (ManagementDB management = new ManagementDB())
            {
                txt_DiemHe10.DataBindings.Clear();
                lbl_MonHoc.DataBindings.Clear();
                txt_DiemHe10.DataBindings.Add("Text", dgv_Diem.DataSource, "DiemHe10");
                lbl_MonHoc.DataBindings.Add("Text", dgv_Diem.DataSource, "TenMonHoc");
            }
        }

        private float ConvertToHe4(float diemHe10)
        {
            if (diemHe10 >= 9.0f) return 4.0f;
            else if (diemHe10 >= 8.5f) return 4.0f;
            else if (diemHe10 >= 7.0f) return 3.0f;
            else if (diemHe10 >= 5.5f) return 2.0f;
            else if (diemHe10 >= 4.0f) return 1.0f;
            else return 0.0f;  
        }

        private string ConvertToDiemChu(float diemHe10)
        {
            if (diemHe10 >= 8.5f)return "A";             
            else if (diemHe10 >= 7.0f)return "B";              
            else if (diemHe10 >= 5.5f)return "C";              
            else if (diemHe10 >= 4.0f)return "D";
            else return "F";
        }

        private void KiemTraDiem(string sinhVienID)
        {
            using (var context = new ManagementDB())
            {
                var sinhVien = context.SinhViens.FirstOrDefault(sv => sv.SinhVienID == sinhVienID);
                if (sinhVien == null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var khoaID = sinhVien.KhoaID;
                var diemSinhViens = from monHoc in context.MonHocs
                                    join diem in context.Diems
                                        on new { MonHocID = monHoc.MonHocID, SinhVienID = sinhVienID } equals new { diem.MonHocID, diem.SinhVienID } into gj
                                    from subDiem in gj.DefaultIfEmpty()
                                    where monHoc.KhoaID == khoaID
                                    select new
                                    {
                                        sinhVien.SinhVienID,
                                        monHoc.MonHocID,
                                        monHoc.TenMonHoc,
                                        DiemHe10 = subDiem.DiemSoHe10.ToString(),
                                        DiemHe4 = subDiem.DiemSoHe4.ToString(),
                                        DiemChu = subDiem.DiemChu
                                    };

                dgv_Diem.DataSource = diemSinhViens.ToList();
                dgv_Diem.Columns["MonHocID"].Visible = false; // Ẩn cột MonHocID
                lbl_TSV.Text = sinhVien.HoTen;
                lbl_Khoa.Text = sinhVien.Khoa.TenKhoa;
                lbl_TenSV.Text = "Tên sinh viên:";

                MessageBox.Show("Đã hiển thị điểm của sinh viên.");
                Binding();
            }
        }

        private void NhapDiem(string sinhVienID, string monHocID, float diemHe10)
        {
            if (diemHe10 < 0 || diemHe10 > 10)
            {
                MessageBox.Show("Điểm hệ 10 phải nằm trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new ManagementDB())
            {
                var diem = new Diem
                {
                    // Không cần tự tạo DiemID nữa
                    SinhVienID = sinhVienID,
                    MonHocID = monHocID,
                    DiemSoHe10 = diemHe10,
                    DiemSoHe4 = ConvertToHe4(diemHe10),
                    DiemChu = ConvertToDiemChu(diemHe10)
                };

                context.Diems.Add(diem);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Lưu điểm thành công.");
                    LoadData(); // Làm mới dữ liệu sau khi lưu
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show(string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage));
                        }
                    }
                }
            }
        }

        private void SuaDiem(string sinhVienID, string monHocID, float diemHe10)
        {
            using (var context = new ManagementDB())
            {
                var diem = context.Diems.SingleOrDefault(d => d.SinhVienID == sinhVienID && d.MonHocID == monHocID);
                if (diem != null)
                {
                    diem.DiemSoHe10 = diemHe10;
                    diem.DiemSoHe4 = ConvertToHe4(diemHe10);
                    diem.DiemChu = ConvertToDiemChu(diemHe10);

                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("Sửa điểm thành công.");
                        LoadData(); // Làm mới dữ liệu sau khi lưu
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                    {
                        foreach (var validationErrors in ex.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                MessageBox.Show(string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage));
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy điểm để sửa.");
                }
            }
        }

        private void XoaDiem(string sinhVienID, string monHocID)
        {
            using (var context = new ManagementDB())
            {
                var diem = context.Diems.FirstOrDefault(d => d.SinhVienID == sinhVienID && d.MonHocID == monHocID);
                if (diem != null)
                {
                    context.Diems.Remove(diem);
                    context.SaveChanges();
                    MessageBox.Show("Xóa điểm thành công.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy điểm để xóa.");
                }
            }
        }

        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaSinhVien.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sinhVienID = txt_MaSinhVien.Text;
            KiemTraDiem(sinhVienID);

        }

        private void btn_NhapDiem_Click(object sender, EventArgs e)
        {

            if (dgv_Diem.SelectedCells.Count >= 0)
            {
                var selectedRow = dgv_Diem.SelectedCells[0].OwningRow;
                var monHocID = selectedRow.Cells["MonHocID"].Value.ToString();
                var sinhVienID = selectedRow.Cells["SinhVienID"].Value.ToString();

                if (float.TryParse(txt_DiemHe10.Text, out float diemHe10))
                {
                    NhapDiem(sinhVienID, monHocID, diemHe10);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập điểm hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học.");
            }
        }

        private void dgv_Diem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Diem.SelectedCells.Count > 0)
            {
                var selectedRow = dgv_Diem.SelectedCells[0].OwningRow.Cells["DiemHe10"].Value as string;

                if (string.IsNullOrEmpty(selectedRow) || selectedRow == "-")
                {
                    btn_NhapDiem.Enabled = true;
                    btn_Sua.Enabled = false;
                    txt_DiemHe10.Enabled = true;
                }
                else
                {
                    btn_NhapDiem.Enabled = false;
                    btn_Sua.Enabled = true;
                    txt_DiemHe10.Enabled = true;
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_Diem.SelectedCells.Count >= 0)
            {
                var selectedRow = dgv_Diem.SelectedCells[0].OwningRow;
                var monHocID = selectedRow.Cells["MonHocID"].Value.ToString();
                var sinhVienID = selectedRow.Cells["SinhVienID"].Value.ToString();

                if (float.TryParse(txt_DiemHe10.Text, out float diemHe10))
                {
                    SuaDiem(sinhVienID, monHocID, diemHe10);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập điểm hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học.");
            }
        }

        private void btn_XemDS_Click(object sender, EventArgs e)
        {
            LoadData();
            lbl_TenSV.Text = "  ";
            lbl_TSV.Text = "  ";
            lbl_Khoa.Text = "  ";
            txt_MaSinhVien.Text = "  ";
            txt_DiemHe10.Text = "  ";
        }

        private void btn_XoaDiem_Click(object sender, EventArgs e)
        {
            if (dgv_Diem.SelectedCells.Count > 0)
            {
                var selectedRow = dgv_Diem.SelectedCells[0].OwningRow;
                var monHocID = selectedRow.Cells["MonHocID"].Value.ToString();
                var sinhVienID = selectedRow.Cells["SinhVienID"].Value.ToString();
                XoaDiem(sinhVienID, monHocID);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng chứa điểm để xóa.");
            }
        }

        private void txt_DiemHe10_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự không phải là số, dấu chấm thập phân hoặc ký tự điều khiển (như backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ
            }

            // Kiểm tra nếu đã có dấu chấm thập phân trong TextBox
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true; // Ngăn chặn nếu đã có dấu chấm thập phân
            }

            // Kiểm tra giá trị nhập vào không vượt quá 10
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ',')
            {
                string input = (sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.KeyChar.ToString());

                if (float.TryParse(input, out float diem))
                {
                    if (diem > 10)
                    {
                        e.Handled = true; // Ngăn chặn giá trị vượt quá 10
                    }
                }
            }
        }

        private void txt_MaSinhVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_KiemTra_Click(this, new EventArgs());
            }
        }
    }
}
