namespace CRUDProject.Models.ViewModel.BookViewModel
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public int AuthorId { get; set; }    
        public string Genre { get; set; } = "";
        public string AuthorFullName { get; set; } = "";
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; } = "";
        public int CopiesAvailable { get; set; }
    }
}
