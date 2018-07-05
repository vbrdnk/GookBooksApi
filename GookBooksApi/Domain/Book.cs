using System;
using System.Collections.Generic;
using GookBooksApi.Interfaces;

namespace GookBooksApi.Domain
{
    public class Book
    {
        public Book()
        {
            Id = Guid.NewGuid();
            Rate = 0;
            Quotes = new List<string>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public BookAuthor Author { get; set; }
        public int Rate { get; set; }
        public string Description { get; set; }
        public List<string> Quotes { get; set; }
    }
}
