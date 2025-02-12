namespace Nutrify.Domain
{
    public class Food
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public int ServingSize { get; set; }
        public int NutrientId { get; set; }
    }
}
