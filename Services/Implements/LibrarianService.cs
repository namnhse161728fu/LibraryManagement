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
    public class LibrarianService : ILibrarianService
    {
        private IUnitOfWork _unitOfWork;

        public LibrarianService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Librarian Authenticate(string email, string password)
        {
            return _unitOfWork.LibrarianRepository.GetFirstOrDefault(lb => lb.Email == email && lb.Password == password);
        }
    }
}
