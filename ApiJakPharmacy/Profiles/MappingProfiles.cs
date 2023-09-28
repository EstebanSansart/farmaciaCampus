using ApiJakPharmacy.Dtos;
using AutoMapper;
using Domain.Entities;

namespace ApiJakPharmacy.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {

        CreateMap<AddressDto, Address>()
            .ReverseMap();
        CreateMap<AddressFullDto, Address>();

        CreateMap<BuyDto, Buy>()
            .ReverseMap();
        CreateMap<BuyFullDto, Buy>();

        CreateMap<CategoryDto, Category>()
            .ReverseMap();
        CreateMap<CategoryFullDto, Category>();

        CreateMap<CityDto, City>()
            .ReverseMap();
        CreateMap<CityFullDto, City>();

        CreateMap<ContactCategoryDto, Contact_category>()
            .ReverseMap();
        CreateMap<ContactCategoryFullDto, Contact_category>();

        CreateMap<ContactDto, Contact>()
            .ReverseMap();
        CreateMap<ContactFullDto, Contact>();

        CreateMap<ContactTypeDto, Contact_Type>()
            .ReverseMap();
        CreateMap<ContactTypeFullDto, Contact_Type>();

        CreateMap<CountryDto, Country>()
            .ReverseMap();
        CreateMap<CountryFullDto, Country>();

        CreateMap<DepartmentDto, Department>()
            .ReverseMap();
        CreateMap<DepartmentFullDto, Department>();

        CreateMap<DocumentTypeDto, Document_type>()
            .ReverseMap();
        CreateMap<DocumentTypeFullDto, Document_type>();

        CreateMap<EmployeeDto, Employee>()
            .ReverseMap();
        CreateMap<EmployeeFullDto, Employee>();

        CreateMap<EpsDto, Eps>()
            .ReverseMap();
        CreateMap<EpsFullDto, Eps>();

        CreateMap<EpsTypeDto, Type_eps>()
            .ReverseMap();
        CreateMap<EpsTypeFullDto, Type_eps>();

        CreateMap<InventoryDto, Inventory>()
            .ReverseMap();
        CreateMap<InventoryFullDto, Inventory>();

        CreateMap<MedicineBrandDto, Medicine_brand>()
            .ReverseMap();
        CreateMap<MedicineBrandFullDto, Medicine_brand>();

        CreateMap<MedicineDto, Medicine>()
            .ReverseMap();
        CreateMap<MedicineFullDto, Medicine>();

        CreateMap<MedicineInfoDto, Medicine_info>()
            .ReverseMap();
        CreateMap<MedicineInfoFullDto, Medicine_info>();

        CreateMap<OrderDto, Order>()
            .ReverseMap();
        CreateMap<OrderFullDto, Order>();

        CreateMap<PersonDto, Person>()
            .ReverseMap();
        CreateMap<PersonFullDto, Person>();

        CreateMap<PersonTypeDto, Type_person>()
            .ReverseMap();
        CreateMap<PersonTypeFullDto, Type_person>();

        CreateMap<PositionDto, Position>()
            .ReverseMap();
        CreateMap<PositionFullDto, Position>();

        CreateMap<PresentationDto, Presentation>()
            .ReverseMap();
        CreateMap<PresentationFullDto, Presentation>();

        CreateMap<ProviderDto, Provider>()
            .ReverseMap();
        CreateMap<ProviderFullDto, Provider>();

        CreateMap<ProviderTypeDto, Type_provider>()
            .ReverseMap();
        CreateMap<StateFullDto, Type_provider>();

        CreateMap<RoleDto, Role>()
            .ReverseMap();
        CreateMap<RoleFullDto, Role>();

        CreateMap<SaleDto, Sale>()
            .ReverseMap();
        CreateMap<SaleFullDto, Sale>();

        CreateMap<StateDto, State>()
            .ReverseMap();
        CreateMap<StateFullDto, State>();

        CreateMap<UserDto, User>()
            .ReverseMap();
        CreateMap<UserFullDto, User>();
    }
}