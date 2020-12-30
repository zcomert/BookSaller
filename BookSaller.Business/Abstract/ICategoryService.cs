using BookSaller.DataAccess.Abstract;
using BookSaller.Entities.Concrete;
using System.Collections.Generic;

namespace BookSaller.Business.Abstract
{
    public interface ICategoryService : IEntityRepository<Category>
    {
       
    }
}
