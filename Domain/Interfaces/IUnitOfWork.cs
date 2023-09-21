using Domain.Entities;

namespace Domain.Interfaces;
public interface IUnitOfWork{
    IRolRepository Rols { get; }    
    IUserRepository Users { get; }
    IAddressRepository Address { get; }
    IBuyRepository Buys {get;}
    ICategoryRepository Categories {get;}
    ICityRepository Cities { get; }
    IContact_categoryRepository Contact_Categories { get; }
    ICountryRepository Countries {get;}
    IDepartamentRepository Departament {get;}
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
    IPostRepository Posts {get;}
    IPresentationRepository Presentations {get;}
    IRole_userRepository Role_Users {get;}
    ISaleRepository Sales {get;}
    IStateRepository States {get;}
    IType_epsRepository Type_epss {get;}
    IType_personRepository Type_Persons {get;}
    IContact_typeRepository Contact_Types {get;}
    IChargeRepository ChangeRepositories {get;}
    IProvider Providers {get;}
    IDetail_saleRepository Detail_Sales {get;}

    
    Task<int> SaveChanges();
}