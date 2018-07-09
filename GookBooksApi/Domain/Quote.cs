using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GookBooksApi.Domain
{
    [Table("Quotes")]
    public class Quote
    {
        public Quote()
        {
            Id = Guid.NewGuid();
        }

        public Quote(string value, Guid bookId)
        {
            Value = value;
            BookId = bookId;
        }

        public Guid Id { get; set; }
        
        [Required]
        public string Value { get; set; }
        public Guid BookId { get; set; }
    }
}