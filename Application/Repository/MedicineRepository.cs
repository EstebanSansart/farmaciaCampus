using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class MedicineRepository : GenericRepositoryA<Medicine>, IMedicineRepository{ 
    private readonly PharmacyContext _context;
    public MedicineRepository(PharmacyContext context) : base(context){
        _context = context;

    }



          protected override async Task<IEnumerable<Medicine>> GetAll(Expression<Func<Medicine, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Inventory)        
                .Include(x => x.State)        
                .Include(x => x.Sales)
                .Include(x => x.Detail_Sales)
                .Where(expression).ToListAsync();
        }
        return await _Entities
                .Include(x => x.Inventory)        
                .Include(x => x.State)        
                .Include(x => x.Sales)
                .Include(x => x.Detail_Sales)
            .ToListAsync();
    }


   
    public async Task<IEnumerable<object>> GetProviderMedicineContact(){
            
        var listPersons = _context.Persons.ToList();
        var listContacts = _context.Contacts.ToList();
        var listContactCategory = _context.Contact_Categories.ToList();
        var listContactType = _context.Contact_Types.ToList();
        var listprovider = _context.Providers.ToList();
        var listShopping = _context.Buys.ToList();
        var listMedicine = _context.Medicines.ToList();
        var listMedicineInfo = _context.Medicine_Infos.ToList();
        var query = (
            from person in listPersons
            join provider in listprovider on person.Id equals provider.Id
            join contact in listContacts on person.Id equals contact.Id_person 
            join contactType in listContactType on contact.Id_person equals contactType.Id
            join contactCategory in listContactCategory on contact.Id_person equals contactCategory.Id 
            join Buy in listShopping on provider.Id equals Buy.Id
            join medicine in listMedicine on Buy.Id equals medicine.Id
            join medicineInfo in listMedicineInfo on medicine.Id equals medicineInfo.Id
            select new {
                    id = provider.Id,
                    Name = person.Name,
                    contact = contact.Description,
                    typeContact = contactType.Name,
                    categoriesContact = contactCategory.Name,
                    medicineInfo = medicineInfo.Description
                    }
            ).FirstOrDefault();
            return await Task.FromResult(new[] { query });     
        }

        public async Task<IEnumerable<Medicine>> GetProviderA()
        {
        string providerName = "A"; 

        var medicamentosProveedorA = await _context.Medicines
                .Where(medicina => medicina.Detail_Buys
                .Any(detalle => detalle.Buy.Provider.Name == providerName))
                .ToListAsync();

        return medicamentosProveedorA;
        }

        public async Task<IEnumerable<Medicine>> GetMedicinesExpiringBefore2024()
        {
            DateTime dateToFilter = new(2024, 1, 1);

            return await _context.Medicines
                .Where(medicine => medicine.Date_expiration <= dateToFilter)
                .ToListAsync();
        }

        /*public async Task<Provider> GetProviderWithTotalMedicinesSold(int providerId)
        {
            return await _context.Providers
                .Where(provider => provider.Id == providerId)
                .Select(provider => new Provider
                {
                    Id = provider.Id,
                    Name = provider.Name,
                    TotalMedicinesSold = provider.Buys.SelectMany(buy => buy.Medicines).Count()
                })
                .FirstOrDefaultAsync();
        }*/

        /*public async Task<decimal> GetTotalMoneyRevenue()
        {
            return await _context.Sales
                .Select(sale => sale.Total)
                .SumAsync();
        }*/

        

}