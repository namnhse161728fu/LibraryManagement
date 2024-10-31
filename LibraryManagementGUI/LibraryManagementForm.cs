using Microsoft.Extensions.DependencyInjection;
using Repositories.Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementGUI
{
    public partial class LibraryManagementForm : Form
    {
        private ServiceProviders _serviceProviders;
        private Book _selectedBook = null;
        public Librarian CurrentLibrarian { get; set; }
        private LoanForm _loanForm;

        public LibraryManagementForm(ServiceProviders serviceProviders)
        {
            InitializeComponent();
            _serviceProviders = serviceProviders;
            _loanForm = new LoanForm(serviceProviders);
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
            FillDataGridView(_serviceProviders.BookService.GetAll());
            var categoryList = _serviceProviders.CategoryService.GetAll();
            categoryList.Insert(0, new Category { CategoryId = 0, CategoryName = "Select category" });
            cboCategory.DataSource = categoryList;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryId";
        }

        private void FillDataGridView(List<Book> list)
        {
            dgvBookList.DataSource = list.Select(b => new
            {
                BookId = b.BookId,
                Title = b.Title,
                Author = b.Author,
                Category = b.Category.CategoryName,
                PublishedDate = b.PublishedDate,
                Quantity = b.Quantity
            }).ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillDataGridView(_serviceProviders.BookService.FilterBook(txtTitle.Text, txtAuthor.Text, (int)cboCategory.SelectedValue));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTitle.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            cboCategory.SelectedIndex = 0;
            FillDataGridView(_serviceProviders.BookService.GetAll());
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                var selectedBookId = int.Parse(dgvBookList.SelectedRows[0].Cells["BookId"].Value.ToString());
                _selectedBook = _serviceProviders.BookService.GetById(selectedBookId);
            }
        }

        private void btnAddToLoan_Click(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count == 0 || _selectedBook == null)
            {
                MessageBox.Show("No row selected!");
                return;
            }
            
            if (_selectedBook.Quantity == 0)
            {
                MessageBox.Show("Quantity is out!");
                return;
            }

            if (_loanForm.SelectedBooks.ContainsKey(_selectedBook))
            {
                if (_loanForm.SelectedBooks[_selectedBook] < _selectedBook.Quantity)
                {
                    _loanForm.SelectedBooks[_selectedBook]++;
                }
                else
                {
                    MessageBox.Show("Quantity of selected books exceeds available quantity!");
                    return;
                }
            }
            else
            {
                _loanForm.SelectedBooks.Add(_selectedBook, 1);
            }
        }

        private void btnBookLoan_Click(object sender, EventArgs e)
        {
            _loanForm.ShowDialog();
            FillDataGridView(_serviceProviders.BookService.GetAll());
        }
    }
}
