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
using BookSaller.Business.DependencyResolvers.Ninject;
using BookSaller.Business.Abstract;


namespace BookSaller.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IoC oncesi
            /*
            var bookManager = new BookManager(new EfBookDal());
            var authorManager = new AuthorManager(new EfAuthorDal());
            var publisherManager = new PublisherManager(new EfPublisherDal());

            authorManager.GetAll().ForEach(a => Console.WriteLine(a));
            publisherManager.GetAll().ForEach(p => Console.WriteLine(p));
            

            var book = new Book() { Id = 1, Title = "İstanbul", UnitPrice = 25 };
            bookManager.Add(book);
            
            bookManager.GetAll().ForEach(b => Console.WriteLine(b));
            */
            #endregion

            var bookService = InstanceFactory.GetInstance<IBookService>();
            var bookList = bookService.GetAll();
            
            bookList.ForEach(b => Console.WriteLine(b));

            try
            {
                var book = new Book() { Id = 1, 
                    Title = "Otitis media diagnosis", 
                    UnitPrice = 15 };
                bookService.Add(book);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
