using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nutrify.Configurations.Entities;
using Nutrify.Data;

namespace Nutrify.Data
{
    public class NutrifyContext(DbContextOptions<NutrifyContext> options) : IdentityDbContext<NutrifyUser>(options)
    {
        public DbSet<Nutrify.Domain.Food> Food { get; set; } = default!;
        public DbSet<Nutrify.Domain.Nutrient> Nutrient { get; set; } = default!;
        public DbSet<Nutrify.Domain.DailyLog> DailyLog { get; set; } = default!;
        public DbSet<Nutrify.Domain.Goal> Goal { get; set; } = default!;
        public DbSet<Nutrify.Domain.Progress> Progress { get; set; } = default!;
        public DbSet<Nutrify.Domain.Recipe> Recipe { get; set; } = default!;
        public DbSet<Nutrify.Domain.Meal> Meal { get; set; } = default!;
        public DbSet<Nutrify.Domain.User> User { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new FoodSeed());
            builder.ApplyConfiguration(new MealSeed());
            builder.ApplyConfiguration(new NutrientSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}
