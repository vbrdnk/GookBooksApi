using GookBooksApi.Interfaces;

namespace GookBooksApi.Domain
{
    public class BookAuthor: IBookAuthor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
