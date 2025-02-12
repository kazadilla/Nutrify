using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nutrify.Domain;

namespace Nutrify.Configurations.Entities
{
    public class FoodSeed : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
                new Food 
                { 
                    Id = 1,
                    Name = "Chicken Breast",
                    Category = "Protein",
                    ServingSize = 100,
                    NutrientId = 1
                },
                new Food
                {
                    Id = 2,
                    Name = "Rice",
                    Category = "Grain",
                    ServingSize = 100,
                    NutrientId = 2
                },
                new Food
                {
                    Id = 3,
                    Name = "Apple",
                    Category = "Fruits",
                    ServingSize = 1,
                    NutrientId = 3
                }
            );
        }
    }
}
