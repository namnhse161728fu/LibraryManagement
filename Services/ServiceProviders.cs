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

    }
}
