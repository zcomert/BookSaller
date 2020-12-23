using BookSaller.Entities.Abstract;

namespace BookSaller.Entities.Concrete
{
    public class Author : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{Id,-5} {FirstName,-15} {LastName,-15}";
        }

    }
}
