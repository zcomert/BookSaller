using BookSaller.DataAccess.Abstract;
using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Concrete.ADONET
{

    public class AdoBookDal : IBookDal
    {
        public void Add(Book book)
        {
            
        }

        public void Delete(Book entity)
        {
            throw new NotImplementedException();
        }

        public Book Get(Expression<Func<Book, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            return new List<Book>()
            {
                new Book(){ Id=1, Title="Ado.Net Öğreniyorum", UnitPrice=50},
                new Book(){ Id=2, Title="Ado.Net ile Tasarım", UnitPrice=40},
                new Book(){ Id=3, Title="Ado.Net Connections", UnitPrice=90}
            };
        }

        public List<Book> GetAll(Expression<Func<Book, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
