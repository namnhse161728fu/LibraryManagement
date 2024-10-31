using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetById(string id);
        List<Student> Filter(string id, string fullName, string email, string phone, string departmentId);
        Student Create(Student student);
        Student Update(Student student);
        bool Delete(Student student);
    }
}
