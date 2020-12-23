﻿using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.Business.Abstract
{
    public interface IAuthorService
    {
        List<Author> GetAll();
        
    }
}
