using shredders_hub_service.models.contracts;

namespace shredders_hub_tests.Fakes;

public static class ServiceModelFakes
{
    public static readonly ListingModel FakeListingModel = new()
    {
        Title = "Snow Board",
        Location = "Banff"
    };
}