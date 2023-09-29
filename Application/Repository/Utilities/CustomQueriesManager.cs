using Domain.Entities;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository.Utilities;

public class CustomQueriesManager : ICustomQueriesManager
{
    private static PharmacyContext _Context;
    public CustomQueriesManager(PharmacyContext context)=> _Context = context;
    public async Task<IEnumerable<object>> ProvidersWhoHaveProvidedDifferentMedications(ProvidersWhoHaveProvidedDifferentMedicationsModel data = null){
        var medicines =  await (from detail in _Context.Set<Detail_buy>()
            join buy in _Context.Set<Buy>() on detail.Buy_Id equals buy.Id
            join provider in _Context.Set<Provider>() on buy.Provider_Id equals provider.Id
            join person in _Context.Set<Person>() on provider.PersonId equals person.Id
            join medicine in _Context.Set<Medicine>() on detail.MedicineId equals medicine.Id
            join inventory in _Context.Set<Inventory>() on medicine.Id_Inventory equals inventory.Id
            join info in _Context.Set<Medicine_info>() on inventory.Id_MedicineInfo equals info.Id
            select new {
                Provider = person.Name,
                info.Name,                
                buy.BuyDate,
            }).ToListAsync();

        if(data?.InitialDate != null ){
            if( data?.FinalDate != null && data.InitialDate < data.FinalDate){
                medicines = medicines.Where(x => 
                    x.BuyDate <= data.FinalDate  && 
                    x.BuyDate >= data.InitialDate
                ).ToList();
            }else {
                medicines = medicines.Where(x => x.BuyDate >= data.InitialDate ).ToList();
            } 
        }

        return from medicine in medicines
            group medicine by medicine.Provider into providerGrups
            let medicineGroups = from providerGrup in providerGrups
                group providerGrup by providerGrup.Name into medicineGroups
                let TotalMedicines = medicineGroups.Count()
                select new {
                    medicineGroups.First().Name,
                    TotalMedicines
                }
            let TotalMedications = medicineGroups.Sum(a => a.TotalMedicines)
            let NumberOfDifferentMedications = medicineGroups.Count()
            where NumberOfDifferentMedications >= data.MinimumNumberOfDifferentMedications
            select new {
                providerGrups.First().Provider,
                TotalMedications,
                NumberOfDifferentMedications,
                Medications = medicineGroups
            };
    }
    public async Task<IEnumerable<object>> MedicinesByPriceAndStock(MedicinesByPriceAndStockModel data = null){
        var medicines = await (from detail in _Context.Set<Detail_buy>()
            join medicine in _Context.Set<Medicine>() on detail.MedicineId equals medicine.Id
            join state in _Context.Set<State>() on medicine.Id_state equals state.Id
            join inventory in _Context.Set<Inventory>() on medicine.Id_Inventory equals inventory.Id
            join medicine_Info in _Context.Set<Medicine_info>() on inventory.Medicine_info.Id equals medicine_Info.Id
            join buy in _Context.Set<Buy>() on detail.Buy_Id equals buy.Id
            join provider in _Context.Set<Buy>() on buy.Provider_Id equals provider.Id
            join person in _Context.Set<Person>() on provider.Id equals person.Id
            where state.Id == 1 
            select new {
                Provider = person.Name,
                medicine_Info.Name,
                medicine_Info.Price                
            }).ToListAsync();

        
        var res = from medicine in medicines
            group medicine by medicine.Name into medicineGroups
            let Stock = medicineGroups.Count()
            let TotalEstimated = medicineGroups.Sum(x => x.Price)
            let suppliers = from medicineGroup in medicineGroups
                group medicineGroup by medicineGroup.Provider into supplierGrups
                let TotalPurchases = supplierGrups.Sum(x => x.Price).ToString("c")
                let Units = supplierGrups.Count()
                select new{
                    supplierGrups.First().Provider,
                    Units
                }
            select new{
                medicineGroups.First().Name,
                Stock,                
                UnitPrice = medicineGroups.First().Price,
                TotalEstimated,
                suppliers
            };

        if(data?.Price != null && data?.Price >= 0){
            if(data.HasAHigherPrice == true){
                res = res.Where(x => x.UnitPrice >= data.Price).ToList();
            }else{
                res = res.Where(x => x.UnitPrice <= data.Price).ToList();
            }
        }
        if(data?.Stock != null && data?.Stock >= 0){
            if(data.HasAHigherStock == true){
                res = res.Where(x => x.Stock >= data.Stock).ToList();
            }else{
                res = res.Where(x => x.Stock <= data.Stock).ToList();
            }
        }

        return res.Select(res => new{
                res.Name,
                res.Stock,                
                UnitPrice = res.UnitPrice.ToString("c"),
                res.TotalEstimated,
                res.suppliers
            });
    }
    public async Task<IEnumerable<object>> ProvidersWhoHaveProviderMedications(ProvidersWhoHaveProviderMedications data = null){
        var medicines = await (from detail in _Context.Set<Detail_buy>()
            join buy in _Context.Set<Buy>() on detail.Buy_Id equals buy.Id
            join medicineInfo in _Context.Set<Medicine_info>() on detail.Medicine.Inventory.Medicine_info.Id equals medicineInfo.Id
            join provider in _Context.Set<Provider>() on buy.Provider_Id equals provider.Id
            join person in _Context.Set<Person>() on provider.PersonId equals person.Id
            let Price = medicineInfo.Price - (medicineInfo.Price * (medicineInfo.Discount / 100))
            select new {
                Provider = person.Name,
                medicineInfo.Name,
                buy.BuyDate,
                Price,
            }).ToListAsync();


        if(data?.InitialDate != null ){
            if( data?.FinalDate != null && data.InitialDate < data.FinalDate){
                medicines = medicines.Where(x => 
                    x.BuyDate <= data.FinalDate  && 
                    x.BuyDate >= data.InitialDate
                ).ToList();
            }else {
                medicines = medicines.Where(x => x.BuyDate >= data.InitialDate ).ToList();
            } 
        }        

        var res =  from medicine in medicines 
            group medicine by medicine.Provider into medicineGroup
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
                medicineGroup.First().Provider,  
                medicines = medicinesTotals,           
                MoneyInvested = MoneyInvested.ToString("c"),
                TotalPurchases
            };    

