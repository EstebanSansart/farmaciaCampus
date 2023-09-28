using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class CityRepository : GenericRepositoryA<City>, ICityRepository{
    public CityRepository(PharmacyContext context) : base(context){}
    protected override async Task<IEnumerable<City>> GetAll(Expression<Func<City, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Department)
                .Include(x => x.Addresses)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Department)
            .Include(x => x.Addresses)
            .ToListAsync();
    }
}