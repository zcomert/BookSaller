using BookSaller.Business.Abstract;
using BookSaller.Business.Utilities;
using BookSaller.Business.ValidationRules.FluentValidation;
using BookSaller.DataAccess.Abstract;
using BookSaller.Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        /* ASPECT ORIENTED PROGRAMMING */
        /* [ValidateTool(typeof(BookValidator))] */ 
        public void Add(Book book)
        {
            ValidationTool.Validate(new BookValidator(), book);
            _bookDal.Add(book);
        }

        public List<Book> GetAll()
        {
           return _bookDal.GetAll();
        }
    }
}
