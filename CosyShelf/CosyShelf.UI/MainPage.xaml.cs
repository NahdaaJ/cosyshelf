using CosyShelf.Core.Models;
using CosyShelf.Data.Entities;
using CosyShelf.Data.Services;
using CosyShelf.Data.Repositories;

namespace CosyShelf.UI
{
    public partial class MainPage : ContentPage
    {
        private readonly BookService _bookService;

        public MainPage(BookService bookService)
        {
            InitializeComponent();
            _bookService = bookService;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await DisplayAllBooks();
        }

        private async void OnAddBookClicked(object sender, EventArgs e)
        {
            var book = CreateBook();
            if (book != null)
            {
                await _bookService.AddBookAsync(book);
            }

            AddBookToDisplay(book);

            BookTitle.Text = string.Empty;
            BookAuthor.Text = string.Empty;
            BookDescription.Text = string.Empty;
            BookRating.Text = string.Empty;
            BookComment.Text = string.Empty;
            BookStatus.Text = string.Empty;

        }

        private Book CreateBook()
        {
            var book = new Book(BookTitle.Text, BookAuthor.Text);
            book.Description = BookDescription.Text;
            if (double.TryParse(BookRating.Text, out double rating))
            {
                book.Rating = rating;
            }
            else
            {
                book.Rating = null;
            }
            book.Comment = BookComment.Text;
            switch (BookStatus.Text)
            {
                case "tbr":
                    book.Status = Core.Enums.BookStatus.TBR;
                    break;
                case "reading":
                    book.Status = Core.Enums.BookStatus.Reading;
                    break;
                case "finished":
                    book.Status = Core.Enums.BookStatus.Finished;
                    break;
                default:
                    book.Status = Core.Enums.BookStatus.TBR;
                    break;
            }

            return book;
        }

        private async Task DisplayAllBooks()
        {
            var books = await _bookService.GetAllBooksAsync();
            foreach (var book in books)
            {
                AddBookToDisplay(book);
            }
        }

        private void AddBookToDisplay(Book book)
        {
            BookDisplay.Children.Add(new Label
            {
                Text = $"{book.Title} by {book.Author}\n{book.Description}\nRating: {book.Rating?.ToString("0.0") ?? "N/A"}\tStatus: {book.Status}",
                Margin = new Thickness(5)
            });
        }
    }

}
