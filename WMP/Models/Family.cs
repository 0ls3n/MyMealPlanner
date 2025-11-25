using WMP.Data;

namespace WMP.Models;

public class Family
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Guid InviteCode { get; set; } = Guid.NewGuid();
    public List<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
}