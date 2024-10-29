using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ILoanDetailService
    {
        List<LoanDetail> GetAll();
        LoanDetail GetById(int id);
        List<LoanDetail> GetByLoanId(int loanId);
        void Create(LoanDetail loanDetail);
        void Update(LoanDetail loanDetail);
        void Delete(LoanDetail loanDetail);
    }
}
