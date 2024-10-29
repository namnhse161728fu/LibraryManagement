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
    public class DepartmentService : IDepartmentService
    {
        private IUnitOfWork _unitOfWork;

        public DepartmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Department> GetAll()
        {
            return _unitOfWork.DepartmentRepository.GetAll().ToList();
        }

        public Department GetById(string id)
        {
            return _unitOfWork.DepartmentRepository.GetFirstOrDefault(d => d.DepartmentId == id);
        }
    }
}
