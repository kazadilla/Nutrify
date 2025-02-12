namespace Nutrify.Domain
{
    public class Goal
    {
        public int Id { get; set; }
        public string? GoalType { get; set; }
        public DateTime TargetDate { get; set; }
        public int TargetCalories { get; set; }
        public int UserId { get; set; }
    }
}
