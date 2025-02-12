namespace Nutrify.Domain
{
    public class Meal
    {
        public int Id { get; set; }
        public string? MealType { get; set; }
        public DateTime Date { get; set; }
        public int FoodId { get; set; }
    }
}
