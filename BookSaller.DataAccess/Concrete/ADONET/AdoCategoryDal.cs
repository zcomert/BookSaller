using BookSaller.DataAccess.Abstract;
using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace BookSaller.DataAccess.Concrete.ADONET
{
    public class AdoCategoryDal : ICategoryDal
    {
        public void Add(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return new List<Category>()
            {
                new Category(){ CategoryId=1, Title="Ado Category 1" },
                new Category(){ CategoryId=2, Title="Ado Category 2" }
            };
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
