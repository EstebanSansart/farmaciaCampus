using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class Contact_categoryRepository : GenericRepositoryA<Contact_category>, IContact_categoryRepository{
    public Contact_categoryRepository(PharmacyContext context) : base(context){}
 protected override async Task<IEnumerable<Contact_category>> GetAll(Expression<Func<Contact_category, bool>> expression = null)
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