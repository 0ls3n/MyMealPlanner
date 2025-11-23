namespace WMP.Models.Data_Transfer_Objects;

public class RecipeDTO
{
    public string Name { get; set; }
    public string Instructions { get; set; }
    public string ThumbnailUrl { get; set; }
    public string? Source { get; set; }

    public int? MealDbId { get; set; }
    
    public List<IngredientDTO> Ingredients { get; set; } = new List<IngredientDTO>();
}