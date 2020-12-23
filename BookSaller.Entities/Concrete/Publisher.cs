using BookSaller.Entities.Abstract;

namespace BookSaller.Entities.Concrete
{
    public class Publisher : IEntity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
    }
}
