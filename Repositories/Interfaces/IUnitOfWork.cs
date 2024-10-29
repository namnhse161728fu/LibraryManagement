using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Category> CategoryRepository { get; }
        IRepository<Book> BookRepository { get; }
        IRepository<Student> StudentRepository { get; }
        IRepository<Librarian> LibrarianRepository { get; }
        IRepository<Loan> LoanRepository { get; }
        IRepository<LoanDetail> LoanDetailRepository { get; }
        int Complete();
    }
}
