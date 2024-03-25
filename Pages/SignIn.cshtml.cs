using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class SignInModel : PageModel
{
    private readonly ILogger<SignInModel> _logger;

    public SignInModel(ILogger<SignInModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

