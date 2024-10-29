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
    public class StudentService : IStudentService
    {
        private IUnitOfWork _unitOfWork;

        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(Student student)
        {
            
            _unitOfWork.StudentRepository.Create(student);
            _unitOfWork.Complete();
        }

        public void Delete(Student student)
        {
            _unitOfWork.StudentRepository.Delete(student);
            _unitOfWork.Complete();
        }

        public List<Student> Filter(string id, string fullName, string email, string phone, string departmentId)
        {
            
            var query = _unitOfWork.StudentRepository.GetAll(s => s.Department).AsQueryable();
            if (!string.IsNullOrEmpty(id))
            {
                query = query.Where(s => s.StudentId.ToLower().Trim() == id.ToLower().Trim());
            }

            if (!string.IsNullOrEmpty(fullName))
            {
                query = query.Where(s => s.FullName.ToLower().Trim().Contains(fullName.ToLower().Trim()));
            }

            if (!string.IsNullOrEmpty(email))
            {
                query = query.Where(s => s.Email.ToLower().Trim().Contains(email.ToLower().Trim()));
            }

            if (!string.IsNullOrEmpty(phone))
            {
                query = query.Where(s => s.Phone.ToLower().Trim().Contains(phone.ToLower().Trim()));
            }

            if (!string.IsNullOrEmpty(departmentId))
            {
                query = query.Where(s => s.DepartmentId.ToLower().Trim() == departmentId.ToLower().Trim());
            }
            return query.ToList();
        }

        public List<Student> GetAll()
        {
            return _unitOfWork.StudentRepository.GetAll(s => s.Department).ToList();
        }

        public Student GetById(string id)
        {
            return _unitOfWork.StudentRepository.GetFirstOrDefault(s => s.StudentId == id, s => s.Department);
        }

        public void Update(Student student)
        {
            _unitOfWork.StudentRepository.Update(student);
            _unitOfWork.Complete();
        }
    }
}
