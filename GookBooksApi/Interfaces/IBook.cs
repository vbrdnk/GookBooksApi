using System;
using System.Collections.Generic;
using GookBooksApi.Domain;

namespace GookBooksApi.Interfaces
{
    public interface IBook
    {
        Guid Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        BookAuthor Author { get; set; }
        int Rate { get; set; }
        List<string> Quotes { get; set; }
    }
}
