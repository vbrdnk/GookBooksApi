using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GookBooksApi.Domain
{
    public class Book
    {
        public Book()
        {
            Id = Guid.NewGuid();
            Rate = 0;
            Quotes = new List<Quote>();
        }

        public Guid Id { get; set; }

        [MinLength(5)]
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        
        [Required]
        public BookAuthor Author { get; set; }
        public int Rate { get; set; }

        [MinLength(5)]
        public string Description { get; set; }
        public List<Quote> Quotes { get; set; }
    }
}
