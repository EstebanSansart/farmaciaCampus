using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class Type_epsRepository : GenericRepositoryA<Type_eps>, IType_epsRepository{
    public Type_epsRepository(PharmacyContext context) : base(context){}


            protected override async Task<IEnumerable<Type_eps>> GetAll(Expression<Func<Type_eps, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Epss)        
                .Where(expression).ToListAsync();
        }
        return await _Entities
                .Include(x => x.Epss)        
            .ToListAsync();
    }
   

}