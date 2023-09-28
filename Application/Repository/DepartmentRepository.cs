using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class DepartmentRepository : GenericRepositoryA<Department>, IDepartmentRepository{
    public DepartmentRepository(PharmacyContext context) : base(context){}
 protected override async Task<IEnumerable<Department>> GetAll(Expression<Func<Department, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Country)                
                .Include(x => x.Cities)                
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Country)            
            .Include(x => x.Cities)                
            .ToListAsync();
    }
   

}