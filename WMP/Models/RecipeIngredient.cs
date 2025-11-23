namespace WMP.Models;

public class RecipeIngredient
{
    public int Id { get; set; }
    
    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; }
    
    public string Name { get; set; }
    public string Measure { get; set; }
}