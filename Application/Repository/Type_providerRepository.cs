using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class Type_providerRepository : GenericRepositoryA<Type_provider>, IType_providerRepository{
    public Type_providerRepository(PharmacyContext context) : base(context){}

   
        protected override async Task<IEnumerable<Type_provider>> GetAll(Expression<Func<Type_provider, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Providers)        
                .Where(expression).ToListAsync();
        }
        return await _Entities
                .Include(x => x.Providers)        
            .ToListAsync();
    }

}