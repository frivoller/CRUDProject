# Library Management System

A simple CRUD application developed for book and author management.

## 🚀 Features

- Book management (add, edit, delete, list)
- Author management (add, edit, delete, list)
- Responsive design
- User-friendly interface

## 🛠 Technologies

- ASP.NET Core MVC (.NET 8.0)
- Bootstrap 5.3.0
- Entity Framework Core (In-Memory Database)
- C#
- HTML/CSS
- JavaScript

## 🏗 Project Structure

CRUDProject/
├── Controllers/ # MVC Controllers
├── Models/ # Data models and ViewModels
├── Views/ # Razor views
│ ├── Author/ # Author operations views
│ ├── Book/ # Book operations views
│ ├── Home/ # Home page views
│ └── Shared/ # Shared layout and partial views
├── wwwroot/ # Static files (CSS, JS, images)
└── Data/ # In-memory database operations

## 📝 Usage

### Book Operations
- Book List: `/Book/List`
- New Book: `/Book/Create`
- Edit Book: `/Book/Edit/{id}`
- Book Details: `/Book/Details/{id}`

### Author Operations
- Author List: `/Author/List`
- New Author: `/Author/Create`
- Edit Author: `/Author/Edit/{id}`
- Author Details: `/Author/Details/{id}`

## 🧪 Testing

```bash
dotnet test
```

## 👥 Contributing

1. Fork this repository
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Create a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 📞 Contact

Melis Yıldız - [LinkedIn](https://www.linkedin.com/in/melis-yıldız-707/)

Project Link: [https://github.com/frivoller/library-management](https://github.com/frivoller/library-management)
