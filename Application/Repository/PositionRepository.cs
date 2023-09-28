using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class PositionRepository : GenericRepositoryA<Position>, IPositionRepository{
    public PositionRepository(PharmacyContext context) : base(context){}

    
         protected override async Task<IEnumerable<Position>> GetAll(Expression<Func<Position, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Employees)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Employees)
            .ToListAsync();
    }

}