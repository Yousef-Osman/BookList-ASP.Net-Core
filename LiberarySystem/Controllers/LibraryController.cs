using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiberarySystem.Data;
using LiberarySystem.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LiberarySystem.Controllers
{
    public class LibraryController : Controller
    {
        IBook _books;

        public LibraryController(IBook books)
        {
            _books = books;
        }

        public IActionResult Index()
        {
            var books = _books.GetBooks();
            return View(books);
        }

        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                _books.CreateBook(book);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        public IActionResult Delete(int id)
        {
            _books.DeleteBook(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int id)
        {
            var book = _books.GetBook(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult Update(Book book)
        {
            if (ModelState.IsValid)
            {
                _books.UpdateBook(book);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
    }
}