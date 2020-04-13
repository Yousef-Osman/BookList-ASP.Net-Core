using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiberarySystem.Repository
{
    public class LibraryDBContext: DbContext
    {
        public LibraryDBContext(DbContextOptions<LibraryDBContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
