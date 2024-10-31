using Microsoft.Extensions.DependencyInjection;
using Repositories.Models;
using Services;

namespace LibraryManagementGUI
{
    public partial class LoginForm : Form
    {
        private ServiceProviders _serviceProviders;
        public LoginForm(ServiceProviders serviceProviders) 
        {
            InitializeComponent();
            _serviceProviders = serviceProviders;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var librarian = _serviceProviders.LibrarianService.Authenticate(txtEmail.Text.Trim(), txtPassword.Text.Trim());
            if (librarian == null)
            {
                MessageBox.Show("Invalid email or password");
                return;
            }

            // Tạo scope mới cho phiên làm việc
            Program.CurrentScope?.Dispose(); // Đảm bảo scope cũ được hủy trước khi tạo mới
            Program.CurrentScope = Program.serviceProvider.CreateScope();

            // Tạo instance của LibraryManagementForm từ scope mới
            var libraryManagement = Program.CurrentScope.ServiceProvider.GetRequiredService<LibraryManagementForm>();
            libraryManagement.CurrentLibrarian = librarian;  // Truyền Librarian vào LibraryManagementForm
            libraryManagement.FormClosed += LibraryManagement_FormClosed; // Xử lý khi đóng form (logout)

            libraryManagement.Show();
            this.Hide();
        }

        private void LibraryManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Đóng scope hiện tại khi form này được đóng (logout)
            Program.CurrentScope?.Dispose();
            Program.CurrentScope = null;

            // Hiển thị lại LoginForm
            this.Show();
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
