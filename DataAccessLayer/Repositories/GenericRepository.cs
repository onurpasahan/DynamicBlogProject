using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();
        public void add(T t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public void delete(T t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public T getById(int id)
        {
             return c.Find<T>(id);
        }

        public List<T> listAll()
        {
            return c.Set<T>().ToList();
        }

        public void update(T t)
        {
            c.Update(t);
            c.SaveChanges();
        }
    }
}