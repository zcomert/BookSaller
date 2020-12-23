﻿using BookSaller.DataAccess.Abstract;
using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : 
        EfRepositoryBase<Book,BookSallerContext>,
        IBookDal
    {
        
    }
}
