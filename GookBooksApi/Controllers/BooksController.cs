using System;
using System.Collections.Generic;
using GookBooksApi.Domain;
using Microsoft.AspNetCore.Mvc;

namespace GookBooksApi.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        // GET: api/books
        [HttpGet]
        public IEnumerable<Book> GetBooks()
        {
            return new[]
            {
                new Book
                {
                    Title = "Book 1",
                    Description = "A super tasty schnitzel",
                    Author = new BookAuthor {FirstName = "John", LastName = "Doe"}
                },
                new Book
                {
                    Title = "Book 2",
                    Description = "What else  you need to say?",
                    Author = new BookAuthor {FirstName = "Hey", LastName = "You"}
                }
            };
        }

        // GET: api/books/{id}
        [HttpGet("{id:Guid}")]
        public IActionResult GetBook(Guid id)
        {
            return Ok(new Book { Id = id, Description = "Randomly created book", Author = new BookAuthor { FirstName = "Vlad", LastName = "Burdeniuk"}});
        }

        // POST: api/books
        [HttpPost]
        public Book PostBook([FromBody] Book book)
        {
           return new Book
           {
               Title = book.Title,
               Description = book.Description,
               Author = new BookAuthor { FirstName = book.Author.FirstName, LastName = book.Author.LastName }
           }; 
        }
    }
}
