using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            _categoryDal.add(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDal.delete(category);
        }

        public Category GetByIdCategory(int id)
        {
            return _categoryDal.getById(id);
        }

        public List<Category> ListAllCategory()
        {
            return _categoryDal.listAll();
        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.update(category);
        }
    }
}
