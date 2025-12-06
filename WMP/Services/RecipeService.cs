using Microsoft.EntityFrameworkCore;
using WMP.Data;
using WMP.Models;
using WMP.Models.Data_Transfer_Objects;

namespace WMP.Services;

public class RecipeService : IRecipeService
{
    private readonly IDbContextFactory<WMPContext> _dbContextFactory;

    public RecipeService(IDbContextFactory<WMPContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }
    
    public async Task<Recipe> AddRecipe(RecipeDTO recipe)
    {
        Recipe? recipeCheck = null;
        using (var context = _dbContextFactory.CreateDbContext())
        {
            recipeCheck = await context.Recipes.Where(x => x.MealDbId == recipe.MealDbId).FirstOrDefaultAsync();
        }

        if (recipeCheck == null)
        {
            Recipe recipeToAdd = new Recipe()
            {
                Name = recipe.Name,
                Approach = recipe.Instructions,
                MealDbId = recipe.MealDbId,
                ThumbnailUrl = recipe.ThumbnailUrl,
                Source = recipe.Source,
            };

            using (var context = _dbContextFactory.CreateDbContext())
            {
                await context.AddAsync(recipeToAdd);
                await context.SaveChangesAsync();

                foreach (var recipeIngredient in recipe.Ingredients)
                {
                    RecipeIngredient recipeIngredientToAdd = new RecipeIngredient()
                    {
                        Name = recipeIngredient.Name,
                        RecipeId = recipeToAdd.Id,
                        Measure = recipeIngredient.Measurement
                    };

                    await context.AddAsync(recipeIngredientToAdd);
                    await context.SaveChangesAsync();
                }
            }
            
            return recipeToAdd;

        }

        return recipeCheck;
    }

    public async Task<MealDateRecipe> AddRecipeToDate(Recipe recipe, DateTime date, int familyId)
    {
        MealDateRecipe dateRecipe = new MealDateRecipe()
        {
            RecipeId = recipe.Id,
            Date = date,
            FamilyId = familyId
        };
        
        using (var context = _dbContextFactory.CreateDbContext())
        {
            await context.AddAsync(dateRecipe);
            await context.SaveChangesAsync();
        }
        
        return dateRecipe;
    }

    public async Task<MealDateRecipe> UpdateMealDateRecipe(MealDateRecipe mealDateRecipe)
    {
        using (var context = _dbContextFactory.CreateDbContext())
        {
            context.Update(mealDateRecipe);

            await context.SaveChangesAsync();
        }

        return mealDateRecipe;
    }

    public async Task<List<MealDateRecipe>> GetMealDateRecipes(int familyId)
    {
        List<MealDateRecipe> recipes = new List<MealDateRecipe>();
        
        using (var context = _dbContextFactory.CreateDbContext())
        {
            recipes = await context.MealDateRecipes.Where(x => x.FamilyId == familyId)
                .Include(x => x.Family)
                .Include(x => x.Recipe)
                    .ThenInclude(x => x.Ingredients)
                .ToListAsync();
        }

        return recipes;
    }

    public async Task RemoveMealDateRecipe(MealDateRecipe mealDateRecipe)
    {
        using (var context = _dbContextFactory.CreateDbContext())
        {
            context.Remove(mealDateRecipe);
            await context.SaveChangesAsync();
        }
    }

    public async Task<MealDateRecipe> AddSimpleMealToDate(string mealName, DateTime date, int familyId)
    {
        MealDateRecipe mealDateRecipe = new MealDateRecipe()
        {
            Date = date,
            FamilyId = familyId,
            Name = mealName,
        };
        
        using (var context = _dbContextFactory.CreateDbContext())
        {
            await context.AddAsync(mealDateRecipe);
            await context.SaveChangesAsync();
        }

        return mealDateRecipe;
    }

    public async Task<List<Recipe>> GetRecipes()
    {
        List<Recipe> recipes = new List<Recipe>();

        using (var context = _dbContextFactory.CreateDbContext())
        {
            recipes = await context.Recipes.Include(x => x.Ingredients).ToListAsync();
        }
        
        return recipes;
    }
}