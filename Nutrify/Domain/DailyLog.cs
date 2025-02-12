namespace Nutrify.Domain
{
    public class DailyLog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int TotalCalories { get; set; }
        public int ServingSizeLogged { get; set; }
        public int UserId { get; set; }
    }
}
