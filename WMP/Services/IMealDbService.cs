using WMP.Models;

namespace WMP.Services;

public interface IMealDbService
{
    public Task<MealDbRecipe?> GetRandomRecipe();
    public Task<MealDbResponse?> SearchForRecipes(string recipeName);
}