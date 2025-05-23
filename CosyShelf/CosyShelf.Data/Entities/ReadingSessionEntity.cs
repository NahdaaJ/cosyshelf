using SQLite;

namespace CosyShelf.Data.Entities
{
    [Table("ReadingSessions")]
    public class ReadingSessionEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public int BookId { get; set; }
    }
}
