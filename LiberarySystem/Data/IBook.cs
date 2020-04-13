using LiberarySystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiberarySystem.Data
{
    public interface IBook
    {
        public IEnumerable<Book> GetBooks();
        public Book GetBook(int id);
        public void CreateBook(Book book);
        public void DeleteBook(int id);
        public Book UpdateBook(Book book);
    }
}
