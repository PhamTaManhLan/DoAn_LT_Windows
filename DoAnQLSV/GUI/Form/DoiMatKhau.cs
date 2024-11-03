using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Models;

namespace GUI
{
    public partial class frm_DoiMatKhau : Form
    {
        TaiKhoan tk;
        public frm_DoiMatKhau(TaiKhoan taikhoan)
        {
            tk = taikhoan;
            InitializeComponent();
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            string matKhauHienTai = txt_MkHienTai.Text;
            string matKhauMoi = txt_MkMoi.Text;
            string xacNhanMatKhauMoi = txt_XacNhanMk.Text;

            if (matKhauMoi != xacNhanMatKhauMoi)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu mới không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new ManagementDB())
            {
                var user = context.TaiKhoans.FirstOrDefault(u => u.Username == tk.Username && u.Password == matKhauHienTai);
                if (user != null)
                {
                    user.Password = matKhauMoi;

                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Đóng form sau khi đổi mật khẩu thành công
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi đổi mật khẩu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
