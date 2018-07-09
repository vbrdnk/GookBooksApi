using GookBooksApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace GookBooksApi.Persistence
{
    public class GookBooksApiDbContext: DbContext
    {
        public GookBooksApiDbContext(DbContextOptions<GookBooksApiDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}