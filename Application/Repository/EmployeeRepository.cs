using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class EmployeeRepository : GenericRepositoryA<Employee>, IEmployeeRepository{
    private readonly PharmacyContext _context;
    public EmployeeRepository(PharmacyContext context) : base(context){
        _context = context;
    }

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
}