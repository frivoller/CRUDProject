using Microsoft.AspNetCore.Mvc;
using CRUDProject.Models;
using CRUDProject.Models.ViewModel.BookViewModel;
using System.Linq;
using CRUDProject.Models.ViewModel.AuthorViewModel;

namespace CRUDProject.Controllers
{
    public class LibraryController : Controller
    {
        // Action to show the list of books
        public IActionResult BookList()
        {
            var bookViewModels = Data.Books.Select(book => new BookViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Genre = book.Genre,
                PublishDate = book.PublishDate,
                ISBN = book.ISBN,
                CopiesAvailable = book.CopiesAvailable,
                AuthorFullName = Data.Authors
                                    .FirstOrDefault(author => author.Id == book.AuthorId)?
                                    .FirstName + " " +
                                    Data.Authors
                                    .FirstOrDefault(author => author.Id == book.AuthorId)?
                                    .LastName
            }).ToList();

            return View(bookViewModels);
        }

        // Action to show the list of authors
        public IActionResult AuthorList()
        {
            var authorViewModels = Data.Authors.Select(author => new AuthorViewModel
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                DateOfBirth = author.DateOfBirth,
                BooksWritten = Data.Books
                                .Where(book => book.AuthorId == author.Id)
                                .Select(book => book.Title)
                                .ToList()
            }).ToList();

            return View(authorViewModels);
        }
    }
}
