using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        Context c = new Context();

        public void add(Blog t)
        {
            throw new NotImplementedException();
        }

        public void AddBlog(Blog blog)
        {
            c.Add(blog);
            c.SaveChanges();
        }

        public void delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog getById(int id)
        {
            throw new NotImplementedException();
        }

        public Blog GetByIdBlog(int id)
        {
            return c.Blogs.Find(id);
        }

        public List<Blog> listAll()
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAllBlog()
        {
            return c.Blogs.ToList();
        }

        public void update(Blog t)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            c.Update(blog);
            c.SaveChanges();
        }
    }
}

