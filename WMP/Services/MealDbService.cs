
using WMP.Models;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace WMP.Services;

public class MealDbService : IMealDbService
{
    private readonly HttpClient _httpClient;

    public MealDbService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }   
    
    public async Task<MealDbRecipe?> GetRandomRecipe()
    {
        MealDbResponse? recipe = null;

        var responseMessage = await _httpClient.GetAsync("/api/json/v1/1/random.php");

        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonRespone = await responseMessage.Content.ReadAsStringAsync();

            recipe = JsonSerializer.Deserialize<MealDbResponse>(jsonRespone);
        }

        return recipe.Meals.FirstOrDefault();
    }

    public async Task<MealDbResponse?> SearchForRecipes(string recipeName)
    {
        MealDbResponse? response = null;

        var responseMessage = await _httpClient.GetAsync($"/api/json/v1/1/search.php?s={recipeName}");

        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonRespone = await responseMessage.Content.ReadAsStringAsync();

            response = JsonSerializer.Deserialize<MealDbResponse>(jsonRespone);
        }

        return response;
    }
}