using Microsoft.Extensions.DependencyInjection;
using Repositories.Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementGUI
{
    public partial class LibraryManagementForm : Form
    {
        private ServiceProviders _serviceProviders;
        public Librarian CurrentLibrarian { get; set; }

        public LibraryManagementForm(ServiceProviders serviceProviders)
        {
            InitializeComponent();
            _serviceProviders = serviceProviders;
        }

        private void mntrLogout_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại, kích hoạt FormClosed trong LoginForm để giải phóng scope
            this.Close();
        }

        private void LibraryManagementForm_Load(object sender, EventArgs e)
        {
            txtCurrentLibrarian.ReadOnly = true;
            txtCurrentLibrarian.Text = CurrentLibrarian.FullName;
        }
    }
}
