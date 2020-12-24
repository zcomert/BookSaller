using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Concrete.EntityFramework.Mapping
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            ToTable(@"Books", @"dbo");
            HasKey(b => b.Id);
            Property(b => b.Id).HasColumnName("Id");
            Property(b => b.Title).HasColumnName("Title");
            Property(b => b.UnitPrice).HasColumnName("UnitPrice");
        }
    }
}
