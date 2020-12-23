using BookSaller.DataAccess.Abstract;
using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Concrete.ADONET
{
    public class AdoBookDal : IBookDal
    {
        public void Add(Book book)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Books(Title,UnitPrice) VALUES (@Title,@UnitPrice)");
            cmd.Parameters.AddWithValue("Title", book.Title);
            cmd.Parameters.AddWithValue("UnitPrice", book.UnitPrice);
            DBMS.SqlExecuteNonQuery(cmd);
        }

        public void Delete(Book book)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            var list = new List<Book>();
            var cmd = new SqlCommand("Select * from Books");
            var reader = DBMS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                var book = new Book()
                {
                    Id = Convert.ToInt32(reader[0]),
                    Title = reader[1].ToString(),
                    UnitPrice = Convert.ToDecimal(reader[2])
                };
                list.Add(book);
            }
            return list;
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
