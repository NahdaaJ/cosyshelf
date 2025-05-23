using SQLite;

namespace CosyShelf.Data.Entities
{
    [Table("Books")]
    public class BookEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string? Description { get; set; }
        public double? Rating { get; set; }
        public string? Comment { get; set; }
        public int Status { get; set; }
    }
}
