using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nutrify.Domain;

namespace Nutrify.Data
{
    public class NutrifyContext : DbContext
    {
        public NutrifyContext (DbContextOptions<NutrifyContext> options)
            : base(options)
        {
        }

        public DbSet<Nutrify.Domain.Food> Food { get; set; } = default!;
        public DbSet<Nutrify.Domain.Nutrient> Nutrient { get; set; } = default!;
        public DbSet<Nutrify.Domain.DailyLog> DailyLog { get; set; } = default!;
        public DbSet<Nutrify.Domain.Goal> Goal { get; set; } = default!;
        public DbSet<Nutrify.Domain.Progress> Progress { get; set; } = default!;
        public DbSet<Nutrify.Domain.Recipe> Recipe { get; set; } = default!;
        public DbSet<Nutrify.Domain.Meal> Meal { get; set; } = default!;
        public DbSet<Nutrify.Domain.User> User { get; set; } = default!;
    }
}
