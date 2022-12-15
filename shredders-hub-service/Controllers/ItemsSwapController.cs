using Microsoft.AspNetCore.Mvc;
using shredders_hub_application;
using shredders_hub_application.Models;

namespace shredders_hub_service.Controllers
{
    [Route("items-swap")]
    [ApiController]

    public class ItemsSwapController
    {
        private readonly IShreddersHubRepository _shreddersHubRepository;

        public ItemsSwapController(IShreddersHubRepository shreddersHubRepository)
        {
            _shreddersHubRepository = shreddersHubRepository;
        }

        [HttpGet]
        public Task<List<ItemInfo>> GetItemDetails()
        {
            return _shreddersHubRepository.GetAll();
        }

        [HttpPost]
        public Task AddItemDetails(ItemInfo itemName)
        {
            return _shreddersHubRepository.Add(itemName);
        }
    }
}