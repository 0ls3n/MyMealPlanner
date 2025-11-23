namespace WMP.Models;

public class Ingredient
{
    public enum IngredientType
    {
        Vegetable = 0,
        Fruit = 1,
        Meat = 2,
        Poultry = 3,
        Seafood = 4,
        Dairy = 5,
        Grain = 6,
        Legume = 7,
        Nut = 8,
        Seed = 9,
        Herb = 10,
        Spice = 11,
        Oil = 12,
        Sauce = 13,
        Condiment = 14,
        Sweetener = 15,
        Baking = 16,
        Beverage = 17,
        Other = 18
    }
    
    public int Id { get; set; }
    public string Name { get; set; }
    public IngredientType Type { get; set; }
    
}

