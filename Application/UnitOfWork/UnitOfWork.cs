using Application.Repositories;
using Application.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork;
public sealed class UnitOfWork : IUnitOfWork, IDisposable{
    private readonly PharmacyContex _Context;
    //-Repositories
    private IRolRepository _Role;
    private IUserRepository _User;
    private IAddressRepository _Addreess;
    private IBuyRepository _Buy;
    private ICategoryRepository _Category;
    private ICityRepository _City;
    private IContact_categoryRepository _Contact_category;
    private IContactRepository _Contact;
    private ICountryRepository _Country;
    private IDepartamentRepository _Departament;
    private IDetail_buyRepository _Detail_buy;
    private IDocument_typeRepository _Document_type;
    private IEmployeeRepository _Employee;
    private IEpsRepository _Eps;
    private IInventoryRepository _Inventory;
    private IMedicine_brandRepository _Medicine_brand;
    private IMedicine_infoRepository _Medicine_Info;
    private IMedicineRepository _Medicine;
    private IOrderRepository _Order;
    private IPersonRepository _Person;
    private IPostRepository _Post;
    private IPresentationRepository _Presentation;
    private IRole_userRepository _Role_user;
    private ISaleRepository _Sale;
    private IStateRepository _State;
    private IType_epsRepository _Type_eps;
    private IType_personRepository _Type_person;
    private IContact_typeRepository _Contact_Types;
    private IChargeRepository _ChangesRepository;
    private IProvider _Provider;
    private IDetail_saleRepository _Detail_sale;

    public UnitOfWork(PharmacyContex context)=>_Context = context;

    //-Singletons
    public IRolRepository Rols => _Role ??= _Role = new Rolrepository(_Context);
    public IUserRepository Users => _User ??= _User = new UserRepository(_Context);
    public IAddressRepository Address => _Addreess ??= _Addreess = new AddressRepository(_Context);

    

    //-Other Properties
    public void Dispose()=> _Context.Dispose();
    public async Task<int> SaveChanges()=> await _Context.SaveChangesAsync();
}
