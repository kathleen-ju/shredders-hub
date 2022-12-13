using Microsoft.AspNetCore.Mvc;

namespace shredders_hub_service.Controllers;

[Route("item-swap")]
[ApiController]

public class GearSwapController
{
    [HttpGet]
    public string Test()
    {
        return "whats upppp world";
    }

    [HttpPost]
    public void AddItemDetails(string itemName)
    {
        
    }
    
}