using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using shredders_hub_application;
using shredders_hub_application.Models;
using shredders_hub_service.models.contracts;

namespace shredders_hub_service.Controllers
{
    [Route("listings")]
    [ApiController]

    public class ListingsController
    {
        private readonly IShreddersHubRepository _shreddersHubRepository;
        private readonly IMapper _mapper;

        public ListingsController(IShreddersHubRepository shreddersHubRepository, IMapper mapper)
        {
            _shreddersHubRepository = shreddersHubRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<ListingModel>> GetItemDetails()
        {
            var listing = await _shreddersHubRepository.GetAll();
            return _mapper.Map<List<ListingModel>>(listing);
        }

        [HttpPost]
        public async Task AddListing(ListingModel model)
        {
            var listing = _mapper.Map<Listing>(model);
            await _shreddersHubRepository.Add(listing);
            
            
        }
    }
}