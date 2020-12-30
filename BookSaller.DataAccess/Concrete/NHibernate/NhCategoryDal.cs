using BookSaller.DataAccess.Abstract;
using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BookSaller.DataAccess.Concrete.NHibernate
{
    public class NhCategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return new List<Category>()
            {
                new Category(){ CategoryId=1, Title="Nh Category 1"},
                new Category(){ CategoryId=2, Title="Nh Category 2"}
            };
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
