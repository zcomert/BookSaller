using BookSaller.DataAccess.Abstract;
using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace BookSaller.DataAccess.Concrete.NHibernate
{
    public class NhCategoryDal : ICategoryDal
    {
        public void Add(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return new List<Category>()
            {
                new Category(){ CategoryId=1, Title="Nh Category 1" },
                new Category(){ CategoryId=2, Title="Nh Category 2" }
            };
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
