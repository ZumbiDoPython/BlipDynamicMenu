using Microsoft.AspNetCore.Mvc;

namespace BlipCreateMenuByChannel.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BlipCreateMenuByChannelController : ControllerBase
{
    private readonly string _comment = "Por aqui está tudo bem";
    private readonly int _secretNumber = 42;
    private readonly string _secretResponse = "a resposta para a vida, o universo e tudo mais";
    
    public BlipCreateMenuByChannelController()
    {
        
    }

    [HttpGet]
    public IActionResult HealthCheck(
        [FromHeader] string? authorization
        )
    {
        if (authorization == _secretNumber.ToString())
        {
            return Ok(_secretResponse);
        }
        return Unauthorized(_comment);
    }

    // [HttpPost]
    // public IActionResult CreateMenuwithDescription()
    // {
    //     
    // }
}