namespace WMP.Models;

public class Recipe
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Approach { get; set; }
    public string? Source { get; set; }
    public string ThumbnailUrl { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
}