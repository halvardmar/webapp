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
}
    

                               