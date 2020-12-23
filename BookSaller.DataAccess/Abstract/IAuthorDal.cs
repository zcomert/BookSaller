﻿using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Abstract
{
    public interface IAuthorDal : 
        IEntityRepository<Author>
    {
       
    }
}
