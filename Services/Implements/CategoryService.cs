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
    public class CategoryService : ICategoryService
    {
        private IUnitOfWork _unitOfWork;
        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(Category category)
        {
            _unitOfWork.CategoryRepository.Create(category);
            _unitOfWork.Complete();
        }

        public void Delete(Category category)
        {
            _unitOfWork.CategoryRepository.Delete(category);
            _unitOfWork.Complete();
        }

        public List<Category> GetAll()
        {
            return _unitOfWork.CategoryRepository.GetAll().ToList();
        }

        public Category GetById(int id)
        {
            return _unitOfWork.CategoryRepository.GetFirstOrDefault(c => c.CategoryId == id);
        }

        public void Update(Category category)
        {
            _unitOfWork.CategoryRepository.Update(category);
            _unitOfWork.Complete();
        }

    }
}
