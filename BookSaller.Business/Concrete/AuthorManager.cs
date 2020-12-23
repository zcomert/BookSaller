using BookSaller.Business.Abstract;
using BookSaller.DataAccess.Abstract;
using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public List<Author> GetAll()
        {
           return _authorDal.GetAll();
        }
    }
}
