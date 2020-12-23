using BookSaller.DataAccess.Abstract;
using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Concrete.EntityFramework
{
    public class EfPublisherDal 
        : EfRepositoryBase<Publisher, BookSallerContext>, IPublisherDal
    {

    }
}
