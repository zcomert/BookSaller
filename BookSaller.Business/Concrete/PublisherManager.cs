using BookSaller.Business.Abstract;
using BookSaller.DataAccess.Abstract;
using BookSaller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.Business.Concrete
{
    public class PublisherManager : IPublisherService
    {
        IPublisherDal _publisherDal;

        public PublisherManager(IPublisherDal publisherDal)
        {
            _publisherDal = publisherDal;
        }

        public List<Publisher> GetAll()
        {
            return _publisherDal.GetAll();
        }
    }
}
