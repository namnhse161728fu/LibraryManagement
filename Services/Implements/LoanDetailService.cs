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
    public class LoanDetailService : ILoanDetailService
    {
        private IUnitOfWork _unitOfWork;

        public LoanDetailService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public LoanDetail Create(LoanDetail loanDetail)
        {
            _unitOfWork.LoanDetailRepository.Create(loanDetail);
            _unitOfWork.Complete();
            return loanDetail;
        }

        public bool Delete(LoanDetail loanDetail)
        {
            _unitOfWork.LoanDetailRepository.Delete(loanDetail);
            return _unitOfWork.Complete() > 0;
        }

        public List<LoanDetail> GetAll()
        {
            return _unitOfWork.LoanDetailRepository.GetAll().ToList();
        }

        public LoanDetail GetById(int id)
        {
            return _unitOfWork.LoanDetailRepository.GetFirstOrDefault(ld => ld.LoanDetailId == id);
        }

        public List<LoanDetail> GetByLoanId(int loanId)
        {
            return _unitOfWork.LoanDetailRepository.GetWhere(ld => ld.LoanId == loanId).ToList();
        }

        public LoanDetail Update(LoanDetail loanDetail)
        {
            _unitOfWork.LoanDetailRepository.Update(loanDetail);
            _unitOfWork.Complete();
            return loanDetail;
        }
    }
}
