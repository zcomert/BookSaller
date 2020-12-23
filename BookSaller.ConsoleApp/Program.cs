using BookSaller.Business.Concrete;
using BookSaller.DataAccess.Concrete.EntityFramework;
using BookSaller.DataAccess.Concrete.ADONET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSaller.DataAccess.Concrete.NHibernate;

namespace BookSaller.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookManager = new BookManager(new NhBookDal());
            bookManager.GetAll().ForEach(b => Console.WriteLine(b));
            Console.ReadLine();
        }
    }
}
