using BookSaller.DataAccess.Abstract;
using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Concrete.NHibernate
{
    public class NhBookDal : IBookDal
    {
        public void Add(Book book)
        {
            //TODO
        }

        public void Delete(Book book)
        {
            //TODO
        }

        public List<Book> GetAll()
        {
            return new List<Book>()
            {
                new Book(){ Id=1, Title="Nh Öğreniyorum", UnitPrice=10},
                new Book(){ Id=2, Title="Nh ile Tasarım", UnitPrice=12},
                new Book(){ Id=3, Title="Nh Connections", UnitPrice=15}
            };
        }

        public void Update(Book book)
        {
            //TODO
        }
    }
}
