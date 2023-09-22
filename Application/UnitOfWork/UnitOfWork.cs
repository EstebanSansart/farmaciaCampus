using Application.Repository;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork;
public sealed class UnitOfWork : IUnitOfWork, IDisposable{
    private readonly PharmacyContex _Context;
    //-Repositories
    private IAddressRepository _Addreess;
    private IBuyRepository _Buy;
    private ICategoryRepository _Category;
    private ICityRepository _City;
    private IContact_typeRepository _Contact_Type;
    private IChargeRepository _ChangesRepository;
    private IContactRepository _Contact;
    private ICountryRepository _Country;
    private IContact_categoryRepository _Contact_category;
    private IDepartamentRepository _Departament;
    private IDetail_buyRepository _Detail_buy;
    private IDetail_saleRepository _Detail_sale;
    private IDocument_typeRepository _Document_type;
    private IEmployeeRepository _Employee;
    private IEpsRepository _Eps;
    private IInventoryRepository _Inventory;
    private IMedicine_brandRepository _Medicine_brand;
    private IMedicine_infoRepository _Medicine_Info;
    private IMedicineRepository _Medicine;
    private IOrderRepository _Order;
    private IPersonRepository _Person;
    private IProvider _Provider;
    private IPresentationRepository _Presentation;
    private IRole_userRepository _Role_user;
    private IRolRepository _Rol;
    private ISaleRepository _Sale;
    private IStateRepository _State;
    private IType_epsRepository _Type_eps;
    private IType_personRepository _Type_person;
    private IUserRepository _User;

    public UnitOfWork(PharmacyContex context)=>_Context = context;

    //-Singletons
    public IAddressRepository Address => _Addreess ??= _Addreess = new AddressRepository(_Context);
    public IBuyRepository Buys => _Buy ??= _Buy = new BuyRepository(_Context);
    public ICityRepository Cities => _City ??= _City = new CityRepository(_Context);
    public ICategoryRepository Categories => _Category ??= _Category = new CategoryRepository(_Context);
    public IContact_categoryRepository Contact_Categories => _Contact_category ??= _Contact_category = new Contact_categoryRepository(_Context);
    public IContactRepository Contacts => _Contact ??= _Contact = new ContactRepository(_Context);
    public ICountryRepository Countries => _Country ??= _Country = new CountryRepository(_Context);
    public IDepartamentRepository Departaments  => _Departament ??= _Departament = new DepartamentRepository(_Context);
    public IDetail_buyRepository Detail_Buys => _Detail_buy ??= _Detail_buy = new Detail_buyRepository(_Context);
    public IDetail_saleRepository Detail_Sales => _Detail_sale ??= _Detail_sale = new Detail_saleRepository(_Context);
    public IDocument_typeRepository Document_Types => _Document_type ??= _Document_type = new Document_typeRepository(_Context);
    public IEmployeeRepository Employees => _Employee ??= _Employee = new EmployeeRepository(_Context);
    public IEpsRepository Epss => _Eps ??= _Eps = new EpsRepository(_Context);
    public IInventoryRepository Inventories => _Inventory ??= _Inventory = new InventoryRepository(_Context);
    public IMedicine_brandRepository Medicine_Brands => _Medicine_brand ??= _Medicine_brand = new Medicine_brandRepository(_Context);
    public IMedicine_infoRepository Medicine_Infos => _Medicine_Info ??= _Medicine_Info = new Medicine_infoRepository(_Context);
    public IMedicineRepository Medicines => _Medicine ??= _Medicine = new MedicineRepository(_Context);
    public IOrderRepository Orders => _Order ??= _Order = new OrderRepository(_Context);
    public IPersonRepository People => _Person ??= _Person = new PersonRepository(_Context);
    public IPresentationRepository Presentations => _Presentation ??= _Presentation = new PresentationRepository(_Context);
    public IRolRepository Rols => _Rol ??= _Rol = new Rolrepository(_Context);
    public ISaleRepository Sales => _Sale ??= _Sale = new SaleRepository(_Context);
    public IStateRepository States => _State ??= _State = new StateRepository(_Context);
    public  IType_epsRepository Type_Epss => _Type_eps ??= _Type_eps = new Type_epsRepository(_Context);
    public IType_personRepository Type_People => _Type_person ??= _Type_person = new Type_PersonRepository(_Context);
    public IUserRepository Users => _User ??= _User = new UserRepository(_Context);
 


    

    //-Other Properties
    public void Dispose()=> _Context.Dispose();
    public async Task<int> SaveChanges()=> await _Context.SaveChangesAsync();
}
