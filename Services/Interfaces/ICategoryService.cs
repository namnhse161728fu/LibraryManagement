using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int id);
        void Create(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
