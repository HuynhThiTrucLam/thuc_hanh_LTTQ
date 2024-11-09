using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsCore.Views.Sign_in;
using System.Security.Cryptography;
using System.Text;
using WinFormsCore.Models.Entities;
using WinFormsCore.Services;
namespace WinFormsCore.Views
{
    public partial class Sign_in : Form
    {
        private readonly AuthService _authService;
        private readonly ShopContext _context;
        public Sign_in(ShopContext context)
        {
            InitializeComponent();
            _context = context;
            _authService = new AuthService(context);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            // Lấy username và password từ textbox
            var username = tbx_username.Text;
            var password = tbx_password.Text;

            // Gọi phương thức login
            var account = _authService.Login(username, password);

            if (account != null)
            {
                // Kiểm tra role và điều hướng
                if (account.AccountRole == "Admin")
                {
                    //MessageBox.Show("Đăng nhập thành công với quyền admin!");
                    var productForm = new Product(_context);
                    this.Hide();
                    productForm.ShowDialog();
                }
                else if (account.AccountRole == "User")
                {
                    //MessageBox.Show("Đăng nhập thành công với quyền User!");
                    var productForm = new Product(_context);
                    this.Hide();
                    productForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập!");
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }
    }
}
