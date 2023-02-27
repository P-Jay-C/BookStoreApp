using BookStoreApp.Models;
using BookStoreApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository;

        public BookController(BookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
        }
        public ViewResult GetAllBooks()
        {
           var data =  _bookRepository.GetAllBooks();

            return View();
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        } 

        public List<BookModel> SearchBooks(string BookName, string authorName)
        {
            return _bookRepository.SearchBooks(BookName, authorName);
        }
    }
}
