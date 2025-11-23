using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WMP.Account.Models;
using WMP.Data;

namespace WMP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class AccountController : ControllerBase
    {
 
        [HttpPost("signout")]
        public async Task<ActionResult> SignOut(ClaimsPrincipal user, [FromServices] SignInManager<ApplicationUser> signInManager, [FromForm] string returnUrl)
        {
            try
            {
                await signInManager.SignOutAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Redirect($"~/{returnUrl}");
        }
    }
}
