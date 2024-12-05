namespace CRUDProject.Models
{
    public static class Data
    {
        public static List<Author> Authors = new List<Author>
        {
            new Author
        {
            Id = 1,
            FirstName = "Harper",
            LastName = "Lee",
            DateOfBirth = new DateTime(1926, 4, 28)
        },
            new Author
        {
            Id = 2,
            FirstName = "George",
            LastName = "Orwell",
            DateOfBirth = new DateTime(1903, 6, 25)
        },
            new Author
        {
            Id = 3,
            FirstName = "F. Scott",
            LastName = "Fitzgerald",
            DateOfBirth = new DateTime(1896, 9, 24)
        },
            new Author
        {
            Id = 4,
            FirstName = "Jane",
            LastName = "Austen",
            DateOfBirth = new DateTime(1775, 12, 16)
        },
            new Author
        {
            Id = 5,
            FirstName = "J.D.",
            LastName = "Salinger",
            DateOfBirth = new DateTime(1919, 1, 1)
            },
            new Author
        {
            Id = 6,
            FirstName = "Sally",
            LastName = "Rooney",
            DateOfBirth = new DateTime(1991, 2, 20)
        }
    };

        public static List<Book> Books = new List<Book>
    {
        new Book
        {
            Id = 1,
            Title = "To Kill a Mockingbird",
            AuthorId = 1,
            Genre = "Fiction",
            PublishDate = new DateTime(1960, 7, 11),
            ISBN = "9780061120084",
            CopiesAvailable = 5
        },
        new Book
        {
            Id = 2,
            Title = "1984",
            AuthorId = 2,
            Genre = "Dystopian",
            PublishDate = new DateTime(1949, 6, 8),
            ISBN = "9780451524935",
            CopiesAvailable = 3
        },
        new Book
        {
            Id = 3,
            Title = "The Great Gatsby",
            AuthorId = 3,
            Genre = "Classic",
            PublishDate = new DateTime(1925, 4, 10),
            ISBN = "9780743273565",
            CopiesAvailable = 4
        },
        new Book
        {
            Id = 4,
            Title = "Pride and Prejudice",
            AuthorId = 4,
            Genre = "Romance",
            PublishDate = new DateTime(1813, 1, 28),
            ISBN = "9780141439518",
            CopiesAvailable = 7
        },
        new Book
        {
            Id = 5,
            Title = "The Catcher in the Rye",
            AuthorId = 5,
            Genre = "Fiction",
            PublishDate = new DateTime(1951, 7, 16),
            ISBN = "9780316769488",
            CopiesAvailable = 2
        },
        new Book
        {
            Id = 6,
            Title = "Animal Farm",
            AuthorId = 2,
            Genre = "Political Satire",
            PublishDate = new DateTime(1945, 8, 17),
            ISBN = "9780452284241",
            CopiesAvailable = 4
        },
        new Book
        {
            Id = 7,
            Title = "Emma",
            AuthorId = 4,
            Genre = "Romance",
            PublishDate = new DateTime(1815, 12, 23),
            ISBN = "9780141439587",
            CopiesAvailable = 3
        },
        new Book
        {
            Id = 8,
            Title = "Tender Is the Night",
            AuthorId = 3,
            Genre = "Fiction",
            PublishDate = new DateTime(1934, 4, 12),
            ISBN = "9780684801544",
            CopiesAvailable = 2
        },
        new Book
        {
            Id = 9,
            Title = "Franny and Zooey",
            AuthorId = 5,
            Genre = "Fiction",
            PublishDate = new DateTime(1961, 9, 1),
            ISBN = "9780316769495",
            CopiesAvailable = 5
        },
        new Book
        {
            Id = 10,
            Title = "Go Set a Watchman",
            AuthorId = 1,
            Genre = "Fiction",
            PublishDate = new DateTime(2015, 7, 14),
            ISBN = "9780062409850",
            CopiesAvailable = 6
        },
        new Book
        {
            Id = 11,
            Title = "Sense and Sensibility",
            AuthorId = 4,
            Genre = "Romance",
            PublishDate = new DateTime(1811, 10, 30),
            ISBN = "9780141439662",
            CopiesAvailable = 4
        },
        new Book
        {
            Id = 12,
            Title = "Normal People",
            AuthorId = 6,
            Genre = "Contemporary Fiction",
            PublishDate = new DateTime(2018, 8, 28),
            ISBN = "9781984822178",
            CopiesAvailable = 5
        },
        new Book
        {
            Id = 13,
            Title = "Intermezzo",
            AuthorId = 6,
            Genre = "Contemporary Fiction",
            PublishDate = new DateTime(2020, 5, 15),
            ISBN = "9781234567890",
            CopiesAvailable = 4
        }
    };
    }
}