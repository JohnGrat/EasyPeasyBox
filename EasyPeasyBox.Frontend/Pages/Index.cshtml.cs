using EasyPeasyBox.Frontend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EasyPeasyBox.Frontend.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ConfService _confService;

    public IndexModel(ILogger<IndexModel> logger, ConfService confService)
    {
        _logger = logger;
        _confService = confService;
    }

    public async Task<IActionResult> OnGetAsync()
    {
        // Use the frontend URL from MyService
        string frontendBaseUrl = _confService.GetFrontendBaseUrl();

        using (HttpClient client = new HttpClient())
        {
            var result = await client.GetAsync($"{frontendBaseUrl}/WeatherForecast");
            if (result.IsSuccessStatusCode)
            {
                var text = await result.Content.ReadAsStringAsync();
                ViewData["WeatherForecast"] = text;
            }
            else
            {
                // Handle error
            }
        }
        return Page();
    }

}
