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
    public class LoanService : ILoanService
    {
        private IUnitOfWork _unitOfWork;

        public LoanService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Loan Create(Loan loan)
        {
            _unitOfWork.LoanRepository.Create(loan);
            _unitOfWork.Complete();
            return loan;
        }

        public bool Delete(Loan loan)
        {
            _unitOfWork.LoanRepository.Delete(loan);
            return _unitOfWork.Complete() > 0;
        }

        public List<Loan> GetAll()
        {
            return _unitOfWork.LoanRepository.GetAll().ToList();
        }

        public Loan GetById(int id)
        {
            return _unitOfWork.LoanRepository.GetFirstOrDefault(l => l.LoanId == id);
        }

        public Loan Update(Loan loan)
        {
            _unitOfWork.LoanRepository.Update(loan);
            _unitOfWork.Complete();
            return loan;
        }
    }
}
