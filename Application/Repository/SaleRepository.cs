using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class SaleRepository : GenericRepositoryA<Sale>, ISaleRepository{

        public readonly PharmacyContext _context;
    public SaleRepository(PharmacyContext context) : base(context){

        _context = context;
    }

      protected override async Task<IEnumerable<Sale>> GetAll(Expression<Func<Sale, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Employee)
                .Include(x => x.Person)
                .Include(x => x.Orders)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Employee)
            .Include(x => x.Person)
            .Include(x => x.Orders)
            .ToListAsync();
    }


public async Task<double> GetPromedioVenta()
{
    var saleMedicineCounts = await _context.Sales
        .Select(sale => sale.Medicines.Count())
        .ToListAsync();

    var average = saleMedicineCounts.Any() ? saleMedicineCounts.Average() : 0;

    return average;
}





public async Task<IEnumerable<object>> GetSalesByEmploye()
{
    int yearToFilter = 2023;

    var salesByEmployee = await _context.Sales
        .Where(sale => sale.Sale_Date.Year == yearToFilter)
        .GroupBy(sale => sale.Id_Employe)
        .Select(group => new
        {
            EmployeeId = group.Key,
            SaleCount = group.Count()
        })
        .ToListAsync();

    return salesByEmployee;
}



   

}