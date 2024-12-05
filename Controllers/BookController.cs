using CRUDProject.Models.ViewModel.BookViewModel;
using CRUDProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUDProject.Controllers
{
    public class BookController : Controller
    {
        public IActionResult List()
        {
            var books = Data.Books.Select(book => new BookViewModel
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Genre = book.Genre,
                PublishDate = book.PublishDate,
                ISBN = book.ISBN,
                CopiesAvailable = book.CopiesAvailable,
                AuthorFullName = GetAuthorFullName(book.AuthorId)
            }).ToList();

            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = Data.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();

            var viewModel = new BookViewModel
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Genre = book.Genre,
                PublishDate = book.PublishDate,
                ISBN = book.ISBN,
                CopiesAvailable = book.CopiesAvailable,
                AuthorFullName = GetAuthorFullName(book.AuthorId)
            };

            return View(viewModel);
        }

        public IActionResult Create()
        {
            ViewBag.Authors = GetAuthorsSelectList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                var book = new Book
                {
                    Id = Data.Books.Max(b => b.Id) + 1,
                    Title = model.Title,
                    AuthorId = model.AuthorId,
                    Genre = model.Genre,
                    PublishDate = model.PublishDate,
                    ISBN = model.ISBN,
                    CopiesAvailable = model.CopiesAvailable
                };

                Data.Books.Add(book);
                return RedirectToAction(nameof(List));
            }

            ViewBag.Authors = GetAuthorsSelectList();
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var book = Data.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();

            var viewModel = new BookViewModel
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Genre = book.Genre,
                PublishDate = book.PublishDate,
                ISBN = book.ISBN,
                CopiesAvailable = book.CopiesAvailable
            };

            ViewBag.Authors = GetAuthorsSelectList();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                var book = Data.Books.FirstOrDefault(b => b.Id == model.Id);
                if (book == null)
                    return NotFound();

                book.Title = model.Title;
                book.AuthorId = model.AuthorId;
                book.Genre = model.Genre;
                book.PublishDate = model.PublishDate;
                book.ISBN = model.ISBN;
                book.CopiesAvailable = model.CopiesAvailable;

                return RedirectToAction(nameof(List));
            }

            ViewBag.Authors = GetAuthorsSelectList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var book = Data.Books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                Data.Books.Remove(book);
            }
            return RedirectToAction(nameof(List));
        }

        private string GetAuthorFullName(int authorId)
        {
            var author = Data.Authors.FirstOrDefault(a => a.Id == authorId);
            return author != null ? $"{author.FirstName} {author.LastName}" : string.Empty;
        }

        private SelectList GetAuthorsSelectList()
        {
            var authors = Data.Authors.Select(a => new
            {
                Id = a.Id,
                FullName = $"{a.FirstName} {a.LastName}"
            });
            return new SelectList(authors, "Id", "FullName");
        }
    }
}

