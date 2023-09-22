namespace Domain.Interfaces;
public interface IUnitOfWork{
    IAddressRepository Address { get; }
    IBuyRepository Buys {get;}
    ICategoryRepository Categories {get;}
    IContact_typeRepository Contact_Types {get;}
    ICityRepository Cities { get; }
    IContact_categoryRepository Contact_Categories { get; }
    ICountryRepository Countries {get;}
    IDepartmentRepository Departments {get;}
    IDetail_saleRepository Detail_Sales {get;}
    IDetail_buyRepository Detail_buys {get;}
    IDocument_typeRepository Document_Types {get;}
    IEmployeeRepository Employees {get;}
    IEpsRepository Epss {get;}
    IInventoryRepository Inventories {get;}
    IMedicine_brandRepository Medicine_Brands {get;}
    IMedicine_infoRepository Medicine_Info {get;}
    IMedicineRepository Medicines {get;}
    IOrderRepository Orders {get;}
    IPersonRepository Persons {get;}
    IPresentationRepository Presentations {get;}
    IProviderRepository Providers {get;}
    IPositionRepository Positions {get;}
    IRolRepository Rols { get; }  
    IRole_userRepository Role_Users {get;}
    ISaleRepository Sales {get;}
    IStateRepository States {get;}
    IType_epsRepository Type_epss {get;}
    IType_personRepository Type_Persons {get;}
    IUserRepository Users {get;}
    Task<int> SaveChanges();
}