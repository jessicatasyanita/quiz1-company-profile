using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace quiz1.Pages;

public class CollaborationModel : PageModel
{
    private readonly ILogger<CollaborationModel> _logger;

    public CollaborationModel(ILogger<CollaborationModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
