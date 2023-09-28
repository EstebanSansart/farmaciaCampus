using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class EpsRepository : GenericRepositoryA<Eps>, IEpsRepository{
    public EpsRepository(PharmacyContext context) : base(context){}

        protected override async Task<IEnumerable<Eps>> GetAll(Expression<Func<Eps, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Person)        
                .Include(x => x.Type_Eps)        
                .Include(x => x.Orders)
                .Where(expression).ToListAsync();
        }
        return await _Entities
                .Include(x => x.Person)        
                .Include(x => x.Type_Eps)        
                .Include(x => x.Orders)
            .ToListAsync();
    }



}