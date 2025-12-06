using WMP.Models;
using WMP.Models.Data_Transfer_Objects;

namespace WMP.Services;

public interface IRecipeService
{
    public Task<Recipe> AddRecipe(RecipeDTO recipe);
    public Task<MealDateRecipe> AddRecipeToDate(Recipe recipe, DateTime date, int familyId);
    public Task<MealDateRecipe> AddSimpleMealToDate(string mealName, DateTime date, int familyId);
    public Task<MealDateRecipe> UpdateMealDateRecipe(MealDateRecipe mealDateRecipe);
    
    public Task<List<MealDateRecipe>> GetMealDateRecipes(int familyId);
    public Task RemoveMealDateRecipe(MealDateRecipe mealDateRecipe);

    public Task<List<Recipe>> GetRecipes();
}