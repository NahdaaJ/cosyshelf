namespace CosyShelf.Core.Models
{
    public class ReadingSession
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
    }
}
