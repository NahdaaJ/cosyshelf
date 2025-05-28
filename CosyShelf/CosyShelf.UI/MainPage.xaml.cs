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

        private async void OnAddBookClicked(object sender, EventArgs e)
        {
            var book = CreateBook();
            if (book != null)
            {
                // Assuming you have a service to handle book storage
                await _bookService.AddBookAsync(book);
            }

            // Optionally, clear the input fields after adding
            BookTitle.Text = string.Empty;
            BookAuthor.Text = string.Empty;
            BookDescription.Text = string.Empty;
            BookRating.Text = string.Empty;
            BookComment.Text = string.Empty;
            BookStatus.Text = string.Empty; // Reset the status dropdown

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
                book.Rating = null; // or handle invalid input as needed
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
    }

}
