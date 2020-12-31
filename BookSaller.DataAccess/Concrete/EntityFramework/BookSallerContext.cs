using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Concrete.EntityFramework
{
    public class BookSallerDBContext : DbContext
    {
        public BookSallerDBContext()
        {
            Database.SetInitializer<BookSallerDBContext>(null); 
        }

        public DbSet<Book> Books { get; set; }
    }
}
