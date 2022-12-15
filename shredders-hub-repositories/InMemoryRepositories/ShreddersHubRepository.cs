using shredders_hub_application;
using shredders_hub_application.Models;

namespace shredders_hub_repositories.InMemoryRepositories;


public class ShreddersHubRepository : IShreddersHubRepository
{
    private readonly List<ItemInfo> _items = new();
    
    public Task Add(ItemInfo itemInfo)
    {
        
        _items.Add(itemInfo);
        return Task.FromResult("Success!");
    }

    public Task<List<ItemInfo>> GetAll()
    {
        return Task.FromResult(_items);
    }
}