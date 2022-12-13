using shredders_hub_application.Models;

namespace shredders_hub_application;

public interface IShreddersHubRepository
{
   Task Add( ItemInfo itemInfo);
   Task<List<ItemInfo>> GetAll();
}