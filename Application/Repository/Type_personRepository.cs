using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class Type_PersonRepository : GenericRepositoryA<Type_person>, IType_personRepository{
    public Type_PersonRepository(PharmacyContext context) : base(context){}

        protected override async Task<IEnumerable<Type_person>> GetAll(Expression<Func<Type_person, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Persons)        
                .Where(expression).ToListAsync();
        }
        return await _Entities
                .Include(x => x.Persons)        
            .ToListAsync();
    }

}