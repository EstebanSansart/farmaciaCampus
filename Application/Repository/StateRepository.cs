using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class StateRepository : GenericRepositoryA<State>, IStateRepository{
    public StateRepository(PharmacyContext context) : base(context){}


 protected override async Task<IEnumerable<State>> GetAll(Expression<Func<State, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Medicines)        
                .Where(expression).ToListAsync();
        }
        return await _Entities
                .Include(x => x.Medicines)        
            .ToListAsync();
    }

   

}