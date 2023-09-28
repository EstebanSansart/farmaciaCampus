using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class ContactRepository : GenericRepositoryA<Contact>, IContactRepository{
    public ContactRepository(PharmacyContext context) : base(context){}

   
    protected override async Task<IEnumerable<Contact>> GetAll(Expression<Func<Contact, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Person)
                .Include(x => x.Contact_Category)
                .Include(x => x.Contact_Type)
                .Where(expression)
                .ToListAsync();
        }
        return await _Entities   
                .Include(x => x.Person)
                .Include(x => x.Contact_Category)
                .Include(x => x.Contact_Type)
                .ToListAsync();
    }

}