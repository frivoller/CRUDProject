using System.Diagnostics;
using CRUDProject.Models;
using CRUDProject.Models.ViewModel.BookViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CRUDProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
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
            catch (Exception ex)
            {
                _logger.LogError(ex, "Index sayfası yüklenirken hata oluştu");
                throw;
            }
        }

        private string GetAuthorFullName(int authorId)
        {
            var author = Data.Authors.FirstOrDefault(a => a.Id == authorId);
            return author != null ? $"{author.FirstName} {author.LastName}" : string.Empty;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
