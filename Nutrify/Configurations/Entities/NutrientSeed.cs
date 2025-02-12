using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nutrify.Domain;

namespace Nutrify.Configurations.Entities
{
    public class NutrientSeed : IEntityTypeConfiguration<Nutrient>
    {
        public void Configure(EntityTypeBuilder<Nutrient> builder)
        {
            builder.HasData(
                new Nutrient
                {
                    Id = 1,
                    Name = "Protein",
                    Units = "g"
                },
                new Nutrient
                {
                    Id = 2,
                    Name = "Carbohydrates",
                    Units = "g"
                },
                new Nutrient
                {
                    Id = 3,
                    Name = "Vitamins",
                    Units = "mg"
                }
            );
        }
    }
}
