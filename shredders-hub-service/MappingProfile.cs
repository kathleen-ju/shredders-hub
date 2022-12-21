using AutoMapper;
using shredders_hub_application.Models;
using shredders_hub_service.models.contracts;

namespace shredders_hub_service;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Listing, ListingModel>().ForMember(listing => listing.Title,
                opt => opt.MapFrom(src => src.Title))
            .ForMember(listing => listing.Location,
                opt => opt.MapFrom(src => src.Location));
        CreateMap<ListingModel, Listing>();

    }
}