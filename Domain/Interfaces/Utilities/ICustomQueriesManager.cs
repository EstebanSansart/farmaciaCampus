using Domain.Models;

namespace Domain.Interfaces;
public interface ICustomQueriesManager{
    Task<IEnumerable<object>> MedicineWithMinStock(int minStock);
    //Task<IEnumerable<MedicineDetailTotalModel>> PurchasedBySupplier (MedicineInfoSupplierModel data);

    Task<IEnumerable<object>> PurchasedByProvider (MedicineInfoProviderModel data);
    Task<IEnumerable<MedicineDetailTotalModel>> TotalDrugSales(string MedicineName);
    Task<IEnumerable<object>> TotalMedicationsSoldByProvider();
    Task<float> MoneyRaisedFromSales(string medicineName = null);
    Task<IEnumerable<object>> TotalMedicineSold(MedicineTotalSoldModel data = null);        
    Task<IEnumerable<object>> EmployeesWhoHaveMadeSales(EmployeesWhoHaveMadeSalesModel data = null); 
    Task<IEnumerable<object>> ProvidersWhoHaveProviderMedications(ProvidersWhoHaveProviderMedications data = null);

    Task<IEnumerable<object>> MedicinesByPriceAndStock(MedicinesByPriceAndStockModel data = null);
    Task<IEnumerable<object>> PatientsWhoHaveAcquiredParacetamol(string Patients = null);      
    Task<IEnumerable<object>> MedicineExpireBeforeYear(int year);
    Task<IEnumerable<object>> MedicationsThatHaveNotBeenSold(int? year);    
    Task<IEnumerable<object>> MedicineExpireInYear(int year);
    Task<object> GetSaleParacetamol(String medicineInput, int Year);
    Task<IEnumerable<object>> TotalMedicinesProvider();
    Task<IEnumerable<object>> ProfitsPerProvider(ProfitsPerSupplierModel data = null);
    Task<object> VipBuyer();
    Task<IEnumerable<object>> PersonNoPurchasedYear();
    Task<IEnumerable<object>> EmployeesWhoHaveProvidedDifferentMedications(WhoHaveProvidedDifferentMedicationsModel data = null);
    Task<IEnumerable<object>> AllSaleCustomer();
    Task<IEnumerable<object>> ProvidersWhoHaveProvidedDifferentMedications(WhoHaveProvidedDifferentMedicationsModel data = null);
    



    


}