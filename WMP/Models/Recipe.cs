namespace WMP.Models;

public class Recipe
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Approach { get; set; }
    public string? Source { get; set; }
    public int? MealDbId { get; set; }
    public string ThumbnailUrl { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    public List<RecipeIngredient> Ingredients { get; set; } = new List<RecipeIngredient>();
}