        if(data?.IsUnder != false){
            return res.Where(x => x.TotalPurchases <= data.MinimalMedications);    
        }
        return res.Where(x => x.TotalPurchases >= data.MinimalMedications);     
    }
    public async Task<IEnumerable<object>> EmployeesWhoHaveMadeSales(EmployeesWhoHaveMadeSalesModel data = null){
        var medicines =  await (from detail in _Context.Set<Detail_sale>()
            join sale in _Context.Set<Sale>() on detail.Id_sale equals sale.Id
            join employee in _Context.Set<Employee>() on sale.Id_Employe equals employee.Id
            join person in _Context.Set<Person>() on employee.PersonId equals person.Id
            join medicine_info in _Context.Set<Medicine_info>() on detail.Medicine.Inventory.Id_MedicineInfo equals medicine_info.Id
            let Price = medicine_info.Price - (medicine_info.Price * (medicine_info.Discount / 100))
            select new {
                person.Name,
                Price,
                sale.Sale_Date
            }).ToListAsync();

        if(data?.InitialDate != null ){
            if( data?.FinalDate != null && data.InitialDate < data.FinalDate){
                medicines = medicines.Where(x => 
                    x.Sale_Date <= data.FinalDate  && 
                    x.Sale_Date >= data.InitialDate
                ).ToList();
            }else {
                medicines = medicines.Where(x => x.Sale_Date >= data.InitialDate ).ToList();
            } 
        }

        var res = from medicine in medicines
            group medicine by medicine.Name into medicineGroup
            let RaisedMoney = medicineGroup.Sum(x => x.Price)
            let TotalSales = medicineGroup.Count()
            select new {
                medicineGroup.First().Name,
                RaisedMoney = RaisedMoney.ToString("c"),
                TotalSales
            };
        if(data?.IsUnder != false){
            return res.Where(x => x.TotalSales <= data.MinimumSales);    
        }
        return res.Where(x => x.TotalSales >= data.MinimumSales);
    }
    public async Task<IEnumerable<object>> MedicineWithMinStock (int minStock){
        return await (from medicineItem in _Context.Set<Medicine_info>()
            select new {
                Medicine = new{
                    medicineItem.Id,
                    medicineItem.Name,
                    medicineItem.Price,
                    medicineItem.Discount,
                    medicineItem.Need_order,
                    MedicineBrand = medicineItem.Medicine_brand.Name,
                    MedicinePresentation = medicineItem.Presentation.Name,
                    MedicineCategory = medicineItem.Category.Name
                },
                TotalStock = _Context.Set<Medicine>().  Where(x => x.Inventory.Medicine_info.Name == medicineItem.Name && x.Id_state == 1).Count()
            }).ToListAsync();        
    }

