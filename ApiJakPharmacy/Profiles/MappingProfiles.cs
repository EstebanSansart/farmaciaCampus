using ApiJakPharmacy.Dtos;
using AutoMapper;
using Domain.Entities;

namespace ApiJakPharmacy.Profiles;
public class MappingProfiles: Profile{
    public MappingProfiles(){

        CreateMap<AddressDto,Address>()
            .ReverseMap();
        CreateMap<AddressFullDto,Address>()
            .ReverseMap();
            
    
    
    }
}