using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WMP.Models;

namespace WMP.Data;

public class WMPContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<Family> Families { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
    public DbSet<MealDateRecipe> MealDateRecipes { get; set; }
    
    public WMPContext(DbContextOptions<WMPContext> options) : base(options)
    {
        
    }
}