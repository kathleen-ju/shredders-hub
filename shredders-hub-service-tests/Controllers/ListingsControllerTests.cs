using AutoMapper;
using Moq;
using shredders_hub_application.Models;
using shredders_hub_repositories.InMemoryRepositories;
using shredders_hub_service_tests.Fakes;
using shredders_hub_service.Controllers;
using shredders_hub_service.models.contracts;

namespace shredders_hub_service_tests.Controllers;

public class ListingsControllerTests
{
    private readonly ListingsController _controller;
    private readonly ListingModel _listingModel = ServiceModelFakes.FakeListingModel;

    public ListingsControllerTests()
    {
        var mapper = new Mock<IMapper>(MockBehavior.Strict);
        var listing = new Listing
        {
            Title = _listingModel.Title,
            Location = _listingModel.Location
        };
            mapper.Setup(x => x.Map<Listing>(_listingModel)).Returns(listing);
            mapper.Setup(x => x.Map<List<ListingModel>>(
                new List<Listing>{listing})).Returns(new List<ListingModel>{_listingModel});
            
        _controller = new ListingsController(new ShreddersHubRepository(), mapper.Object);
    }
    
    [Fact]
    public async Task ShouldAddListing()
    {
        await _controller.AddListing(_listingModel);
        var result = await _controller.GetItemDetails();
        
        Assert.Equal(_listingModel, result.First());
    }
}