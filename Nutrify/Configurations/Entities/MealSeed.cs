using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nutrify.Domain;

namespace Nutrify.Configurations.Entities
{
    public class MealSeed : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasData(
                new Meal
                {
                    Id = 1,
                    MealType = "Breakfast",
                    Date = DateTime.Now
                },
                new Meal
                {
                    Id = 2,
                    MealType = "Lunch",
                    Date = DateTime.Now
                },
                new Meal
                {
                    Id = 3,
                    MealType = "Dinner",
                    Date = DateTime.Now
                },
                new Meal
                {
                    Id = 4,
                    MealType = "Snack",
                    Date = DateTime.Now
                }
            );
        }
    }
}
