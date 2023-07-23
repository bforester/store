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
            new Book(3, "Color of Wizard."),
            new Book(4, "Color of Clean."),
            new Book(5, "CLR of Wizard.")
        };

        public Book[] GetAllByTitle(string titlePart)
        {

                return books.Where(book => book.Title.Contains(titlePart))
                        .ToArray();

            
        }
    }
}