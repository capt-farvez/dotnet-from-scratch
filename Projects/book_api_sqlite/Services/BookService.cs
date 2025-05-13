using book_api_sqlite.Models;
using Microsoft.EntityFrameworkCore;

namespace book_api_sqlite.Services
{
    public class BookService: IBookService{
        private readonly AppDbContext _dbContext;

        public BookService(AppDbContext dbContext){
            _dbContext = dbContext;

        }

        public IEnumerable<Book> GetAllBook(){
            return _dbContext.Books.ToList();
        }

        public Book? GetBookById(Guid id){
            return _dbContext.Books.Find(id);
        }

        public IEnumerable<Book> GetBookByTitle(string title){
            var books = _dbContext.Books.Where(b => !string.IsNullOrEmpty(b.Title) && b.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return books;
        }

        public Book CreateBook(Book newBook){
            newBook.BookId = Guid.NewGuid();
            newBook.CreatedAt = DateTime.UtcNow;
            _dbContext.Books.Add(newBook);
            _dbContext.SaveChanges();

            return newBook;
        }

        public bool UpdateBook(Guid id, Book updatedBook){
            var book = _dbContext.Books.FirstOrDefault(b => b.BookId == id);
            if(book is null) return false;

            book.Title = updatedBook.Title;
            book.Description = updatedBook.Description;
            book.Price = updatedBook.Price;
            _dbContext.SaveChanges();

            return true;
        }

        public bool DeleteBook(Guid id){
            var book = _dbContext.Books.FirstOrDefault(b => b.BookId == id);
            if(book is null) return false;

            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
            return true;
        }

    }
}