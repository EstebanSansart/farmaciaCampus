using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class CountryRepository : GenericRepositoryA<Country>, ICountryRepository{
    public CountryRepository(PharmacyContext context) : base(context){}
        protected override bool PaginateExpression(Country entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
    protected override async Task<IEnumerable<Country>> GetAll(Expression<Func<Country, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Departments)                
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Departments)            
            .ToListAsync();
    }

   

}