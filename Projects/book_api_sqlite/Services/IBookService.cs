using book_api_sqlite.Models;

namespace book_api_sqlite.Services
{
    public interface IBookService{
        IEnumerable<Book> GetAllBook();
        Book GetBookById(Guid id);
        IEnumerable<Book> GetBookByTitle(string title);
        Book CreateBook(Book book);
        bool UpdateBook(Guid id, Book updatedBook);
        bool DeleteBook(Guid id);
    }
}