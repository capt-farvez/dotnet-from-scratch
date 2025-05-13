using book_api_sqlite.Models;
using book_api_sqlite.Services;
using Microsoft.AspNetCore.Mvc;

namespace book_api_sqlite.Controllers
{
    [ApiController]
    [Route("api/books/")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService){
            _bookService = bookService;
        }

        // GET: api/books
        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _bookService.GetAllBook();
            return Ok(books);
            // return Ok("Categories are working!");
        }

        // GET: api/books/{id}
        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            var book = _bookService.GetBookById(id);
            return book is null ? NotFound() : Ok(book);
        }

        // GET: api/Book/search?title=algorithm
        [HttpGet("search")]
        public IActionResult GetByTitle([FromQuery] string title)
        {
            var results =_bookService.GetBookByTitle(title);
            return results.Any() ? Ok(results) : NotFound();
        }

        // POST: api/Book
        [HttpPost]
        public IActionResult Create(Book book)
        {
            var createdBook =_bookService.CreateBook(book);
            return CreatedAtAction(nameof(GetById), new { id = createdBook.BookId }, createdBook);
        }

        // PUT: api/Book/{id}
        [HttpPut("{id:guid}")]
        public IActionResult Update(Guid id, Book updatedBook)
        {
            var book =_bookService.UpdateBook(id, updatedBook);
            return book ? NoContent() : NotFound();
        }

        // DELETE: api/Book/{id}
        [HttpDelete("{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            var success =_bookService.DeleteBook(id);
            return success ? NoContent() : NotFound();
        }
    }
}