using BookSaller.DataAccess.Abstract;
using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : IBookDal
    {
        public void Add(Book book)
        {
            using (var context = new BookSallerDBContext())
            {
                context.Entry(book).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Book book)
        {
            using (var context = new BookSallerDBContext())
            {
                context.Entry(book).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Book Get(Expression<Func<Book, bool>> filter)
        {
            using (var context = new BookSallerDBContext())
            {
                return context.Set<Book>().SingleOrDefault(filter);
            }
        }

        public List<Book> GetAll(Expression<Func<Book, bool>> filter = null)
        {
            using (var context = new BookSallerDBContext())
            {
                return filter == null ?
                    context.Set<Book>().ToList() :
                    context.Set<Book>().Where(filter).ToList();
            }
        }

        public void Update(Book book)
        {
            using (var context = new BookSallerDBContext())
            {
                context.Entry(book).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
