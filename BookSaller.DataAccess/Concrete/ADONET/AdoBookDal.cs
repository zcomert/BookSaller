using BookSaller.DataAccess.Abstract;
using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Concrete.ADONET
{
    public class AdoBookDal : IBookDal
    {
        public void Add(Book book)
        {
            
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

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
