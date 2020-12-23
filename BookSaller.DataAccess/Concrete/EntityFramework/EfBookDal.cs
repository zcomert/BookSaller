using BookSaller.DataAccess.Abstract;
using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : IBookDal
    {
        public void Add(Book book)
        {
           
        }

        public List<Book> GetAll()
        {
            return new List<Book>()
            {
                new Book(){ Id=1, Title="EF Öğreniyorum", UnitPrice=150},
                new Book(){ Id=2, Title="EF ile Tasarım", UnitPrice=140},
                new Book(){ Id=3, Title="EF Connections", UnitPrice=190}
            };
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
