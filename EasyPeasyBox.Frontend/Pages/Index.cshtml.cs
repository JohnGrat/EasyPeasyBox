using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EasyPeasyBox.Frontend.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }


    public async Task<IActionResult> OnGetAsync()
    {
        using (HttpClient client = new HttpClient())
        {
            var result = await client.GetAsync("http://easypeasybox.backend/WeatherForecast");
            if (result.IsSuccessStatusCode)
            {
                var text = await result.Content.ReadAsStringAsync();
                ViewData["WeatherForecast"] = text;
            }
            else
            {

            }
        }
        return Page();
    }
}
