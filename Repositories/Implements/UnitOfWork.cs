using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implements
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryManagementContext _context;
        
        public UnitOfWork(LibraryManagementContext context)
        {
            _context = context;
            CategoryRepository = new Repository<Category>(_context);
            BookRepository = new Repository<Book>(_context);
            StudentRepository = new Repository<Student>(_context);
            LibrarianRepository = new Repository<Librarian>(_context);
            LoanRepository = new Repository<Loan>(_context);
            LoanDetailRepository = new Repository<LoanDetail>(_context);
        }

        public IRepository<Category> CategoryRepository { get; private set; }

        public IRepository<Book> BookRepository { get; private set; }

        public IRepository<Student> StudentRepository { get; private set; }

        public IRepository<Librarian> LibrarianRepository { get; private set; }

        public IRepository<Loan> LoanRepository { get; private set; }

        public IRepository<LoanDetail> LoanDetailRepository  { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
           _context.Dispose();
        }

        //private bool disposed = false;

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            _context.Dispose();
        //        }
        //    }
        //    this.disposed = true;
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
    }
}
