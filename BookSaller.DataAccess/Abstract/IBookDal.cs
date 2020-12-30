using BookSaller.Entities.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Abstract
{

    public interface IBookDal : IEntityRepository<Book>
    {
       
    }

   
}
