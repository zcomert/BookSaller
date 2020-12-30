using BookSaller.Entities.Concrete;
using System.Collections.Generic;

namespace BookSaller.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
