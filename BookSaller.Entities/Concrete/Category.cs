using BookSaller.Entities.Abstract;

namespace BookSaller.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return $"{CategoryId,-5} {Title,-35}";
        }

    }
}
