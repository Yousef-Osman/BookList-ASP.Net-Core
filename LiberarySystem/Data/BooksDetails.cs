using LiberarySystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiberarySystem.Data
{
    public class BooksDetails: IBook
    {
        LibraryDBContext _db;

        public BooksDetails(LibraryDBContext db)
        {
            _db = db;
        }

        public Book GetBook(int id)
        {
            return _db.Books.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _db.Books.ToList();
        }

        public void CreateBook(Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            _db.Books.Remove(GetBook(id));
            _db.SaveChanges();
        }

        public Book UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
