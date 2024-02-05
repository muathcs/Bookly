using bookly.Models;
using bookly.Models.Repo;
using Microsoft.AspNetCore.Mvc;

namespace bookly.Controllers
{
    [ApiController]
    [Route("shelf/[controller]")] // shelf indicates I'm searching within my library
    public class BookController: ControllerBase
    {


        // get all your books
        [HttpGet]
        public string GetBooks()
        {
            return "returning all books";
        }
        /*
         get the book you're reading or have read by id
         */
        [HttpGet("{id}")]
        public IActionResult GetABook(int id)
        {
            Book book = BookRepo.getBookById(id);

            if(book == null)
            {
                return NotFound("Book not found");
            }
            else
            {
                return Ok(book);
            }
        }



        /*
        create a new book
        goal on how quickly you want to finish the book
        how many pages the book has 
        thoughts

         */

        [HttpPost]
        public IActionResult AddABook([FromBody] Book book)
        {
            return Ok(book);
        }

        [HttpDelete]
        public IActionResult DeleteBook(int id)
        {
            //Book book = BookRepo.getBookById(id);
            List<Book> allBooks = BookRepo.getAllBooks();

            return Ok(allBooks);
        }


        /*
         allows you to update the page you're reading on a book.
        update the rating of the book.
        update the review of the book. 
         */

        [HttpPut]
        public string UpdateABook()
        {
            return "updaing a book";
        }



        //[HttpGet]
        //public string GetBook([FromQuery] string dummy)
        //{
        //    return $"Getting book from controller {dummy}";
        //}


    }
}
