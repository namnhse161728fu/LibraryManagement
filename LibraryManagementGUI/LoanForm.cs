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
    public partial class LoanForm : Form
    {
        public Dictionary<Book, int> SelectedBooks { get; set; }
        private ServiceProviders _serviceProviders;
        public Librarian CurrentLibrarian { get; set; } = null;
        private int? selectedBookId = null;
        private Student? selectedStudent = null;

        public LoanForm(ServiceProviders serviceProviders)
        {
            InitializeComponent();
            this.ControlBox = false;
            txtFullName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtDepartment.ReadOnly = true;
            SelectedBooks = new();
            _serviceProviders = serviceProviders;
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            if (CurrentLibrarian == null)
            {
                var libraryManagement = Program.CurrentScope.ServiceProvider.GetRequiredService<LibraryManagementForm>();
                CurrentLibrarian = libraryManagement.CurrentLibrarian;
            }
            FillDataGridView();
        }

        private void FillDataGridView()
        {

            DataTable table = new();
            table.Columns.Add("BookId", typeof(int));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Quantity", typeof(int));

            foreach (var sb in SelectedBooks)
            {
                table.Rows.Add(sb.Key.BookId, sb.Key.Title, sb.Value);
            }

            dgvBookLoan.DataSource = table;
            dgvBookLoan.Columns["BookId"].ReadOnly = true;
            dgvBookLoan.Columns["Title"].ReadOnly = true;

        }

        private bool validateQuantity(string input, out int quantity, out int bookId, int rowIndex)
        {
            bookId = (int)dgvBookLoan.Rows[rowIndex].Cells["BookId"].Value;
            if (!int.TryParse(input, out quantity) || quantity < 0)
            {
                MessageBox.Show("Quantity must be integer greater than 0");
                return false;
            }

            if (quantity > _serviceProviders.BookService.GetById(bookId).Quantity)
            {
                MessageBox.Show("Quantity of selected books exceeds available quantity!");
                return false;
            }
            return true;
        }

        private void dgvBookLoan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvBookLoan.Columns["Quantity"].Index && e.RowIndex >= 0)
            {
                var cellValue = dgvBookLoan.Rows[e.RowIndex].Cells["Quantity"].Value;
                string quantityValue = cellValue?.ToString().Trim() ?? string.Empty;
                int newQuantity, bookIdToChangeQuantity;
                bool isValid = validateQuantity(quantityValue, out newQuantity, out bookIdToChangeQuantity, e.RowIndex);
                if (isValid)
                {
                    var key = SelectedBooks.Keys.FirstOrDefault(k => k.BookId == bookIdToChangeQuantity);
                    if (key != null)
                    {
                        SelectedBooks[key] = newQuantity;
                    }
                }
                else
                {
                    dgvBookLoan.Rows[e.RowIndex].Cells["Quantity"].Value = SelectedBooks.Values.ElementAt(e.RowIndex);
                }
            }
        }

        private void dgvBookLoan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == dgvBookLoan.Columns["Quantity"].Index)
            {
                MessageBox.Show("Quantity must be integer greater than 0");
                e.ThrowException = false;
                if (e.ColumnIndex == dgvBookLoan.Columns["Quantity"].Index && e.RowIndex >= 0)
                {
                    dgvBookLoan.Rows[e.RowIndex].Cells["Quantity"].Value = SelectedBooks.Values.ElementAt(e.RowIndex);
                    dgvBookLoan.CancelEdit();
                }
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBookLoan.SelectedRows.Count == 0 || selectedBookId == null)
            {
                MessageBox.Show("No row selected!");
                return;
            }
            SelectedBooks.Remove(SelectedBooks.Keys.FirstOrDefault(k => k.BookId == selectedBookId));
            FillDataGridView();
        }

        private void dgvBookLoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookLoan.SelectedRows.Count > 0)
            {
                var cellValue = dgvBookLoan.SelectedRows[0].Cells["BookId"].Value;

                if (cellValue != DBNull.Value && cellValue != null)
                {
                    selectedBookId = (int)cellValue;
                }
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            SelectedBooks.Clear();
            FillDataGridView();
        }

        private void ResetLoan()
        {
            selectedStudent = null;
            txtFullName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtDepartment.Text = string.Empty;
            dtpDueDate.Value = DateTime.Now;
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            selectedStudent = _serviceProviders.StudentService.GetById(txtStudentId.Text.Trim());
            if (selectedStudent != null)
            {
                txtFullName.Text = selectedStudent.FullName;
                txtEmail.Text = selectedStudent.Email;
                txtPhone.Text = selectedStudent.Phone;
                txtDepartment.Text = selectedStudent.Department.DepartmentName;
            }
            else
            {
                ResetLoan();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtStudentId.Text = string.Empty;
            ResetLoan();
            SelectedBooks.Clear();
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (SelectedBooks.Count == 0 || selectedStudent == null)
            {
                MessageBox.Show("No book loaned or student selected");
                return;
            }
            _serviceProviders.LoanBooks(selectedStudent, SelectedBooks, CurrentLibrarian, dtpDueDate.Value);
            MessageBox.Show("Make book loan successfully");
            txtStudentId.Text = string.Empty;
            ResetLoan();
            SelectedBooks.Clear();
            this.Close();
        }
    }
}
