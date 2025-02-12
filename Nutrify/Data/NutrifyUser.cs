using Microsoft.AspNetCore.Identity;

namespace Nutrify.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class NutrifyUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
