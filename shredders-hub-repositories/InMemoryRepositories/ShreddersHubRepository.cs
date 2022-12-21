using shredders_hub_application;
using shredders_hub_application.Models;

namespace shredders_hub_repositories.InMemoryRepositories;


public class ShreddersHubRepository : IShreddersHubRepository
{
    private readonly List<Listing> _items = new();
    
    public Task Add(Listing listing)
    {
        
        _items.Add(listing);
        return Task.FromResult("Success!");
    }

    public Task<List<Listing>> GetAll()
    {
        return Task.FromResult(_items);
    }
}