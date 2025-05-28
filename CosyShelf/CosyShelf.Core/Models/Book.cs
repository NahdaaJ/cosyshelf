using CosyShelf.Core.Enums;

namespace CosyShelf.Core.Models
{
    public class Book
    {
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string? Description { get; set; }

        private double? _rating;
        public double? Rating
        {
            get => _rating;
            set
            {
                if (value is < 0 or > 5)
                    throw new ArgumentOutOfRangeException(nameof(Rating), "Rating must be between 0 and 5.");
                _rating = value;
            }
        }

        public string? Comment { get; set; }

        public BookStatus Status { get; set; } = BookStatus.TBR;

        public List<ReadingSession>? ReadingHistory { get; set; }
    }

}
