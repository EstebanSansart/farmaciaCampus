using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class EmployeeRepository : GenericRepositoryA<Employee>, IEmployeeRepository{
    private readonly PharmacyContext _context;
    public EmployeeRepository(PharmacyContext context) : base(context){}

    protected override async Task<IEnumerable<Employee>> GetAll(Expression<Func<Employee, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Person)        
                .Include(x => x.Position)        
                .Include(x => x.Buys)
                .Include(x => x.Sales)
                .Include(x => x.Buys)
                .Where(expression).ToListAsync();
        }
        return await _Entities
                .Include(x => x.Person)        
                .Include(x => x.Position)        
                .Include(x => x.Buys)
                .Include(x => x.Sales)
                .Include(x => x.Buys)
            .ToListAsync();
    }
  /*   public async Task<IEnumerable<object>> GetEmployeSale(){

        var listPerson = _context.Set<Person>();
        var listEmployee = _context.Set<Employee>();
        var listSales = _context.Set<Sale>();

        var query = (
            from person in listPerson
            join employee in listEmployee on person.Id equals employee.PersonId
            join sale in listSales on employee.Id equals sale.Id_Employe
            where sale.Sale_Date.Year == year
            group sale by new {
                                CodEmpleado = employee.Id,
                                Empleado = person.Name,
                                year

                                } into g

            select new {

                Empleado = g.Key,
                Sales = g.Count(),

            }

        );

        return await query.ToListAsync();

    }
 */
}