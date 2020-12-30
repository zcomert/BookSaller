using BookSaller.Business.Abstract;
using BookSaller.Business.Concrete;
using BookSaller.DataAccess.Abstract;
using BookSaller.DataAccess.Concrete.ADONET;
using BookSaller.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.Business.Cross_Cutting_Concerns.DependecyResolvers.Ninject
{

    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            //register
            Bind<IBookService>().To<BookManager>().InSingletonScope();
            Bind<IBookDal>().To<EfBookDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
        }
    }
}