public async Task<IEnumerable<object>> PurchasedByProvider(MedicineInfoProviderModel data)
{
    var details = await _Context.Set<Detail_buy>()
        .Include(detail => detail.Buy)
        .ThenInclude(buy => buy.Provider)
        .Include(detail => detail.Medicine.Inventory.Medicine_info)
        .Where(detail => detail.Medicine != null && detail.Medicine.Inventory != null && detail.Medicine.Inventory.Medicine_info != null)
        .ToListAsync();

    var medicines = details.Select(detail => new
    {
        Date = detail.Buy.BuyDate,
        Supplier = detail.Buy.Provider.Person.Name,
        MedicineName = detail.Medicine.Inventory.Medicine_info.Name,
        Price = detail.Medicine.Inventory.Medicine_info.Price - (detail.Medicine.Inventory.Medicine_info.Price * (detail.Medicine.Inventory.Medicine_info.Discount / 100))
    }).ToList();

    if (data?.InitialDate != null)
    {
        if (data?.FinalDate != null && data.FinalDate < data.InitialDate)
        {
            medicines = medicines.Where(x =>
                x.Date >= (data.HasCoincidence ? data.InitialDate : data.FinalDate) &&
                x.Date <= (data.HasCoincidence ? data.FinalDate : data.InitialDate)
            ).ToList();
        }
        else
        {
            medicines = medicines.Where(x =>
                data.HasCoincidence ? x.Date >= data.InitialDate : x.Date <= data.InitialDate
            ).ToList();
        }
    }

    var res = medicines.GroupBy(medicine => medicine.Supplier)
        .Select(medicineGroup => new
        {
            Supplier = medicineGroup.Key,
            Total = medicineGroup.Sum(x => x.Price),
            Units = medicineGroup.Count()
        });

    if (data?.ProviderName != null)
    {
        return res.Where(x =>
            data.HasCoincidence ? x.Supplier == data.ProviderName : x.Supplier != data.ProviderName
        );
    }

    return res;
}



