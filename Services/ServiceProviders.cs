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
        private IBookService _bookService;
        private IStudentService _studentService;
        private ILoanService _loanService;
        private ILoanDetailService _loanDetailService;
        private ICategoryService _categoryService;
        private ILibrarianService _librarianService;

        public ServiceProviders(ICategoryService categoryService, IBookService bookService, IStudentService studentService, ILoanService loanService, ILoanDetailService loanDetailService, ILibrarianService librarianService)
        {
            _categoryService = categoryService;
            _bookService = bookService;
            _studentService = studentService;
            _loanService = loanService;
            _loanDetailService = loanDetailService;
            _librarianService = librarianService;
        }

        public Librarian Authenticate(string email, string password)
            => _librarianService.Authenticate(email, password);
    }
}
