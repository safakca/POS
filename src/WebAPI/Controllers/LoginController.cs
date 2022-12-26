using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{
    private readonly SignInManager<AppUser> _userManager;

    public LoginController(SignInManager<AppUser> userManager)
    {
        _userManager = userManager;
    }
    [HttpPost]
    public async Task<IActionResult> Create()
    {
        return Ok();
    }
}
