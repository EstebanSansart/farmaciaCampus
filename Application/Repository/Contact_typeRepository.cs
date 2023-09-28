using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class Contact_typeRepository : GenericRepositoryA<Contact_Type>, IContact_typeRepository{
    public Contact_typeRepository(PharmacyContext context) : base(context){}

    protected override async Task<IEnumerable<Contact_Type>> GetAll(Expression<Func<Contact_Type, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Contacts)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Contacts)
            .ToListAsync();
    }

}