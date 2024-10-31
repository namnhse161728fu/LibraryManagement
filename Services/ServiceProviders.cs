using Microsoft.Extensions.DependencyInjection;
using Repositories.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceProviders
    {
        public IBookService BookService { get; }
        public IStudentService StudentService { get; }
        public ILoanService LoanService { get; }
        public ILoanDetailService LoanDetailService { get; }
        public ICategoryService CategoryService { get; }
        public ILibrarianService LibrarianService { get; }

        public ServiceProviders(ICategoryService categoryService, IBookService bookService, IStudentService studentService, ILoanService loanService, ILoanDetailService loanDetailService, ILibrarianService librarianService)
        {
            CategoryService = categoryService;
            BookService = bookService;
            StudentService = studentService;
            LoanService = loanService;
            LoanDetailService = loanDetailService;
            LibrarianService = librarianService;
        }

        public void LoanBooks(Student student, Dictionary<Book, int> selectedBooks, Librarian librarian, DateTime dueDate)
        {
            var newLoan = new Loan();
            newLoan.StudentId = student.StudentId;
            newLoan.LibrarianId = librarian.LibrarianId;
            newLoan.LoanDate = DateTime.Now;
            var savedLoan = LoanService.Create(newLoan);
            foreach (var sb in selectedBooks)
            {
                LoanDetailService.Create(new LoanDetail()
                {
                    BookId = sb.Key.BookId,
                    LoanId = savedLoan.LoanId,
                    Status = true,
                    DueDate = dueDate,
                });
                var bookToUpdate = BookService.GetById(sb.Key.BookId);
                bookToUpdate.Quantity -= sb.Value;
                BookService.Update(bookToUpdate);
            }
        }
    }
}
