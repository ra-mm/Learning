using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookrepository = null;

        public BookController()
        {
            _bookrepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookrepository.GetAllBooks();
            //ViewBag.BooksInformation = data;
            return View(data);
        }

        public  BookModel GetBook(int id)
        {
            return _bookrepository.GetBookById(id);
        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookrepository.SearchBook(bookName, authorName);
        }
    }
}
