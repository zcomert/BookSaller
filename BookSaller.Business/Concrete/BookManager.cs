using BookSaller.Business.Abstract;
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

        public void Add(Book book)
        {
            BookValidator bookValidator = new BookValidator();
            ValidationResult results = bookValidator.Validate(book);
            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    Console.WriteLine($"Property {failure.PropertyName} failed validation." +
                        $"Error was {failure.ErrorMessage}");
                }
            }
            else
            {
                _bookDal.Add(book);
            }
        }

        public List<Book> GetAll()
        {
           return _bookDal.GetAll();
        }
    }
}
