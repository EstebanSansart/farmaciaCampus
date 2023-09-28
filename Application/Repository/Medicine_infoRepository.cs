using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Entities.Generics;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class Medicine_infoRepository : GenericRepositoryA<Medicine_info>, IMedicine_infoRepository{
    public readonly PharmacyContext _context;
    public Medicine_infoRepository(PharmacyContext context) : base(context){
        _context = context;
    }
     protected override async Task<IEnumerable<Medicine_info>> GetAll(Expression<Func<Medicine_info, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Category)        
                .Include(x => x.Presentation)        
                .Include(x => x.Medicine_brand)
                .Include(x => x.Inventories)
                .Where(expression).ToListAsync();
        }
        return await _Entities
                .Include(x => x.Category)        
                .Include(x => x.Presentation)        
                .Include(x => x.Medicine_brand)
                .Include(x => x.Inventories)
            .ToListAsync();
    }
    
    public async Task<dynamic> GetPersonsBoughtParacetamol()
    {
        int yearToFilter = 2023;
        string medicineName = "Paracetamol";

        return await _context.Persons
            .Where(person =>
                person.Sales
                    .Any(sale =>
                        sale.Medicines
                            .Any(medicine => medicine.Name_medicine.ToLower() == medicineName && sale.Sale_Date.Year == yearToFilter)))
            .ToListAsync();
    }
    
    public async Task<IEnumerable<object>> ProvidersWhoHaveProviderMedications(ProvidersWhoHaveProviderMedications data = null){
        var medicines = await (from detail in _context.Set<Detail_buy>()
            join shopping in _context.Set<Buy>() on detail.Buy_Id equals Buy.id
            join medicineInfo in _context.Set<Medicine_info>() on detail.Medicine.Inventory.MedicineInfo.Id equals medicineInfo.Id
            join supplier in _context.Set<Provider>() on Buy.SupplierId equals supplier.Id
            join person in _context.Set<Person>() on supplier.PersonId equals person.Id
            let Price = medicineInfo.Price - (medicineInfo.Price * (medicineInfo.Discount / 100))
            select new {
                Supplier = person.Name,
                medicineInfo.Name,
                Buy.BuyDate,
                Price,
            }).ToListAsync();

        if(data?.InitialDate != null ){
            if( data?.FinalDate != null && data.InitialDate < data.FinalDate){
                medicines = medicines.Where(x => 
                    x.BuyDate <= data.FinalDate  && 
                    x.BuyDate >= data.InitialDate
                ).ToList();
            }else {
                medicines = medicines.Where(x => x.ShoppingDate >= data.InitialDate ).ToList();
            } 
        }        

        return from medicine in medicines 
            group medicine by medicine.Supplier into medicineGroup
            let MoneyInvested = medicineGroup.Sum(x => x.Price)
            let TotalPurchases = medicineGroup.Count()
            orderby TotalPurchases descending
            let medicinesTotals = from medicineTotal in medicineGroup
                group medicineTotal by medicineTotal.Name into medicineTotalGroup
                select  new {
                    medicineTotalGroup.First().Name,
                    TotalPurchases = medicineTotalGroup.Sum(x => x.Price).ToString("c"), 
                    medicinesTotals = medicineTotalGroup.Count()
                }
        select new {
            medicineGroup.First().Supplier,  
            medicines = medicinesTotals,           
            MoneyInvested = MoneyInvested.ToString("c"),
            TotalPurchases
        };            
    }
}