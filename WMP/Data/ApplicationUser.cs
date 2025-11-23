using Microsoft.AspNetCore.Identity;
using WMP.Models;

namespace WMP.Data;

public class ApplicationUser : IdentityUser
{
    public int? FamilyId { get; set; }
    public Family? Family { get; set; }
}