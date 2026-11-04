using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class CommentRepository : IGenericDal<Comment>
    {
        public void add(Comment t)
        {
            throw new NotImplementedException();
        }

        public void delete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> listAll()
        {
            throw new NotImplementedException();
        }

        public void update(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}