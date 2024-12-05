using CRUDProject.Models.ViewModel.AuthorViewModel;
using CRUDProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDProject.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult List()
        {
            var authors = Data.Authors.Select(author => new AuthorViewModel
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                DateOfBirth = author.DateOfBirth,
                BooksWritten = GetAuthorBooks(author.Id)
            }).ToList();

            return View(authors);
        }

        public IActionResult Details(int id)
        {
            var author = Data.Authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
                return NotFound();

            var viewModel = new AuthorViewModel
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                DateOfBirth = author.DateOfBirth,
                BooksWritten = GetAuthorBooks(author.Id)
            };

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AuthorViewModel model)
        {
            if (ModelState.IsValid)
            {
                var author = new Author
                {
                    Id = Data.Authors.Max(a => a.Id) + 1,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    DateOfBirth = model.DateOfBirth
                };

                Data.Authors.Add(author);
                return RedirectToAction(nameof(List));
            }

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var author = Data.Authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
                return NotFound();

            var viewModel = new AuthorViewModel
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                DateOfBirth = author.DateOfBirth
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(AuthorViewModel model)
        {
            if (ModelState.IsValid)
            {
                var author = Data.Authors.FirstOrDefault(a => a.Id == model.Id);
                if (author == null)
                    return NotFound();

                author.FirstName = model.FirstName;
                author.LastName = model.LastName;
                author.DateOfBirth = model.DateOfBirth;

                return RedirectToAction(nameof(List));
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var author = Data.Authors.FirstOrDefault(a => a.Id == id);
            if (author != null)
            {
                // Önce yazarın kitaplarını kontrol et
                var hasBooks = Data.Books.Any(b => b.AuthorId == id);
                if (!hasBooks)
                {
                    Data.Authors.Remove(author);
                }
                else
                {
                    TempData["Error"] = "Cannot delete author with existing books.";
                }
            }
            return RedirectToAction(nameof(List));
        }

        private List<string> GetAuthorBooks(int authorId)
        {
            return Data.Books
                .Where(book => book.AuthorId == authorId)
                .Select(book => book.Title)
                .ToList();
        }
    }
}
