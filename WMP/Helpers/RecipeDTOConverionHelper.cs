using WMP.Models;
using WMP.Models.Data_Transfer_Objects;

namespace WMP.Helpers;

public class RecipeDTOConverionHelper
{
    public static RecipeDTO ConvertMealDbDTO(MealDbRecipe recipe)
    {
        RecipeDTO result = new()
        {
            Name = recipe.Name,
            Source = recipe.Source,
            ThumbnailUrl = recipe.MealThumbnail,
            Instructions = recipe.Instructions,
            MealDbId = int.Parse(recipe.Id)
        };

        foreach (var recipeIngredient in recipe.Ingredients)
        {
            result.Ingredients.Add(new()
            {
                Name = recipeIngredient.Name,
                Measurement =  recipeIngredient.Measure
            });
        }

        return result;
    }

    public static RecipeDTO ConverDbRecipe(Recipe recipe)
    {
        RecipeDTO result = new()
        {
            Name = recipe.Name,
            Source = recipe.Source,
            ThumbnailUrl = recipe.ThumbnailUrl,
            Instructions = recipe.Approach,
            MealDbId = recipe.MealDbId
        };
        
        foreach (var recipeIngredient in recipe.Ingredients)
        {
            result.Ingredients.Add(new()
            {
                Name = recipeIngredient.Name,
                Measurement =  recipeIngredient.Measure
            });
        }

        return result;
    }
}