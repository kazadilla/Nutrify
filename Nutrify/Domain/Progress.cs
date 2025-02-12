namespace Nutrify.Domain
{
    public class Progress
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Weight { get; set; }
        public int Points { get; set; }
        public int DailyLogId { get; set; }
    }
}
