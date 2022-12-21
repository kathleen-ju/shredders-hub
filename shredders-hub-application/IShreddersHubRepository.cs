using shredders_hub_application.Models;

namespace shredders_hub_application;

public interface IShreddersHubRepository
{
   Task Add( Listing listing);
   Task<List<Listing>> GetAll();
}