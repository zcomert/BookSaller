using BookSaller.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Abstract
{
    public interface IEntityRepository<T> 
        where T:class, IEntity, new()
    {
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
