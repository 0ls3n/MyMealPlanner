namespace WMP.Models;

public class MealDateRecipe
{
    public int Id { get; set; }
    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; }
    
    public int FamilyId { get; set; }
    public Family Family { get; set; }

    public DateTime Date { get; set; }
}