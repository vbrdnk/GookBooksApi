using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GookBooksApi.Domain
{
    [Table("BookAuthors")]
    public class BookAuthor
    {
        public BookAuthor()
        {
            Id = Guid.NewGuid();
            Books = new List<Book>();
        }
        public Guid Id { get; set;  }
        public List<Book> Books { get; set;  }
        
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
    }
}
