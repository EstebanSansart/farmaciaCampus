using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class PersonRepository : GenericRepositoryA<Person>, IPersonRepository{
    public PersonRepository(PharmacyContext context) : base(context){}


         protected override async Task<IEnumerable<Person>> GetAll(Expression<Func<Person, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Epss)
                .Include(x => x.Users)
                .Include(x => x.Employees)
                .Include(x => x.Document_type)
                .Include(x => x.Type_Person)
                .Include(x => x.Sales)
                .Include(x => x.Providers)
                .Include(x => x.Contacts)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Epss)
            .Include(x => x.Users)
            .Include(x => x.Employees)
            .Include(x => x.Document_type)
            .Include(x => x.Type_Person)
            .Include(x => x.Sales)
            .Include(x => x.Providers)
            .Include(x => x.Contacts)
            .ToListAsync();
    }

}