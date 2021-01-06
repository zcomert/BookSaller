using BookSaller.Entities.Concrete;
using BookSaller.Entities.ValidationRules.FluentValidation;
using FluentValidation;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Book>>().To<BookValidator>().InSingletonScope();
        }
    }
}
