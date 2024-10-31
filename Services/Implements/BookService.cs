using Repositories.Implements;
using Repositories.Interfaces;
using Repositories.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implements
{
    public class BookService : IBookService
    {
        private IUnitOfWork _unitOfWork;
        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Book Create(Book book)
        {
            _unitOfWork.BookRepository.Create(book);
            _unitOfWork.Complete();
            return book;
        }

        public bool Delete(Book book)
        {
            _unitOfWork.BookRepository.Delete(book);
            return _unitOfWork.Complete() > 0;
        }

        public List<Book> FilterBook(string title, string author, int categoryId)
        {
            var query = _unitOfWork.BookRepository.GetAll(b => b.Category).AsQueryable();
            if (!string.IsNullOrEmpty(title))
            {
                query = query.Where(b => b.Title.ToLower().Trim().Contains(title.Trim().ToLower()));
            }
            if (!string.IsNullOrEmpty(author))
            {
                query = query.Where(b => b.Author.ToLower().Trim().Contains(author.Trim().ToLower()));
            }
            if (categoryId > 0)
            {
                query = query.Where(b => b.CategoryId == categoryId);
            }
            return query.ToList();
        }

        public List<Book> GetAll()
        {
            return _unitOfWork.BookRepository.GetAll(b => b.Category).ToList();
        }

        public Book GetById(int id)
        {
            return _unitOfWork.BookRepository.GetFirstOrDefault(b => b.BookId == id, b => b.Category);
        }

        public Book Update(Book book)
        {
            _unitOfWork.BookRepository.Update(book);
            _unitOfWork.Complete();
            return book;
        }
    }
}
