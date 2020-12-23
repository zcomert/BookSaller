using BookSaller.Business.Concrete;
using BookSaller.DataAccess.Concrete.EntityFramework;
using BookSaller.DataAccess.Concrete.ADONET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSaller.DataAccess.Concrete.NHibernate;
using BookSaller.Entities.Concrete;

namespace BookSaller.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookManager = new BookManager(new EfBookDal());
            var authorManager = new AuthorManager(new EfAuthorDal());
            var publisherManager = new PublisherManager(new EfPublisherDal());

            authorManager.GetAll().ForEach(a => Console.WriteLine(a));
            publisherManager.GetAll().ForEach(p => Console.WriteLine(p));
            

            var book = new Book() { Id = 1, Title = "İstanbul", UnitPrice = 25 };
            bookManager.Add(book);
            
            bookManager.GetAll().ForEach(b => Console.WriteLine(b));
            Console.ReadLine();
        }
    }
}