public async Task<IEnumerable<MedicineDetailTotalModel>> TotalDrugSales(string MedicineName){
        var data  = await (from detail in _Context.Set<Detail_sale>()
                join state in _Context.Set<State>() on detail.Medicine.Id_state equals state.Id
                where detail.Medicine.Inventory.Medicine_info.Name.Trim().ToLower() == MedicineName.Trim().ToLower() && state.Id == 1
                select detail.Medicine.Inventory.Medicine_info
            ).ToListAsync();            
        return MovementDetail( data );
    }    



    public async Task<IEnumerable<object>> TotalMedicationsSoldByProvider(){
        var medicines = await (
                from detail in _Context.Set<Detail_buy>()
                let medicineInfo = detail.Medicine.Inventory.Medicine_info
                join provider in _Context.Set<Provider>() on detail.Buy.Provider_Id equals provider.Id
                join Person in _Context.Set<Person>() on provider.PersonId equals Person.Id
                select  new {                                
                    medicineInfo.Name,
                    Price = medicineInfo.Price - (medicineInfo.Price * (medicineInfo.Discount / 100)),
                    medicineInfo.Description,
                    Supplier = Person.Name
                }).ToListAsync();
        return from medicine in medicines 
            group medicine by medicine.Supplier into medicineGroup               
            select new {
                medicineGroup.First().Supplier,
                TotalSaled = medicineGroup.Sum(x => x.Price).ToString("c"),
                TotalUnits = medicineGroup.Count()
            };
    }
    public async Task<float> MoneyRaisedFromSales(string medicineName = null){

        var medicines =  await (from detail in _Context.Set<Detail_sale>()
            let medicine = detail.Medicine.Inventory.Medicine_info
            select new {
                medicine.Name,
                Price = medicine.Price - (medicine.Price * (medicine.Discount / 100)),
            }).ToListAsync();
        
        var res = from medicine in medicines
            group medicine by medicine.Name into medicineGroup
            select new {
                medicineGroup.First().Name,
                TotalPrice = medicineGroup.Sum(x => x.Price) * medicineGroup.Count(),                
            };

        if(medicineName!= null){
            return res.Where(x => x.Name == medicineName).Sum(x => x.TotalPrice);
        }
        return res.Sum(x => x.TotalPrice);

    }
    public async Task<IEnumerable<object>> TotalMedicineSold(MedicineTotalSoldModel conditions = null){
        var medicines = await (from detail in _Context.Set<Detail_sale>()
            join sale in _Context.Set<Sale>() on detail.Id_sale equals sale.Id
            join medicine in _Context.Set<Medicine_info>() on detail.Medicine.Inventory.Medicine_info.Id equals medicine.Id
            let Price = medicine.Price - (medicine.Price * (medicine.Discount / 100))
            select new {
                sale.Sale_Date,                
                medicine.Name,
                medicine.Description,
                Price
            }).ToListAsync();
        if (conditions != null && conditions?.InitialDate != null){            
            if (conditions.FinalDate != null && conditions.FinalDate < conditions.InitialDate){
                medicines = medicines.Where(x => 
                    x.Sale_Date >= conditions.InitialDate && 
                    x.Sale_Date <= conditions.FinalDate
                ).ToList();
            }else{
                medicines = medicines.Where(x => x.Sale_Date >= conditions.InitialDate).ToList();
            }
        }
        var res =  from medicine in medicines 
            group medicine by medicine.Name into medicineGroup
            let TotalSale = medicineGroup.Sum(x => x.Price)
            let Units = medicineGroup.Count()
            let salesAverage = TotalSale / Units            
            orderby TotalSale descending
            select new {
                medicineGroup.First().Name,
                salesAverage,
                TotalSale = TotalSale.ToString("c"),
                Units
            };
        if (conditions?.GetLessSales == true){
            var avarange = res.Average(x => x.salesAverage);
            return res.Where(x => x.salesAverage <= avarange);
        }
        return res;
    }
    public async Task<IEnumerable<object>> PatientsWhoHaveAcquiredParacetamol(string Patients = null){
        var medicines =  await (from detail in _Context.Set<Detail_sale>()
            join person in _Context.Set<Person>() on detail.Sale.Id_person equals person.Id
            join medicine in _Context.Set<Medicine_info>() on detail.Medicine.Inventory.Medicine_info.Id equals medicine.Id
            let Price = medicine.Price - (medicine.Price * (medicine.Discount / 100))
            select new {
                Patient = person.Name,
                medicine.Name,
                medicine.Description,
                Price
            }).ToListAsync();

        var res = from medicine in medicines 
            group medicine by medicine.Patient into medicineGroup
            let TotalUnits = medicineGroup.Count()
            let TotalPrice = medicineGroup.Sum(x => x.Price)             
            select new {
                medicineGroup.First().Patient,
                medicineGroup.First().Name,
                TotalUnits,
                TotalPrice
            };
        if(Patients != null){
            return res.Where(x => x.Patient.Trim().ToLower() == Patients.Trim().ToLower());
        }
        return res;
    }
    public async Task<IEnumerable<object>> MedicationsThatHaveNotBeenSold(int? year)
{
    year ??= DateTime.Now.Year;
    var medicines = await (from medicine in _Context.Set<Medicine>()
                            join info in _Context.Set<Medicine_info>() on medicine.Inventory.Medicine_info.Id equals info.Id
                            join state in _Context.Set<State>() on medicine.Id_state equals state.Id
                            where !medicine.Sales.Any() && state.Description == "default" && medicine.Date_creation.Year == year
                            select new
                            {
                                medicine.Id,
                                info.Name,
                                medicine.Date_expiration,
                                medicine.Date_creation,
                            }).ToListAsync();

    return from medicine in medicines
           group medicine by medicine.Name into medicineGroup
           let units = medicineGroup.Count()
           select new
           {
               Name = medicineGroup.First().Name,
               TotalUnits = units
           };
}


    private static IEnumerable<MedicineDetailTotalModel> MovementDetail(IEnumerable<Medicine_info> data){
        var medicines =(from detail in data             
            select new MedicineDetailModel{                                
                Name = detail?.Name,
                Price = detail.Price - (detail.Price * (detail.Discount / 100)),
                Description = detail?.Description,
            }).ToList();

        return from medicine in medicines
            group medicine by medicine.Name into grouped
            select new MedicineDetailTotalModel{
                Medicine = grouped.First(),
                Total = grouped.Count()
            };
    }    

        public async Task<IEnumerable<object>> MedicineExpireBeforeYear(int year){
        return await (
            from medicineInfo in _Context.Set<Medicine_info>()
                join inventory in _Context.Set<Inventory>() on medicineInfo.Id equals inventory.Id_MedicineInfo
                join medicine in _Context.Set<Medicine>() on inventory.Id equals medicine.Id_Inventory
                where medicine.Date_expiration.Year > year
                select new
                {
                    id = medicine.Id,
                    Medicine = medicineInfo.Name,
                    Expiration = medicine.Date_expiration
                }).ToListAsync();            
    }

    public async Task<IEnumerable<object>> MedicineExpireInYear(int year){
        return await (
            from medicineInfo in _Context.Set<Medicine_info>()
                join inventory in _Context.Set<Inventory>() on medicineInfo.Id equals inventory.Id_MedicineInfo
                join medicine in _Context.Set<Medicine>() on inventory.Id equals medicine.Id_Inventory
                where medicine.Date_expiration.Year == year
                select new
                {
                    id = medicine.Id,
                    Medicine = medicineInfo.Name,
                    Expiration = medicine.Date_expiration
                }).ToListAsync();            
    }

    public async Task<object> GetSaleParacetamol(string medicineInput, int year)
        {
            string capitalizedMedicineInput = char.ToUpper(medicineInput[0]) + medicineInput.Substring(1);
            var query = (
                    from person in _Context.Set<Person>()
                    join sale in _Context.Set<Sale>() on person.Id equals sale.Id_person
                    join saleDetail in _Context.Set<Detail_sale>() on sale.Id equals saleDetail.Id_sale
                    join medicine in _Context.Set<Medicine>() on saleDetail.Id_medicine equals medicine.Id
                    join inventory in _Context.Set<Inventory>() on medicine.Id equals inventory.Id_MedicineInfo
                    join medicineInfo in _Context.Set<Medicine_info>() on inventory.Id_MedicineInfo equals medicineInfo.Id
                    where medicineInfo.Name == medicineInput && sale.Sale_Date.Year == year
                                    select new
                                    {
                                        PersonId = person.Id,
                                        person.Name,
                                        MedicineName = medicineInfo.Name,
                                        Price = medicineInfo.Price,
                                        DateSale = sale.Sale_Date
                                    }).ToListAsync();
            return await query;
        }
    public async Task<IEnumerable<object>> TotalMedicinesProvider()
    {
    var medicines = await _Context.Set<Detail_buy>()
        .Join(_Context.Set<Provider>(), detail => detail.Buy.Provider_Id, provider => provider.Id, (detail, provider) => new { detail, provider })
        .Join(_Context.Set<Person>(), combined => combined.provider.PersonId, person => person.Id, (combined, person) => new { combined.detail, combined.provider,person })
        .Select(result => new
        {
            Name = result.detail.Medicine.Inventory.Medicine_info.Name,
            Price = result.detail.Medicine.Inventory.Medicine_info.Price - (result.detail.Medicine.Inventory.Medicine_info.Price * (result.detail.Medicine.Inventory.Medicine_info.Discount / 100)),
            result.detail.Medicine.Inventory.Medicine_info.Description,
            Provider = result.person.Name
        })
        .ToListAsync();

    var groupedMedicines = medicines.GroupBy(medicine => medicine.Provider)
        .Select(medicineGroup => new
        {
            Provider = medicineGroup.First().Provider,
            TotalSold = medicineGroup.Sum(x => x.Price).ToString("c"),
            TotalUnits = medicineGroup.Count()
        });

    return groupedMedicines;
    }
    public async Task<IEnumerable<object>> ProfitsPerProvider(ProfitsPerProviderModel data = null){

        var medicines =  await (
            from detail in _Context.Set<Detail_buy>()
            join medicine in _Context.Set<Medicine>() on detail.MedicineId equals medicine.Id
            join inventory in _Context.Set<Inventory>() on medicine.Id_Inventory equals inventory.Id
            join info in _Context.Set<Medicine_info>() on  inventory.Medicine_info equals info.Id
            join buy in _Context.Set<Buy>() on detail.Buy_Id equals buy.Id
            join provider in _Context.Set<Provider>() on buy.Provider_Id equals provider.Id
            join person in _Context.Set<Person>() on provider.PersonId equals person.Id
            let Price = info.Price - (info.Price * (info.Discount / 100))
            select new {
                person.Name,
                Price,
                Date = buy.BuyDate
            }
        ).ToListAsync();

        if(data?.InitialDate != null ){
            if( data?.FinalDate != null && data.InitialDate < data.FinalDate){
                medicines = medicines.Where(x => 
                    x.Date <= data.FinalDate  && 
                    x.Date >= data.InitialDate
                ).ToList();
            }else {
                medicines = medicines.Where(x => x.Date >= data.InitialDate ).ToList();
            } 
        }

        var res =  from supplier in medicines
            group supplier by supplier.Name into supplierGroup
            let Units = supplierGroup.Count()
            let Total = supplierGroup.Sum(x => x.Price)
            select new {
                supplierGroup.First().Name,
                Units,
                Total = Total.ToString("c")
            };

        if(data?.ProviderName != null){
            return res.Where(x => x.Name.Trim().ToLower() == data.ProviderName.Trim().ToLower() );
        }
        return res;
    }

    
}

