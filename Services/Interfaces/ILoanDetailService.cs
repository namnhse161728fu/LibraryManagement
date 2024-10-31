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
        LoanDetail Create(LoanDetail loanDetail);
        LoanDetail Update(LoanDetail loanDetail);
        bool Delete(LoanDetail loanDetail);
    }
}
