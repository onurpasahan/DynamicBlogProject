using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void AddCategory(Category category)
        {
            efCategoryRepository.add(category);
        }

        public void DeleteCategory(Category category)
        {
            efCategoryRepository.delete(category);
        }

        public Category GetByIdCategory(int id)
        {
            return efCategoryRepository.getById(id);
        }

        public List<Category> ListAllCategory()
        {
            return efCategoryRepository.listAll();
        }

        public void UpdateCategory(Category category)
        {
            efCategoryRepository.update(category);
        }
    }
}
