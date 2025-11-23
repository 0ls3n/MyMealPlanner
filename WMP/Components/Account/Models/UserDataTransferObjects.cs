using System.ComponentModel.DataAnnotations;

namespace WMP.Account.Models;

public class RegisterDTO
{
    [EmailAddress]
    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Username is required")]
    public string Username { get; set; }
    
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }
    
    [Required(ErrorMessage = "Confirm Password is required")]
    [Compare("Password", ErrorMessage = "Password and Confirm Password do not match")]
    public string ConfirmPassword { get; set; }
}

public class SignInDTO
{
    [EmailAddress]
    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }
    
    public bool StaySignedIn { get; set; }
}