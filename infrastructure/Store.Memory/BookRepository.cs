using System.Linq;
using store;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        { 
            new Book(1, "Clean Code."),
            new Book(2, "CLR via C#."),
            new Book(3, "Color of Wisard.")
        };

        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart))
                        .ToArray();
        }
    }
}