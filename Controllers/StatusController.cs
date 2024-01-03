using Microsoft.AspNetCore.Mvc;

namespace webapp.Controllers;

public class StatusController : Controller
{
    
    public async Task<IActionResult> Index()
    {
        var client = new HttpClient();
        var response = await client.GetAsync(@"https://ifconfig.me");
        var responseMessage = await response.Content.ReadAsStringAsync();

        return new OkObjectResult(responseMessage);
    }
    
    public async Task<IActionResult> Internal()
    {
        var client = new HttpClient();
        var response = await client.GetAsync(@"https://webapp-halvard-2.azurewebsites.net/status");
        var responseMessage = await response.Content.ReadAsStringAsync();

        return new OkObjectResult(responseMessage);
    }
}
    

                               