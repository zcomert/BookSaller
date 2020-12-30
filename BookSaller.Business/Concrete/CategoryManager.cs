using BookSaller.Business.Abstract;
using BookSaller.DataAccess.Abstract;
using BookSaller.Entities.Concrete;
using System.Collections.Generic;

namespace BookSaller.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        // DI
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
