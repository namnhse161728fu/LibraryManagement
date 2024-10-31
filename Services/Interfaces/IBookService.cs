using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IBookService
    {
        List<Book> GetAll();
        List<Book> FilterBook(string title, string author, int categoryId);
        Book GetById(int id);
        Book Create(Book book);
        Book Update(Book book);
        bool Delete(Book book);
    }
}
