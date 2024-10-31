using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ILoanService
    {
        List<Loan> GetAll();
        Loan GetById(int id);
        Loan Create(Loan loan);
        Loan Update(Loan loan);
        bool Delete(Loan loan);
    }
}
