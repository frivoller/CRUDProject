namespace CRUDProject.Models.ViewModel.AuthorViewModel
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public DateTime DateOfBirth { get; set; }
        public List<string> BooksWritten { get; set; } = new List<string>();
        
        public string FullName => $"{FirstName} {LastName}";
    }
}
